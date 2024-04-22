using COA_IMS.Screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COA_IMS.Utilities
{
    internal class Activity_Manager
    {
        private Database_Manager db_Manager;
        //log activity logging in
        public void Log_Activity(string username, string message)
        {
            db_Manager = new Database_Manager();
            int ret = 0;
            using (db_Manager)
            {
                ret = Convert.ToInt32(db_Manager.ExecuteNonQuery(string.Format(Database_Query.logged_in, CurrentUser.user_name, message)));
            }

        }
        //log activity logging out
        public void Log_ActivityOut(string username, string message)
        {
            db_Manager = new Database_Manager();
            int ret = 0;
            using (db_Manager)
            {
                ret = Convert.ToInt32(db_Manager.ExecuteNonQuery(string.Format(Database_Query.logged_in, CurrentUser.user_name, message)));
            }

        }
        //display all accoung logging activities according to searchwords and sort and according to specific time frame
        public DataTable Display_Specified_Logs_Table
            (string from, 
            string to, 
            int minimium, 
            string searchwords, 
            string sort_by)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_specified_account_logs, from, to, minimium, searchwords, sort_by));
                Database_Query.last_query = string.Format(Database_Query.display_specified_account_logs, from, to, minimium, searchwords, sort_by);
                int indexOfSteam = Database_Query.last_query.IndexOf("LIMIT");
                if (indexOfSteam >= 0)
                    Database_Query.last_query = Database_Query.last_query.Remove(indexOfSteam);
            }
            return dt;
        }
        //display every account logging activities according to specific time frame
        public DataTable Display_Specific_Date_Logs_Table(string from, string to, int minimium)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_account_logs_by_date, from, to, minimium));
                Database_Query.last_query = string.Format(Database_Query.display_account_logs_by_date, from, to, minimium);
                int indexOfSteam = Database_Query.last_query.IndexOf("LIMIT");
                if (indexOfSteam >= 0)
                    Database_Query.last_query = Database_Query.last_query.Remove(indexOfSteam);
            }
            return dt;
        }

        #region Activity Logging
        public DataTable Display_Activity_Logs_Table(string from, string to, int minimium)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_activity_logs_by_date, from, to, minimium));
                Database_Query.last_query = string.Format(Database_Query.display_activity_logs_by_date, from, to, minimium);
                int indexOfSteam = Database_Query.last_query.IndexOf("LIMIT");
                if (indexOfSteam >= 0)
                    Database_Query.last_query = Database_Query.last_query.Remove(indexOfSteam);
            }
            return dt;
        }

        public DataTable Display_Specified_Activity_Logs_Table(string from, string to, int minimium, string searchwords, string sort_by)
        {
            db_Manager = new Database_Manager();
            DataTable dt = new DataTable();
            using (db_Manager)
            {
                dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_specified_activity_logs, from, to, minimium, searchwords, sort_by));
                Database_Query.last_query = string.Format(Database_Query.display_specified_activity_logs, from, to, minimium, searchwords, sort_by);
                int indexOfSteam = Database_Query.last_query.IndexOf("LIMIT");
                if (indexOfSteam >= 0)
                    Database_Query.last_query = Database_Query.last_query.Remove(indexOfSteam);
                Console.WriteLine(Database_Query.last_query);
                //Console.WriteLine(Database_Query.last_query);
            }
            return dt;
        }

        public void Add_New_Item_Record()
        {
            db_Manager = new Database_Manager();
            using (db_Manager)
            {

            }
        }
        #endregion
        //count number of account logging activities
        public int Count_Account_Logs(string from, string to)
        {
            db_Manager = new Database_Manager();
            int count;
            using (db_Manager)
            {
                count = Convert.ToInt32(db_Manager.ExecuteScalar(string.Format(Database_Query.count_account_logs_by_date, from, to)));
            }
            return count;
        }
        //count number of account activities
        public int Count_Activity_Logs(string from, string to)
        {
            db_Manager = new Database_Manager();
            int count;
            using (db_Manager)
            {
                count = Convert.ToInt32(db_Manager.ExecuteScalar(string.Format(Database_Query.count_activity_logs_by_date, from, to)));
            }
            return count;
        }
    }
}

#region Delete after review
/*public void AnonymousLoginAttempt(string username)
{
    db_Manager = new Database_Manager();

    using(db_Manager )
    {
        //db_Manager.ExecuteScalar(string.Format(Database_Query.login_attempt));
        Console.WriteLine("a");
        db_Manager.ExecuteNonQuery(Database_Query.login_attempt);
    }
}

public void SuccessfulLogin(string username)
{
    db_Manager = new Database_Manager();

    using (db_Manager)
    {
        db_Manager.ExecuteNonQuery(string.Format(Database_Query.logged_in, username));
    }
}*/


/*public DataTable Display_Logs_Table()
{
    db_Manager = new Database_Manager();
    DataTable dt = new DataTable();
    using (db_Manager)
    {
        dt = db_Manager.ExecuteQuery(Database_Query.display_logs);
    }
    return dt;
}
public DataTable Display_Ten_Specific_Logs_Table(string searchwords, string sortby, int minimium)
{
    db_Manager = new Database_Manager();
    DataTable dt = new DataTable();
    using (db_Manager)
    {
        dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_ten_specific_logs, sortby, searchwords, minimium));
        Database_Query.last_query = string.Format(Database_Query.display_ten_specific_logs, sortby, searchwords, minimium);
    }
    return dt;
}
public DataTable Display_Specific_Logs_Table_By_Date(string from, string to, int minimium)
{
    db_Manager = new Database_Manager();
    DataTable dt = new DataTable();
    using (db_Manager)
    {
        dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_account_logs_by_date, from, to, minimium));
        Database_Query.last_query = string.Format(Database_Query.display_account_logs_by_date, from, to, minimium);
    }
    return dt;
}

//deprecated
public DataTable Display_Specific_Logs_Table(string searchwords, string sortby)
{
    db_Manager = new Database_Manager();
    DataTable dt = new DataTable();
    using (db_Manager)
    {
        dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_specific_logs, sortby, searchwords));
    }
    return dt;
}

//deprecated
public DataTable Display_Three_Logs_Table(int minimium)
{
    db_Manager = new Database_Manager();
    DataTable dt = new DataTable();
    using (db_Manager)
    {
        dt = db_Manager.ExecuteQuery(string.Format(Database_Query.display_three_logs, minimium));
        Database_Query.last_query = Database_Query.display_logs;
    }
    return dt;
}*/
#endregion