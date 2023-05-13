using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.Logging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SchoolProject.ETL.Model.LogicClasses.Serializer
{
    public class JSON
    {
        static int loggingDataRowCount = 0;
        static int loggingDataRowCellCount = 0;

        public static StagingObject LoadFromJson(string path)
        {
            LogWriter.LogHeader($"Step Extract - Startet Import JSON: \"{path}\"", Loglevel.Zusammengefasst);
            loggingDataRowCount = 0;
            loggingDataRowCellCount = 0;

            string fileName = Helper.GetFileName(path);
            var stagingObject = new StagingObject(fileName)
            {
                FilePath = path
            };

            // Holt alle JSON Objekte innerhalb der JSON Datei und speichert sie in einer Liste.
            var json = File.ReadAllText(path);
            var jsonObjects = JsonConvert.DeserializeObject<List<JObject>>(json);

            foreach (var jsonObject in jsonObjects)
            {
                loggingDataRowCount++;
                // Erstellt einen Datensatz mit einer ID, dem Type der eingelesenen Datei und der Liste der Key Value Paare.
                var datensatz = new DataRow(stagingObject, fileName);

                // Geht alle Properties eines JSON Objekt Datensatzes durch.
                foreach (var property in jsonObject.Properties())
                {
                    loggingDataRowCellCount++;
                    var attribut = stagingObject.Attributes.Where(x => x.Name == property.Name).FirstOrDefault();
                    if (attribut is null)
                    {
                        var newAttribut = new Attribut(stagingObject, property.Name, 0);
                        stagingObject.Attributes.Add(newAttribut);
                        attribut = newAttribut;
                    }
                    // Erstellt ein neues SingleData Objekt
                    var singleData = new DataRowCell(datensatz, attribut, property.Value.ToString());

                    // Fügt das Key Value Paar der Lise hinzu, um so eine Liste mit allen Paaren eines Json Datensatzes zu bekommen
                    datensatz.DataRowCells.Add(singleData);
                }
                //Fügt den Datensatz der datensatz Liste hinzu, um dann eine vollständige Liste mit allen Json Datensätzen aus der .json Datei zu bekommen.
                stagingObject.DataRows.Add(datensatz);
            }
            LogWriter.LogFooter($"Step Extract - Ende Import JSON: \"{path}\"" +
                $"\n\t {loggingDataRowCount} Zeilen mit insgesamt {loggingDataRowCellCount} Zellen wurden extrahiert."
                , Loglevel.Zusammengefasst);
            // Fügt das Staging Object unserer global verfügabren Staging Area für spätere Benutzung hinzu
            // und returned das aktuelle Staging Object für eine Verwendung im Frontend
            StagingArea.StObjects.Add(stagingObject);
            return stagingObject;
        }

        public static void CreateJSON(string path)
        {
            LogWriter.LogHeader($"Step Load - Startet Export JSON: \"{path}\"", Loglevel.Zusammengefasst);
            loggingDataRowCount = 0;
            loggingDataRowCellCount = 0;
            // Das TranformStagingObjekt, in dem die transformierte Tabelle gespeichert ist
            var stagingObject = StagingArea.TransformStObject;
            stagingObject.FilePath = path;

            var list = new List<JObject>();
            foreach (var datensatz in stagingObject.DataRows)
            {
                loggingDataRowCount++;
                var jObj = new JObject();
                foreach (var singleData in datensatz.DataRowCells)
                {
                    loggingDataRowCellCount++;
                    jObj.Add(new JProperty(singleData.Attribut.Name, singleData.Value));
                }
                list.Add(jObj);
            }

            var json = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(path, json);

            LogWriter.LogFooter($"Step Load - Ende Export JSON: \"{path}\"" +
                $"\n\t {loggingDataRowCount} Objecte mit insgesamt {loggingDataRowCellCount} Values wurden in die JSON Datei geschrieben."
                , Loglevel.Zusammengefasst);
        }
    }
}