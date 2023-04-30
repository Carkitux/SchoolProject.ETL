﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.DataClasses.StagingObjectAgr;
using SchoolProject.ETL.Model.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SchoolProject.ETL.Model.LogicClasses.Serializer
{
    public class JSON
    {
        public static StagingObject LoadFromJson(string path)
        {
            // Holt alle JSON Objekte innerhalb der JSON Datei und speichert sie in einer Liste.
            var json = File.ReadAllText(path);
            var jsonObjects = JsonConvert.DeserializeObject<List<JObject>>(json);

            // Lesen des Dateinamens aus dem übergebenen Dateipfad
            var filePath = path.Split('\\');
            var fileName = filePath[^1];

            // Erstellen des neuen StagingObjects
            StagingObject stagingObject = new StagingObject(fileName);

            foreach (var jsonObject in jsonObjects)
            {
                // Erstellt einen Datensatz mit einer ID, dem Type der eingelesenen Datei und der Liste der Key Value Paare.
                DataRow datensatz = new DataRow(stagingObject, fileName, Filetyp.JSON);

                // Geht alle Properties eines JSON Objekt Datensatzes durch.
                foreach (var property in jsonObject.Properties())
                {
                    Attribut attribut = stagingObject.Attributes.Where(x => x.Name == property.Name).FirstOrDefault();
                    if (attribut is null)
                    {
                        Attribut newAttribut = new Attribut(stagingObject, property.Name, 0);
                        stagingObject.Attributes.Add(newAttribut);
                        attribut = newAttribut;
                    }
                    // Erstellt ein neues SingleData Objekt
                    DataRowCell singleData = new DataRowCell(datensatz, attribut, property.Value.ToString());

                    // Fügt das Key Value Paar der Lise hinzu, um so eine Liste mit allen Paaren eines Json Datensatzes zu bekommen
                    datensatz.DataRowCells.Add(singleData);
                }
                //Fügt den Datensatz der datensatz Liste hinzu, um dann eine vollständige Liste mit allen Json Datensätzen aus der .json Datei zu bekommen.
                stagingObject.DataRows.Add(datensatz);
            }
            // Fügt das Staging Object unserer global verfügabren Staging Area für spätere Benutzung hinzu
            // und returned das aktuelle Staging Object für eine Verwendung im Frontend
            StagingArea.StObjects.Add(stagingObject);
            return stagingObject;
        }

        public static void CreateJSON(string path)
        {
            // Das TranformStagingObjekt, in dem die transformierte Tabelle gespeichert ist
            StagingObject stagingObject = StagingArea.StObjects[0]; //.Where(x => x.IamTransform).First();

            var list = new List<JObject>();
            foreach (var datensatz in stagingObject.DataRows)
            {
                var jObj = new JObject();
                foreach (var singleData in datensatz.DataRowCells)
                {
                    jObj.Add(new JProperty(singleData.Attribut.Name, singleData.Value));
                }
                list.Add(jObj);
            }

            var json = JsonConvert.SerializeObject(list);

            File.WriteAllText(path, json);
        }
    }
}