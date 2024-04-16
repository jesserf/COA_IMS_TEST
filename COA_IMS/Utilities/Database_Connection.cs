using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace COA_IMS
{
    internal class DBConnection 
    {
        private DBConnection() { }

        public MySqlConnection Connection { get; private set; }

        private static DBConnection _instance = null;

        public static DBConnection Instance() 
        { 
            if(_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect() 
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(Database_Credential.database))
                    return false;
                string connection = string.Format("Server={0}; database={1}; UID={2}; password={3}", 
                    Database_Credential.server, Database_Credential.database, 
                    Database_Credential.uid, Database_Credential.pwd);
                Connection = new MySqlConnection(connection);
                Connection.Open();
            }
            return true;    
        }
    }
}
