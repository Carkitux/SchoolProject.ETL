﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SchoolProject.ETL.Model.Enums;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

// Inspiration https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c

namespace SchoolProject.ETL.Model.Logging
{
    public static class LogWriter
    {
        public static string applicationLoglevelString = GetLoglevelConfig();

        static LogWriter()
        {
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            bool doNewLine = File.Exists(filePath);
            using (StreamWriter textWriter = File.AppendText(filePath))
            {
                if (doNewLine)
                    textWriter.WriteLine("");
                textWriter.WriteLine($"Started new Log from {DateTime.Now}:");
                textWriter.WriteLine("-----------------------------------------");
            }
        }

        public static string logPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "Logs";
        public static string logFile = $"Log {DateTime.Now.GetDateTimeFormats()[2]} {DateTime.Now.GetHashCode()}.txt";
        public static string filePath = logPath + "\\" + logFile;
        public static bool SkipLogging = false;

        public static int FileCount
        {
            get { return Directory.GetFiles(logPath).Length; }
        }

        public static float FileSizeMBAll
        {
            get
            {
                float fileSize = 0;
                foreach (var fullFilePath in Directory.GetFiles(logPath))
                {
                    FileInfo fileInfo = new FileInfo(fullFilePath);
                    fileSize += fileInfo.Length;
                }
                fileSize = (float)Math.Round(fileSize / 1024 / 1024, 2);
                return fileSize;
            }
        }

        public static float FileSizeMBCurrent
        {
            get
            {
                float fileSize = 0;
                FileInfo fileInfo = new FileInfo(filePath);
                fileSize += fileInfo.Length;
                fileSize = (float)Math.Round(fileSize / 1024 / 1024, 2);
                return fileSize;
            }
        }

        public static void Log(string logMessage, Loglevel loglevel)
        {
            if (SkipLogging)
            {
                return;
            }

            Loglevel applicationLoglevel = (Loglevel)Enum.Parse(typeof(Loglevel), GetLoglevelConfig());
            if (!(applicationLoglevel <= loglevel))
            {
                return;
            }

            WriteInFile("\t" + DateTime.Now + ": " + logMessage);
        }

        public static void LogHeader(string logMessage, Loglevel loglevel)
        {
            if (SkipLogging)
            {
                return;
            }

            Loglevel applicationLoglevel = (Loglevel)Enum.Parse(typeof(Loglevel), GetLoglevelConfig());
            if (!(applicationLoglevel <= loglevel))
            {
                return;
            }

            logMessage = DateTime.Now + ": " + logMessage;
            string stringLine = string.Empty;
            for (int i = 0; i < logMessage.Length; i++)
            {
                stringLine += "-";
            }

            WriteInFile("\t");
            WriteInFile("\t" + logMessage);
            WriteInFile("\t" + stringLine);
        }

        public static void LogFooter(string logMessage, Loglevel loglevel)
        {
            if (SkipLogging)
            {
                return;
            }

            Loglevel applicationLoglevel = (Loglevel)Enum.Parse(typeof(Loglevel), GetLoglevelConfig());
            if (!(applicationLoglevel <= loglevel))
            {
                return;
            }

            logMessage = DateTime.Now + ": " + logMessage;
            string stringLine = string.Empty;
            for (int i = 0; i < logMessage.Length; i++)
            {
                stringLine += "-";
            }

            WriteInFile("\t" + stringLine);
            WriteInFile("\t" + logMessage);
            WriteInFile("\t");
        }

        private static void WriteInFile(string logMessage)
        {
            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(logMessage);
            }
        }

        public static string GetLastLines(int countLastLines)
        {
            string[] lines = File.ReadLines(filePath, Encoding.UTF8).ToArray();
            int linesCount = lines.Count();

            string lastLines = string.Empty;

            if (linesCount < countLastLines)
            {
                countLastLines = linesCount;
            }

            string[] lastLinesReverse = new string[countLastLines];

            for (int i = 1; i <= countLastLines; i++)
            {
                lastLinesReverse[i - 1] = lines[linesCount - i];
            }

            bool first = true;
            foreach (var item in lastLinesReverse.Reverse())
            {
                if (first)
                {
                    lastLines += item;
                    first = false;
                }
                else
                {
                    lastLines += Environment.NewLine + item;
                }
            }

            return lastLines;
        }

        private static string GetLoglevelConfig()
        {
            var json = File.ReadAllText("Logging\\LogConfiguration.json");
            var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
            applicationLoglevelString = (string)jsonObject.GetValue("Loglevel");
            return applicationLoglevelString;
        }

        public static void SetLoglevelConfig(string loglevel)
        {
            var logConfigPath = "Logging\\LogConfiguration.json";
            var jsonRead = File.ReadAllText(logConfigPath);
            var jsonObject = JsonConvert.DeserializeObject<JObject>(jsonRead);

            jsonObject["Loglevel"] = loglevel;
            applicationLoglevelString = loglevel;

            var jsonWrite = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText(logConfigPath, jsonWrite);
        }
    }
}