using System.Xml;
using System.Linq;
using SchoolProject.ETL.Model.Enums;
using SchoolProject.ETL.Model.DataClasses;

namespace SchoolProject.ETL.Model.LogicClasses.Serializer
{
    public class XML
    {
        public static StagingObject LoadFromXmlFile(string path)
        {
            // Holt alle XML Objekte innerhalb der XML Datei und speichert sie in einem Dokument.
            var doc = new XmlDocument();
            doc.Load(path);

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            var filepath = path.Split('\\');
            var filename = filepath[^1];

            // Erstellen des neuen StagingObjects
            var stagingObject = new StagingObject(filename);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                // Erstellen eines neuen Datensatzes für jedes Objekt der XML
                var d = new DataRow(stagingObject, filename);

                foreach (XmlNode node2 in node.ChildNodes)
                {
                    var attribut = stagingObject.Attributes.Where(x => x.Name == node2.Name).FirstOrDefault();
                    if (attribut is null)
                    {
                        var newAttribut = new Attribut(stagingObject, node2.Name, Datatyp.Unknown);
                        stagingObject.Attributes.Add(newAttribut);
                        attribut = newAttribut;
                    }
                    var sd = new DataRowCell(d, attribut, node2.InnerText);

                    // Fügt das erstellte SingleData dem Datensatz hinzu
                    d.DataRowCells.Add(sd);
                    //LogWriter.LogWrite(attribut + " " + inhalt);
                }
                // Fügt den Datensatz dem aktuellem Staging Objekt hinzu
                stagingObject.DataRows.Add(d);
            }
            // Fügt das Staging Object unserer global verfügabren Staging Area für spätere Benutzung hinzu
            // und returned das aktuelle Staging Object für eine Verwendung im Frontend
            StagingArea.StObjects.Add(stagingObject);
            return stagingObject;
        }

        public static void CreateXML(string path)
        {
            // Objekt, in dem die transformierte Tabelle gespeichert ist.
            var stagingObject = StagingArea.StObjects[0];

            // Erstellung des Dokumentes und der Deklaration.
            var xmlDocument = new XmlDocument();
            var declaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(declaration);

            var root = xmlDocument.CreateElement("vereinsverwaltung");
            xmlDocument.AppendChild(root);

            foreach (var datensatz in stagingObject.DataRows)
            {
                // Erstellen von Xml Elementen für jeden Datensatz.
                var singleDataList = xmlDocument.CreateElement("mitglied");

                // Hinzufügen der Key-Value-Paare aus jedem Single Data Objekt als XML Element zum mitglied XML Element.
                foreach (var singleData in datensatz.DataRowCells)
                {
                    var singleDataElement = xmlDocument.CreateElement(singleData.Attribut.Name);
                    singleDataElement.InnerText = singleData.Value;
                    singleDataList.AppendChild(singleDataElement);
                }
                // Hinzufügen des Mitglied Xml Elements zum übergeordneten Vereinsverwaltung Element.
                root.AppendChild(singleDataList);
            }
            // Exportieren des Xml Dokumentes in den ausgewählten Pfad.
            xmlDocument.Save(path);
        }
    }
}