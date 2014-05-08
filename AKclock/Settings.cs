using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace AKclock{
    class Settings{
        private static StreamReader sRead;
        private static StreamWriter sWrite;
        private static string settingsFile = "settings.cfg";
        private static Dictionary<string, string> settingsDictionary = new Dictionary<string, string>();

        // default constructor
        public Settings(){
            CreateDefaultValues();
            ReadFromFile();
        }

        public static void CreateDefaultValues() {
            // these defaults will be used if settings cannot be read
            settingsDictionary.Clear();
            settingsDictionary.Add("formWidth", "85");
            settingsDictionary.Add("formHeight", "29");
            settingsDictionary.Add("screenCorner", "4");
            settingsDictionary.Add("fontName", "Verdana");
            settingsDictionary.Add("fontSize", "8");
            settingsDictionary.Add("fontBold", "false");
            settingsDictionary.Add("fontItalic", "false");
            settingsDictionary.Add("fontStrikeout", "false");
            settingsDictionary.Add("fontUnderline", "false");
            settingsDictionary.Add("fontColorRed", "255");
            settingsDictionary.Add("fontColorGreen", "255");
            settingsDictionary.Add("fontColorBlue", "255");
            settingsDictionary.Add("formColorRed", "192");
            settingsDictionary.Add("formColorGreen", "152");
            settingsDictionary.Add("formColorBlue", "62");
            settingsDictionary.Add("dateFormat", "ddd MMM d");
            settingsDictionary.Add("timeFormat", "h:mm:ss tt");
            settingsDictionary.Add("dateOnTop", "true");
        }

        // write settings
        public static void WriteToFile(){
            try { // save each entry in dictionary into settings
                sWrite = new StreamWriter(settingsFile);
                foreach (KeyValuePair<string, string> entry in settingsDictionary) {
                    sWrite.WriteLine(entry.Key + "=" + entry.Value);
                }
                sWrite.Close();
            } catch { // on error, close and delete the file
                sWrite.Close();
                File.Delete(settingsFile);
                MessageBox.Show("Error saving " + settingsFile + "\nPlease try again.");
            }
        }

        // read settings
        public static void ReadFromFile(){
            if (File.Exists(settingsFile)) {
                try {
                    sRead = new StreamReader(settingsFile);
                    while (!sRead.EndOfStream) {
                        string line = sRead.ReadLine();
                        string key = line.Split('=')[0];
                        string val = line.Split('=')[1];
                        settingsDictionary[key] = val;
                    }
                    sRead.Close();
                } catch {   // if the file cannot be read, delete it and use defaults
                    sRead.Close();
                    File.Delete(settingsFile);
                    MessageBox.Show("Error reading " + settingsFile + "\nDefault values will be used.");
                    CreateDefaultValues();
                    WriteToFile();
                }
            } else {    // settings does not exist, create it
                WriteToFile();
            }
        }

        // set a key's value
        public static void SetDictionaryValue(string key, string val) {
            settingsDictionary[key] = val;
        }

        public static string GetDictionaryValue(string key) {
            return settingsDictionary[key];
        }
    }
}
