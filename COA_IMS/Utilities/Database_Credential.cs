using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_IMS
{
    internal class Database_Credential
    {
        //public static string server = "localhost";
        //public static string database = "db_ims";
        //public static string uid = "root";
        //public static string pwd = "@tso011235813";
        //@Dec012023
        //12141214cherie
        //@tso011235813

        public static string uid { get; private set; }
        public static string pwd { get; private set; }
        public static string server { get; private set; }
        public static string database { get; private set; }

        static Database_Credential()
        {
            Load();
        }

        private static void Load()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDirectory, @"..\..\Utilities", "appsettings.json");
            filePath = Path.GetFullPath(filePath); // Convert to absolute path

            //string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            //string appDirectory = Path.GetDirectoryName(assemblyLocation);

            //// Traverse up until finding the solution file or project file
            //while (!Directory.GetFiles(appDirectory, "*.sln").Any() && !Directory.GetFiles(appDirectory, "*.csproj").Any())
            //{
            //    appDirectory = Directory.GetParent(appDirectory).FullName;
            //}

            //string utilitiesFolder = Path.Combine(appDirectory, "Utilities");
            //if (!Directory.Exists(utilitiesFolder))
            //{
            //    throw new DirectoryNotFoundException("Credentials folder not found.");
            //}

            //string filePath = Path.Combine(utilitiesFolder, "appsettings.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"appsettings.json file not found in {filePath}.");
            }

            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                dynamic settings = JsonConvert.DeserializeObject<dynamic>(file.ReadToEnd());

                uid = settings.DatabaseSettings.uid;
                pwd = settings.DatabaseSettings.pwd;
                server = settings.DatabaseSettings.server;
                database = settings.DatabaseSettings.database;
            }
        }

        //static Database_Credential()
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    uid = configuration["DatabaseSettings:Username"];
        //    pwd = configuration["DatabaseSettings:Password"];
        //    server = configuration["DatabaseSettings:Server"];
        //    database = configuration["DatabaseSettings:Database"];
        //}
    }
}
