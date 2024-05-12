using COA_IMS.Screens.Subscrn;
using COA_IMS.UserControlUtil;
using COA_IMS.Utilities;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS
{
    internal class Database_Query
    {
        public static readonly string get_acc = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static readonly string check_acc_status = "SELECT status FROM user_info_table WHERE user_name = '{0}'";

        public static readonly string deact_acc = "UPDATE user_info_table SET status = 0 WHERE user_name = '{0}'";
        public static readonly string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";

        public static string last_query;

        #region Activity Logging
        public static readonly string display_logs = "SELECT user_name, activity, activity_datetime FROM log_table";
        public static readonly string count_account_logs = "SELECT COUNT(*) FROM log_table WHERE activity_type = 1";
        public static readonly string count_account_logs_by_date = "SELECT COUNT(*) FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 1";
        public static readonly string count_activity_logs = "SELECT COUNT(*) FROM log_table WHERE activity_type = 2";
        public static readonly string count_activity_logs_by_date = "SELECT COUNT(*) FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 2";
        //deprecated
        public static readonly string count_logs = "SELECT COUNT(*) FROM log_table";
        #region Accounts Logs
        public static readonly string logged_in = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 1)";
        public static readonly string logged_out = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 1)";
        public static readonly string display_account_logs_by_date = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 1 LIMIT {2}, 15";
        public static readonly string display_specified_account_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND {4} LIKE '%{3}%' AND activity_type = 1 LIMIT {2}, 15";
        public static readonly string display_account_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 1";
        #endregion
        #region Activity Logs
        public static readonly string log_maintenance_activity_add = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Add Record: {1}-{2}', CURRENT_TIMESTAMP, 2)";
        public static readonly string log_maintenance_activity_delete = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Deleted Record: {1}-{2}', CURRENT_TIMESTAMP, 2)";
        public static readonly string log_maintenance_activity_edit = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Edited Record: {1}-{2}{3}', CURRENT_TIMESTAMP, 2)";
        public static readonly string log_maintenance_activity_archive = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Archived Record: {1}-{2}{3}', CURRENT_TIMESTAMP, 2)";
        public static readonly string display_activity_logs_by_date = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND activity_type = 2 LIMIT {2}, 15";
        public static readonly string display_specified_activity_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND {4} LIKE '%{3}%' AND activity_type = 2 LIMIT {2}, 15";
        public static readonly string display_activity_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 2";
        public static readonly string return_module_name = "SELECT module FROM code_table WHERE `table` like '{0}'";
        #endregion
        #region Deprecated Logs Query
        public static readonly string display_three_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_type = 1 LIMIT {0}, 15";
        public static readonly string display_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%'";
        public static readonly string display_ten_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 15";

        #endregion
        //public static readonly string login_attempt = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', 'Attempted to login', CURRENT_TIMESTAMP)";

        #endregion

        public static readonly string get_top_employee_rec = "SELECT employee_no FROM emp_info_table ORDER BY employee_no DESC LIMIT 1";

        public static readonly string get_recent_code = "SELECT code FROM {0} ORDER BY code DESC LIMIT 1";

        public static readonly string get_code_info = "SELECT code, num_length, initial_num FROM code_table WHERE code_table.table = '{0}'";

        public static readonly string delete_record_by_id = "UPDATE {0} SET status = 0 WHERE code = '{1}';";

        #region Project Requests

        public static readonly string get_all_project_records = "SELECT * FROM docu_info_table";

        public static readonly string get_general_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}'";

        //public static readonly string get_specific_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND {3} LIKE '%{4}%'";

        public static readonly string get_specific_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND '{3}' IN \r" +
                                                                                "(document_id, document_code, document_no, amount, title, subject)";

        public static readonly string get_specific_project_records_by_date2 = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND (document_id LIKE '%{3}%' OR \r" +
                                                                                "document_code LIKE '%{3}%' OR \r" +
                                                                                "document_no LIKE '%{3}%' OR \r" +
                                                                                "amount LIKE '%{3}%' OR \r" +
                                                                                "title LIKE '%{3}%' OR \r" +
                                                                                "subject LIKE '%{3}%')";

        #endregion

        public static readonly string get_office_options_by_id = "SELECT office_table.code, office_table.title FROM office_table \r" +
                                                                    "WHERE office_table.sector_code = '{0}' AND office_table.status = 1;";

        public static readonly string get_division_options_by_id = "SELECT division_table.code, division_table.title FROM division_table \r" +
                                                                    "WHERE division_table.office_code = '{0}' AND division_table.status = 1;";

        public static readonly string get_section_options_by_id = "SELECT section_table.code, section_table.title FROM section_table \r" +
                                                                    "WHERE section_table.division_code = '{0}' AND section_table.status = 1;";

        public static readonly string get_position_options = "SELECT position_table.code, position_table.title FROM position_table \r" +
                                                             "WHERE position_table.status = 1;";

        public static readonly string get_section_option = "SELECT section_table.code, section_table.title FROM section_table \r" +
                                                            "WHERE section_table.status = 1;";

        public static readonly string get_employee_record_by_id = "SELECT emp_info_table.full_name, emp_info_table.email, emp_info_table.contact_no, sector_table.code, office_table.code, division_table.code, section_table.code, position_table.code\r" +
                                                                    "FROM emp_info_table \r" +
                                                                    "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                                    "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                                    "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                    "LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                    "WHERE emp_info_table.code = '{0}' AND emp_info_table.status = 1;";


        public static readonly string update_employee_record_by_id = "UPDATE emp_info_table SET \r\nemp_info_table.full_name = '{0}',\r\nemp_info_table.email = '{1}',\r\nemp_info_table.contact_no = '{2}',\r\nemp_info_table.section_code = '{3}',\r\nemp_info_table.position_code = '{4}',\r\nemp_info_table.updated_by = '{5}',\r\nemp_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE emp_info_table.code = '{6}' AND emp_info_table.status = 1;";



        public static readonly string get_audit_trail_by_id = "SELECT created_by, created_date, updated_by, updated_date FROM {0} WHERE code = '{1}';";

        #region Maintenance GET Table Queries

        public static readonly string get_all_agency_records = "SELECT  agency_table.code, agency_table.title, agency_table.description, cluster_table.title\r" +
                                                                "FROM agency_table LEFT JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r" +
                                                                "WHERE agency_table.status = 1;";
        
        public static readonly string get_all_cluster_records = "SELECT cluster_table.code, cluster_table.title, cluster_table.description, sector_table.title \r" +
                                                                "FROM cluster_table LEFT JOIN sector_table ON cluster_table.sector_code = sector_table.code\r" +
                                                                "WHERE cluster_table.status = 1;";

        public static readonly string get_all_contractor_records = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table \r" +
                                                                    "WHERE contractor_table.status = 1;";

        public static readonly string get_all_division_records = "SELECT division_table.code, division_table.title, division_table.description, office_table.title \r" +
                                                                    "FROM division_table LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "WHERE division_table.status = 1;";

        public static readonly string get_all_nature_records = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table\r" +
                                                                    "WHERE nature_table.status = 1;";


        public static readonly string get_all_office_records = "SELECT office_table.code, office_table.title, office_table.description, sector_table.title \r" +
                                                                "FROM office_table LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                "WHERE office_table.status = 1;";

        public static readonly string get_all_position_records = "SELECT position_table.code, position_table.title, position_table.description FROM position_table\r" +
                                                                "WHERE position_table.status = 1;";

        public static readonly string get_all_section_records = "SELECT section_table.code, section_table.title, section_table.description, division_table.title\r" +
                                                                "FROM section_table LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                "WHERE section_table.status = 1;";

        public static readonly string get_all_sector_records = "SELECT sector_table.code, sector_table.title, sector_table.description FROM sector_table\r" +
                                                                "WHERE sector_table.status= 1;";
       
        public static readonly string get_cluster_options = "SELECT cluster_table.code, cluster_table.title FROM cluster_table";

        public static readonly string get_office_options = "SELECT office_table.code, office_table.title FROM office_table WHERE office_table.status = 1 ;";

        public static readonly string get_sector_options = "SELECT sector_table.code,sector_table.title FROM sector_table WHERE sector_table.status = 1";

        public static readonly string get_division_options = "SELECT division_table.code,division_table.title FROM division_table WHERE division_table.status = 1";


        #endregion

        #region Maintenance SET Record Queries

        public static readonly string set_new_agency = "INSERT INTO agency_table (code, title, description, cluster_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_cluster = "INSERT INTO cluster_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_contractor = "INSERT INTO contractor_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_nature = "INSERT INTO nature_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_position = "INSERT INTO position_table (code, title, description, status, created_by, created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_sector = "INSERT INTO sector_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_section = "INSERT INTO section_table (code, title, description, division_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_office = "INSERT INTO office_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";
        public static readonly string set_new_division = "INSERT INTO division_table (code, title, description, office_code, status, created_by, created_date)\r" +
                                                     "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        #endregion

        #region EMPLOYEE


        public static readonly string get_employee_records = "SELECT emp_info_table.code, emp_info_table.full_name, office_table.title, position_table.title,\r" +
                                                                "CASE \r" +
                                                                "WHEN emp_info_table.status = 1 THEN 'ACTIVE'\r" +
                                                                "WHEN emp_info_table.status = 2 THEN 'INACTIVE'\r" +
                                                                "ELSE 'TERMINATED'\r\nEND\r\nAS status\r" +
                                                            "FROM emp_info_table \r" +
                                                            "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                            "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                            "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                            "LEFT JOIN office_table ON division_table.office_code = office_table.code\r\nWHERE emp_info_table.status = 1";



        public static readonly string set_new_employee = "INSERT INTO emp_info_table(code,full_name,email,contact_no,section_code,position_code,status,created_by,created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', 1,'{6}', CURRENT_TIMESTAMP())";
        #endregion

        #region GET Record Queries
        public static readonly string get_agency_record_by_id = "SELECT agency_table.title, agency_table.description, agency_table.cluster_code FROM agency_table\r" +
                                                                "WHERE agency_table.code = '{0}' and agency_table.status = 1;";

        public static readonly string get_cluster_record_by_id = "SELECT agency_table.title, agency_table.description, agency_table.cluster_code FROM agency_table\r" +
                                                                "WHERE agency_table.code = '{0}' and agency_table.status = 1;";


        #endregion

        #region UPDATE Record Queries
        public static readonly string update_agency_record_by_id = "UPDATE agency_table SET \r" +
                                                                "agency_table.title = '{0}', agency_table.description = '{1}', \r" +
                                                                "agency_table.cluster_code = '{2}', agency_table.updated_by = '{3}',\r" +
                                                                "agency_table.updated_date = CURRENT_TIMESTAMP()\r" +
                                                                "WHERE agency_table.code = '{4}' and agency_table.status = 1";



        #endregion

        #region Inventory Queries
        public static readonly string check_existing_item_desc_id = "SELECT COUNT(*) FROM item_desc_table WHERE item_desc_id = \'{0}\';";
        public static readonly string get_general_item_records = 
            "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}'";
        public static readonly string get_specific_item_records = 
            "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND (document_id LIKE '%{3}%' OR \r" +
                                                                                "document_code LIKE '%{3}%' OR \r" +
                                                                                "document_no LIKE '%{3}%' OR \r" +
                                                                                "amount LIKE '%{3}%' OR \r" +
                                                                                "title LIKE '%{3}%' OR \r" +
                                                                                "subject LIKE '%{3}%')";
        public static readonly string get_general_item_record =
            "SELECT {0} FROM {2}_table LIMIT {1}, 15";
        public static readonly string get_specific_item_record =
            "SELECT {0} FROM {3}_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 15";
        public static readonly string insert_item_record = "INSERT INTO {1}_table ({2})\r" +
                                                            "\nSELECT * FROM (SELECT '{0}' AS {2}) AS tmp\r" +
                                                            "\nWHERE NOT EXISTS (\r" +
                                                            "\n    SELECT {2} FROM {1}_table WHERE {2} = '{0}'\r" +
                                                            "\n) LIMIT 1;";
        #region Fill Comboboxes
        public static readonly string select_item_list = "SELECT {0} FROM {0}_table;";
        #endregion
        #region Employee
        //0 - employee name | 1 - employee position | 2 - employee office | 3 - email | 4 - phone | 5 - address | 6 - added by
        public static readonly string insert_employee_record = "INSERT INTO employee_table " +
            "\n(employee_name, employee_position_id, employee_office_id, email, phone, address, added_by)" +
            "\nSELECT* FROM(SELECT" +
            "\n'{0}'," +
            "\n(SELECT pos.employee_position_id FROM employee_position_table pos WHERE pos.employee_position = '{1}')," +
            "\n(SELECT o.employee_office_id FROM employee_office_table o WHERE o.employee_office = '{2}')," +
            "\n'{3}' AS email," +
            "\n'{4}' AS phone," +
            "\n'{5}' AS address," +
            "\n'{6}'" +
            "\n) AS tmp" +
            "\nWHERE NOT EXISTS(SELECT employee_name, employee_position_id, employee_office_id FROM employee_table" +
            "\nWHERE employee_name = '{0}' AND" +
            "\nemployee_position_id =" +
            "\n(SELECT pos.employee_position_id FROM employee_position_table pos WHERE pos.employee_position = '{1}') AND" +
            "\nemployee_office_id =" +
            "\n(SELECT o.employee_office_id FROM employee_office_table o WHERE o.employee_office = '{2}')" +
            "\n) LIMIT 1;";

        public static readonly string insert_employee_position = "INSERT INTO employee_position_table " +
            "\n(employee_position, added_by)" +
            "\nSELECT* FROM(SELECT '{0}', '{1}') AS tmp" +
            "\nWHERE NOT EXISTS(SELECT employee_position FROM employee_position_table" +
            "\nWHERE employee_position = '{0}') LIMIT 1;";

        public static readonly string insert_employee_office = "INSERT INTO employee_office_table " +
            "\n(employee_office, added_by)" +
            "\nSELECT* FROM(SELECT '{0}', '{1}') AS tmp" +
            "\nWHERE NOT EXISTS(SELECT employee_office FROM employee_office_table" +
            "\nWHERE employee_office = '{0}') LIMIT 1;";

        // 0 - searchbar.text | 1 - status
        public static readonly string count_employee = "SELECT COUNT(*) FROM employee_table emp " +
            "\nINNER JOIN" +
            "\nemployee_position_table pos ON pos.employee_position_id = emp.employee_position_id" +
            "\nINNER JOIN" +
            "\nemployee_office_table o ON o.employee_office_id = emp.employee_office_id" +
            "\nWHERE (" +
            "\nemployee_name LIKE '%{0}%' OR" +
            "\nemployee_position LIKE '%{0}%' OR" +
            "\nemployee_office LIKE '%{0}%') AND emp.status = {1};";
        // 0 - employee id | 1 - changes | 2 - CurrentUser.user_name 
        public static readonly string update_employee_record = "UPDATE employee_table\r" +
            "\nSET{1}, modified_by = '{2}'" +
            "\nWHERE employee_id = {0};";
        #region archive employee
        // 0 - employee id | 1 - status | 2 - remarks | 3 - CurrentUser.user_name
        public static readonly string alter_employee_status = "UPDATE employee_table\r" +
            "\nSET `status` = {1} {2}, modified_by = '{3}'" +
            "\nWHERE employee_id = {0};";
        // 0 - employee id 
        public static readonly string get_employee_remarks = "SELECT remarks FROM employee_table WHERE employee_id = {0};";
        #endregion
        // 0 - employee name | 1 - employee position | 2 - employee office
        public static readonly string get_employee_record =
            "SELECT emp.employee_id, emp.employee_name, pos.employee_position, o.employee_office, emp.email, emp.phone, emp.address " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id " +
            "\nWHERE (employee_name = '{0}' AND pos.employee_position = '{1}' AND o.employee_office = '{2}') LIMIT 1 ;";
        // 0 - minimum | 1 - status
        public static readonly string get_general_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id WHERE emp.status = {1} LIMIT {0}, 15;";
        // 0 - minimum | 1 - searchbar.text | 2 - status 
        public static readonly string get_all_specific_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id " +
            "\nWHERE (employee_name LIKE '%{1}%' OR employee_position LIKE '%{1}%' OR employee_office LIKE '%{1}%') AND emp.status = {2} LIMIT {0}, 15;";
        // 0 - minimum | 1 - searchbar.text | 2 - specific table name | 3 - status
        public static readonly string get_specific_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id " +
            "\nWHERE {2} LIKE '%{1}%' LIMIT {0}, 15; WHERE {2} LIKE '%{1}%' AND emp.status = {3} LIMIT {0}, 15;";
        #endregion
        #region Fund Names
        public static readonly string insert_fund_name = "INSERT INTO fund_table (fund_name, added_by) \r" +
            "\nSELECT * FROM (SELECT '{0}', '{1}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT fund_name FROM fund_table \r" +
            "\nWHERE fund_name = '{0}') LIMIT 1;";
        public static readonly string select_fund = "SELECT fund_name FROM fund_table LIMIT {0}, 15;";
        public static readonly string select_specific_funds = "SELECT fund_name FROM fund_table WHERE fund_name LIKE '%{0}%' LIMIT {1}, 15;";
        public static readonly string specific_select_fund_id = "SELECT fund_id FROM fund_table WHERE fund_name = '{0}';";
        public static readonly string count_funds = "SELECT COUNT(*) FROM fund_table WHERE fund_name LIKE '%{0}%';";
        #endregion
        #region Item Brands
        public static readonly string insert_item_brand = "INSERT INTO item_brand_table (item_brand, added_by) \r" +
            "\nSELECT * FROM (SELECT '{0}', '{1}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT item_brand FROM item_brand_table \r" +
            "\nWHERE item_brand = '{0}') LIMIT 1;";

        public static readonly string select_item_brands = "SELECT item_brand FROM item_brand_table;";
        public static readonly string specific_select_item_brands_id = "SELECT item_brand_id FROM item_brand_table WHERE item_brand = '{0}';";
        public static readonly string count_item_brands = "SELECT COUNT(*) FROM item_brand_table WHERE item_brand LIKE '%{0}%';";
        #endregion
        #region Item Types
        public static readonly string insert_item_type = "INSERT INTO item_type_table (item_type, updated_by) \r" +
            "\nSELECT * FROM (SELECT '{0}', '{1}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT item_type FROM item_type_table \r" +
            "\nWHERE item_type = '{0}') LIMIT 1;";

        public static readonly string select_item_types = "SELECT item_type FROM item_type_table LIMIT {0}, 15";
        public static readonly string specific_select_item_types_id = "SELECT item_type_id FROM item_type_table WHERE item_type = '{0}';";
        public static readonly string select_specific_item_types = "SELECT item_type_id, item_type FROM item_type_table FROM log_table WHERE item_type LIKE '%{0}%' LIMIT {1}, 15";
        public static readonly string count_item_types = "SELECT COUNT(*) FROM item_type_table WHERE item_type LIKE '%{0}%';";
        #endregion
        #region Item Units
        public static readonly string insert_item_unit = "INSERT INTO item_unit_table (unit) \r" +
            "\nSELECT * FROM (SELECT '{0}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT unit FROM item_unit_table \r" +
            "\nWHERE unit = '{0}') LIMIT 1;";
        public static readonly string select_item_units = "SELECT unit FROM item_unit_table;";
        public static readonly string specific_select_item_units_id = "SELECT unit_id FROM item_unit_table WHERE unit = '{0}';";
        public static readonly string count_item_units = "SELECT COUNT(*) FROM item_unit_table WHERE unit LIKE '%{0}%';";
        #endregion
        #region Item Supplier
        public static readonly string select_item_supplier_list = "SELECT supplier_name FROM item_supplier_table;";
        public static readonly string insert_item_supplier = "INSERT INTO item_supplier_table (supplier_name, supplier_address, supplier_contact_num, supplier_contact_person, added_by) \r" +
            "\nSELECT * FROM (SELECT '{0}', '{1}', '{2}', '{3}', '{4}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT supplier_name FROM item_supplier_table \r" +
            "\nWHERE supplier_name = '{0}') LIMIT 1;";
        public static readonly string get_general_item_supplier_record =
            "SELECT supplier_name, supplier_address, supplier_contact_num, supplier_contact_person FROM item_supplier_table LIMIT {0}, 15;";
        public static readonly string get_all_specific_item_supplier_record =
            "SELECT supplier_name, supplier_address, supplier_contact_num, supplier_contact_person FROM item_supplier_table WHERE  (supplier_name LIKE '%{1}%' OR \r" +
                "supplier_address LIKE '%{1}%' OR \r" +
                "supplier_contact_num LIKE '%{1}%' OR \r" +
                "supplier_contact_person LIKE '%{1}%') LIMIT {0}, 15;";
        public static readonly string get_specific_item_supplier_record =
            "SELECT supplier_name, supplier_address AS 'address', supplier_contact_num AS 'contact_num', supplier_contact_person AS 'contact_person' FROM item_supplier_table HAVING {2} LIKE '%{1}%' LIMIT {0}, 15;";
        public static readonly string count_item_suppliers =
            "SELECT COUNT(*) FROM item_supplier_table WHERE  (supplier_name LIKE '%{0}%' OR \r" +
                "supplier_address LIKE '%{0}%' OR \r" +
                "supplier_contact_num LIKE '%{0}%' OR \r" +
                "supplier_contact_person LIKE '%{0}%');";
        #endregion
        #region Items
        public static readonly string insert_new_item_desc = "INSERT INTO item_desc_table\r" +
            "\nSELECT * FROM (\r" +
            "\nSELECT \r" +
            "\n'{0}', \r" +
            "\nitem_type_id,\r" +
            "\nitem_brand_id,\r" +
            "\n'{1}' FROM item_type_table, item_brand_table\r" +
            "\nWHERE item_brand = '{2}' AND item_type = '{3}'\r" +
            "\n) AS tmp \r\nWHERE NOT EXISTS (SELECT item_desc_id FROM item_desc_table\r" +
            "\nWHERE item_desc_id = '{0}') LIMIT 1;";
        public static readonly string insert_new_item = "INSERT INTO items_table (item_code, item_desc_id, unit_id, unit_cost, est_useful_life, quantity, added_by) \r" +
            "SELECT * FROM ( SELECT \r" +
            "'{1}', \r" +
            "'{0}', \r" +
            "unit_id, \r" +
            "{2}, \r" +
            "{3}, \r" +
            "{4}, \r" +
            "'{5}' \r" +
            "FROM item_unit_table  WHERE unit = '{6}' \r" +
            ")AS tmp WHERE NOT EXISTS (SELECT item_code FROM items_table\r" +
            " WHERE item_code = '{1}') LIMIT 1;";
        public static readonly string check_item_desc_id = "SELECT COUNT(*) FROM item_desc_table WHERE item_desc_id = '{0}';";
        #region Get Subqueries
        public static readonly string get_concatenated_item_desc = "(SELECT GROUP_CONCAT(\r" +
            "\n(SELECT item_brand \r" +
            "\nFROM item_brand_table \r" +
            "\nWHERE item_brand_id = \r" +
            "\n(SELECT item_brand_id FROM item_desc_table WHERE item_desc_id = \r" +
            "\n(SELECT item_desc_id FROM items_table p WHERE p.item_code = items_table.item_code))),\r" +
            "\n\" - \",\r" +
            "\n(SELECT item_type FROM item_type_table WHERE item_type_id = \r" +
            "\n(SELECT item_type_id FROM item_desc_table WHERE item_desc_id = \r" +
            "\n(SELECT item_desc_id FROM items_table p WHERE p.item_code = items_table.item_code))),\r" +
            "\n\" - \",\r" +
            "\nproduct_name\r" +
            "\n) AS 'item_desc_id' FROM item_desc_table WHERE item_desc_id =\r" +
            "\n(SELECT item_desc_id FROM items_table p WHERE p.item_code = items_table.item_code)) as 'Item_Description'";
        public static readonly string get_unit_from_items = "(SELECT unit FROM item_unit_table WHERE unit_id = \r" +
            "\n(SELECT unit_id FROM items_table p WHERE p.item_code = items_table.item_code)) as 'unit'";
        #endregion
        
        public static readonly string get_general_items_record = "SELECT item_code, \r" +
            "\n" + Database_Query.get_concatenated_item_desc + "\r" +
            "\nunit_id, unit_cost, est_useful_life, quantity FROM items_table LIMIT {0}, 15;";
        public static readonly string get_all_specific_items_record = "SELECT item_code, \r" +
            "\n" + Database_Query.get_concatenated_item_desc + "\r," +
            Database_Query.get_unit_from_items + "\r" +
            "\n, unit_cost, est_useful_life, quantity FROM items_table HAVING  (item_code LIKE '%{1}%' OR \r" +
            "Item_Description" + " LIKE '%{1}%' OR \r" +
            "unit" + " LIKE '%{1}%') LIMIT {0}, 15;";
        public static readonly string get_specific_items_record = "SELECT item_code, \r" +
            "\n" + Database_Query.get_concatenated_item_desc + "\r," +
            Database_Query.get_unit_from_items + "\r" +
            "\n, unit_cost, est_useful_life, quantity FROM items_table HAVING {2} LIKE '%{1}%' LIMIT {0}, 15;";
        #region deprecated
        //public static readonly string get_general_items_records =
        //    "SELECT item_code, item_desc_id, unit_id, unit_cost, est_useful_life, quantity FROM items_table LIMIT {0}, 15;";
        //public static readonly string get_specific_items_records =
        //    "SELECT item_code, item_desc_id, unit_id, unit_cost, est_useful_life, quantity FROM items_table WHERE  (item_code LIKE '%{1}%' OR \r" +
        //        "item_desc_id LIKE '%{1}%' OR \r" +
        //        "unit_id LIKE '%{1}%') LIMIT {0}, 15;";
        #endregion
        #endregion

        //public static readonly string insert_new_item = "INSERT emp_info_table SET \r\nemp_info_table.full_name = '{0}',\r\nemp_info_table.email = '{1}',\r\nemp_info_table.contact_no = '{2}',\r\nemp_info_table.section_code = '{3}',\r\nemp_info_table.position_code = '{4}',\r\nemp_info_table.updated_by = '{5}',\r\nemp_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE emp_info_table.code = '{6}' AND emp_info_table.status = 1;";
        #endregion

        public static readonly string set_new_supplier = "INSERT INTO item_supplier_table (supplier_name, supplier_address, supplier_contact_num, supplier_contact_person, added_by)\r" +
                                                     "VALUES ('{0}','{1}','{2}','{3}','{4}')";
    }
}
