using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;

namespace SchoolProject.ETL.Model.LogicClasses.Serializer
{
    public class CSV
    {
        static int loggingDataRowCount = 0;
        static int loggingDataRowCellCount = 0;

        public static void LoadFromCSV(string path, string separator, bool hasHeader)
        {
            LogWriter.LogHeader($"Step Extract - Startet Export CSV: \"{path}\"", Loglevel.Zusammengefasst);

            loggingDataRowCount = 0;
            loggingDataRowCellCount = 0;

            string fileName = Helper.GetFileName(path);
            var stagingObject = new StagingObject(fileName);
            stagingObject.FilePath = path;

            // Liest alle Zeilen der CSV Datei in ein IEnumerable ein
            var lines = File.ReadLines(path);

            // Befüllt das StagingObject mit allen Attributen und Zeilen der CSV
            CSVHeader(separator, hasHeader, lines, stagingObject);
            CSVLines(separator, hasHeader, lines, fileName, stagingObject);

            LogWriter.LogFooter($"Step Extract - Ende Export CSV: \"{path}\"" +
                $"\n\t {loggingDataRowCount} Zeilen mit insgesamt {loggingDataRowCellCount} Zellen wurden extrahiert."
                , Loglevel.Zusammengefasst);

            // Fügt das Staging Object unserer global verfügbaren Staging Area für spätere Benutzung hinzu
            StagingArea.StObjects.Add(stagingObject);
        }
        public static StagingObject LoadTempFromCSV(string path, string separator, bool hasHeader, int lineCount)
        {
            LogWriter.SkipLogging = true;

            // Liest X Zeilen der CSV Datei in einen String ein
            var lines = File.ReadLines(path);
            lines = lines.Reverse().Skip(lines.Count() - lineCount).Reverse();

            var fileName = Helper.GetFileName(path);
            var tempStagingObject = new StagingObject(fileName);

            // Befüllt das temporäre StagingObject mit allen Attributen und den X Zeilen der CSV
            CSVHeader(separator, hasHeader, lines, tempStagingObject);
            CSVLines(separator, hasHeader, lines, fileName, tempStagingObject);

            LogWriter.SkipLogging = false;

            // Gibt das temporäre StagingObject zur weiteren Verwendung zurück, da dieses diemsal nicht in die StagingArea integriert wird
            return tempStagingObject;
        }

        private static void CSVHeader(string separator, bool hasHeader, IEnumerable<string> lines, StagingObject stagingObject)
        {
            // Wenn die CSV Datei Header hat, dann werden diese als Attribute im erstellten Staging Object hinterlegt
            // um diese später den einzelnen Daten zuweisen zu können
            if (hasHeader)
            {
                var attribute = lines.First().Replace(separator + " ", separator).Split(separator);
                foreach (var attributName in attribute)
                {
                    var newAttribut = new Attribut(stagingObject, attributName, Datatyp.unknown);
                    stagingObject.Attributes.Add(newAttribut);
                }
            }
            // Wenn die CSV Datei keine Header hat, wird für jede Spalte ein Ersatz Attribut erzeugt mit hochzählenden Spaltennamen
            else
            {
                var count = lines.First().Replace(separator + " ", separator).Split(separator).Count();
                for (int i = 0; i < count; i++)
                {
                    var newAttribut = new Attribut(stagingObject, $"Spalte{i}", Datatyp.unknown);
                    stagingObject.Attributes.Add(newAttribut);
                }
            }
        }
        private static void CSVLines(string separator, bool hasHeader, IEnumerable<string> lines, string dateiname, StagingObject stagingObject)
        {
            if (hasHeader)
            {
                lines = lines.Skip(1);
            }

            foreach (var line in lines)
            {
                // Erstellen eines neuen Datensatzes für jede Zeile der CSV
                var datensatz = new DataRow(stagingObject, dateiname);

                // Splittet die Zeile nach dem übergeben Seperator in einzelne Felder zum einfügen in SingleData
                var fields = line.Replace(separator + " ", separator).Split(separator);

                // Zähler um das jeweilige Attribut zuweisen zu können
                var currentFieldID = 0;
                foreach (var field in fields)
                {
                    DataRowCell singleData;

                    try
                    {
                        singleData = new DataRowCell(datensatz, stagingObject.Attributes[currentFieldID], field);
                    }
                    catch (Exception)
                    {
                        stagingObject.CreateAttribut("Spalte" + currentFieldID, Datatyp.unknown);
                        singleData = new DataRowCell(datensatz, stagingObject.Attributes[currentFieldID], field);
                    }
                    // Fügt das erstellte SingleData dem Datensatz hinzu
                    datensatz.DataRowCells.Add(singleData);

                    currentFieldID++;
                    loggingDataRowCellCount++;
                }
                loggingDataRowCount++;

                // Fügt den Datensatz dem aktuellem Staging Objekt hinzu
                stagingObject.DataRows.Add(datensatz);
            }
        }

        public static void CreateCSV(string path)
        {
            // Das TranformStagingObjekt, in dem die transformierte Tabelle gespeichert ist
            var stagingObject = StagingArea.TransformStObject;
            stagingObject.FilePath = path;

            // Schreiben des CSV Headers mit Semikolon Seperator
            using var writer = new StreamWriter(path);
            writer.WriteLine(string.Join(';', stagingObject.Attributes));

            foreach (var dataRow in stagingObject.DataRows)
            {
                // Für jedes SingleData Objekt wird nur der Inhalt in ein Array geschrieben
                // und dieser wird dann Zeile für Zeile in die Datei geschrieben
                var csvRow = dataRow.DataRowCells.Select(x => x.Value).ToArray();
                writer.WriteLine(string.Join(';', csvRow));
            }
        }
    }
}