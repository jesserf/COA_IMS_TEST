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
        public static readonly string return_item_log = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', 'Returned Item SN: {1}, ICS: {2}', CURRENT_TIMESTAMP, 2)";
        public static readonly string create_activity_log = "INSERT INTO log_table (user_name, activity, activity_datetime, activity_type) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP, 2)";
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
        #region Entity Names
        public static readonly string insert_entity_name = "INSERT INTO entity_table (entity_name, added_by) \r" +
            "\nSELECT * FROM (SELECT '{0}', '{1}') AS tmp \r" +
            "\nWHERE NOT EXISTS (SELECT entity_name FROM entity_table \r" +
            "\nWHERE entity_name = '{0}') LIMIT 1;";
        public static readonly string select_entity = "SELECT entity_name FROM entity_table LIMIT {0}, 15;";
        public static readonly string select_specific_entity = "SELECT entity_name FROM entity_table WHERE entity_name LIKE '%{0}%' LIMIT {1}, 15;";
        public static readonly string specific_select_entity_id = "SELECT entity_id FROM entity_table WHERE entity_name = '{0}';";
        public static readonly string count_entity = "SELECT COUNT(*) FROM entity_table WHERE entity_name LIKE '%{0}%';";
        #endregion
        #region Employee Position
        public static readonly string insert_employee_position = "INSERT INTO employee_position_table " +
            "\n(employee_position, added_by)" +
            "\nSELECT* FROM(SELECT '{0}', '{1}') AS tmp" +
            "\nWHERE NOT EXISTS(SELECT employee_position FROM employee_position_table" +
            "\nWHERE employee_position = '{0}') LIMIT 1;";
        public static readonly string select_employee_position = "SELECT employee_position FROM employee_position_table LIMIT {0}, 15;";
        public static readonly string select_specific_employee_position = "SELECT employee_position FROM employee_position_table WHERE employee_position LIKE '%{0}%' LIMIT {1}, 15;";
        public static readonly string specific_select_employee_position_id = "SELECT employee_position_id FROM employee_position_table WHERE employee_position = '{0}';";
        public static readonly string count_employee_position = "SELECT COUNT(*) FROM employee_position_table WHERE employee_position LIKE '%{0}%';";
        #endregion
        #region Employee Office
        public static readonly string insert_employee_office = "INSERT INTO employee_office_table " +
            "\n(employee_office, added_by)" +
            "\nSELECT* FROM(SELECT '{0}', '{1}') AS tmp" +
            "\nWHERE NOT EXISTS(SELECT employee_office FROM employee_office_table" +
            "\nWHERE employee_office = '{0}') LIMIT 1;";
        public static readonly string select_employee_office = "SELECT employee_office FROM employee_office_table LIMIT {0}, 15;";
        public static readonly string select_specific_employee_office = "SELECT employee_office FROM employee_office_table WHERE employee_office LIKE '%{0}%' LIMIT {1}, 15;";
        public static readonly string specific_select_employee_office_id = "SELECT employee_office_id FROM employee_office_table WHERE employee_office = '{0}';";
        public static readonly string count_employee_office = "SELECT COUNT(*) FROM employee_office_table WHERE employee_office LIKE '%{0}%';";
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
            "\n, unit_cost, est_useful_life, quantity FROM items_table WHERE `status` = {2} HAVING  (item_code LIKE '%{1}%' OR \r" +
            "Item_Description" + " LIKE '%{1}%' OR \r" +
            "unit" + " LIKE '%{1}%') LIMIT {0}, 15;";
        public static readonly string get_specific_items_record = "SELECT item_code, \r" +
            "\n" + Database_Query.get_concatenated_item_desc + "\r," +
            Database_Query.get_unit_from_items + "\r" +
            "\n, unit_cost, est_useful_life, quantity FROM items_table WHERE `status` = {3} HAVING {2} LIKE '%{1}%' LIMIT {0}, 15;";
        public static readonly string get_item_record = "SELECT item_code, \r" +
            "\n" + Database_Query.get_concatenated_item_desc + "\r," +
            Database_Query.get_unit_from_items + "\r" +
            "\n, unit_cost, est_useful_life FROM items_table HAVING {2} LIKE '%{1}%' LIMIT {0}, 15;";
        #region deprecated
        //public static readonly string get_general_items_records =
        //    "SELECT item_code, item_desc_id, unit_id, unit_cost, est_useful_life, quantity FROM items_table LIMIT {0}, 15;";
        //public static readonly string get_specific_items_records =
        //    "SELECT item_code, item_desc_id, unit_id, unit_cost, est_useful_life, quantity FROM items_table WHERE  (item_code LIKE '%{1}%' OR \r" +
        //        "item_desc_id LIKE '%{1}%' OR \r" +
        //        "unit_id LIKE '%{1}%') LIMIT {0}, 15;";
        #endregion
        #endregion

        #region Archive Items
        // 0 - employee id | 1 - status | 2 - remarks | 3 - CurrentUser.user_name
        public static readonly string alter_items_status = "UPDATE items_table\r" +
            "\nSET `status` = {1} {2}, modified_by = '{3}'" +
            "\nWHERE item_code = '{0}';";
        // 0 - employee id | 1 - status | 2 - remarks | 3 - CurrentUser.user_name
        public static readonly string update_item = "UPDATE items_table\r" +
            "\nSET {1}, modified_by = '{2}'" +
            "\nWHERE item_code = '{0}';";
        #endregion
        //public static readonly string insert_new_item = "INSERT emp_info_table SET \r\nemp_info_table.full_name = '{0}',\r\nemp_info_table.email = '{1}',\r\nemp_info_table.contact_no = '{2}',\r\nemp_info_table.section_code = '{3}',\r\nemp_info_table.position_code = '{4}',\r\nemp_info_table.updated_by = '{5}',\r\nemp_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE emp_info_table.code = '{6}' AND emp_info_table.status = 1;";

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
        // 0 - minimum | 1 - status
        public static readonly string get_general_archived_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office, emp.remarks " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id WHERE emp.status = {1} LIMIT {0}, 15;";
        // 0 - minimum | 1 - searchbar.text | 2 - status 
        public static readonly string get_all_specific_archived_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office, emp.remarks " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id " +
            "\nWHERE (employee_name LIKE '%{1}%' OR employee_position LIKE '%{1}%' OR employee_office LIKE '%{1}%') AND emp.status = {2} LIMIT {0}, 15;";
        // 0 - minimum | 1 - searchbar.text | 2 - specific table name | 3 - status
        public static readonly string get_specific_archived_employee_record =
            "\nSELECT emp.employee_name, pos.employee_position, o.employee_office, emp.remarks " +
            "\nFROM employee_table emp " +
            "\nINNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id " +
            "\nINNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id " +
            "\nWHERE {2} LIKE '%{1}%' LIMIT {0}, 15; WHERE {2} LIKE '%{1}%' AND emp.status = {3} LIMIT {0}, 15;";
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
        #region Employee Tracking History
        public static readonly string get_employee_history_item = "SELECT \r\n            i.ics_number_id,\r" +
            "\n            CONCAT(tr.item_code, ' - ', b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS 'item',\r" +
            "\n            tr.serial_number AS 'sn',\r" +
            "\n            tr.quantity,\r" +
            "\n            i.transfer_date,\r" +
            "\n            tr.transfer_return_date\r" +
            "\n            FROM item_ics_table i \r" +
            "\n            INNER JOIN transfer_current_table tr ON i.ics_number_id = tr.ics_number_id\r" +
            "\n            INNER JOIN employee_table emp ON i.receiver = emp.employee_id\r" +
            "\n            INNER JOIN employee_office_table o ON emp.employee_office_id = o.employee_office_id\r" +
            "\n            INNER JOIN employee_position_table p ON emp.employee_position_id = p.employee_position_id\r" +
            "\n            INNER JOIN items_table it ON tr.item_code = it.item_code\r" +
            "\n            INNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r" +
            "\n            INNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r" +
            "\n            INNER JOIN item_type_table t ON d.item_type_id = t.item_type_id\r" +
            "\n            WHERE emp.employee_name LIKE '%{1}%' \r" +
            "\n\t\t\t\tAND p.employee_position LIKE '%{2}%'\r" +
            "\n\t\t\t\tAND o.employee_office LIKE '%{3}%'\r" +
            "\n\t\t\t\tHAVING (ics_number_id LIKE '%{4}%' OR item LIKE '%{4}%' OR sn LIKE '%{4}%' OR transfer_date LIKE '%{4}%' OR transfer_return_date LIKE '%{4}%')\r" +
            "\n            ORDER BY tr.transfer_return_date ASC, i.transfer_date ASC LIMIT {0}, 15;";
        public static readonly string get_employee_history_count = "SELECT COUNT(*) AS total_count FROM \r" +
            "\n(SELECT \r" +
            "\n            i.ics_number_id,\r" +
            "\n            CONCAT(tr.item_code, ' - ', b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS 'item',\r" +
            "\n            tr.serial_number AS 'sn',\r" +
            "\n            tr.quantity,\r" +
            "\n            i.transfer_date,\r" +
            "\n            tr.transfer_return_date\r" +
            "\n            FROM item_ics_table i \r" +
            "\n            INNER JOIN transfer_current_table tr ON i.ics_number_id = tr.ics_number_id\r" +
            "\n            INNER JOIN employee_table emp ON i.receiver = emp.employee_id\r" +
            "\n            INNER JOIN employee_office_table o ON emp.employee_office_id = o.employee_office_id\r" +
            "\n            INNER JOIN employee_position_table p ON emp.employee_position_id = p.employee_position_id\r" +
            "\n            INNER JOIN items_table it ON tr.item_code = it.item_code\r" +
            "\n            INNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r" +
            "\n            INNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r" +
            "\n            INNER JOIN item_type_table t ON d.item_type_id = t.item_type_id\r" +
            "\n            WHERE emp.employee_name LIKE '%{1}%' \r" +
            "\n\t\t\t\tAND p.employee_position LIKE '%{2}%'\r" +
            "\n\t\t\t\tAND o.employee_office LIKE '%{3}%'\r" +
            "\n\t\t\t\tHAVING (ics_number_id LIKE '%{0}%' OR item LIKE '%{0}%' OR sn LIKE '%{0}%' OR transfer_date LIKE '%{0}%' OR transfer_return_date LIKE '%{0}%')\r" +
            "\n            ) AS emp_history_count;";
        #endregion
        #endregion
        #region ICS Tracking
        #region ICS Table
        // 0 - ics number | 1 - serial number |  
        public static readonly string update_ics_record = "UPDATE transfer_current_table\r" +
            "\nSET transfer_return_date = {0}, updated_by = '{1}'\r" +
            "\nWHERE ics_number_id = '{2}' AND serial_number = '{3}';";
        // 0 - ics number | 1 - serial number |  
        public static readonly string get_ics_record = "SELECT emp.employee_name AS receiver, \r" +
            "\npos.employee_position, \r" +
            "\no.employee_office, \r" +
            "\n(SELECT emp.employee_name FROM employee_table emp INNER JOIN item_ics_table i ON emp.employee_id = i.giver WHERE i.ics_number_id LIKE '%{0}%') AS giver,\r" +
            "\n(SELECT CONCAT(it.item_code, ' - ', b.item_brand, ' - ', t.item_type, ' - ', d.product_name) FROM transfer_current_table tr\r" +
            "\nINNER JOIN items_table it ON tr.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r\nINNER JOIN item_type_table t ON d.item_type_id = t.item_type_id\r" +
            "\nWHERE tr.serial_number = '{1}') AS item_desc,\r" +
            "\ntr.serial_number,\r" +
            "\ntr.quantity,\r" +
            "\n(tr.total_price / tr.quantity) AS unit_cost,\r" +
            "\ntr.total_price,\r" +
            "\nfc.fund_cluster, \r" +
            "\ni.transfer_date\r" +
            "\n            FROM item_ics_table i \r" +
            "\n            INNER JOIN employee_table emp ON i.receiver = emp.employee_id\r" +
            "\n            INNER JOIN employee_position_table pos ON pos.employee_position_id = emp.employee_position_id \r" +
            "\n            INNER JOIN employee_office_table o ON o.employee_office_id = emp.employee_office_id \r" +
            "\n            INNER JOIN transfer_current_table tr ON i.ics_number_id = tr.ics_number_id\r" +
            "\n            INNER JOIN ics_fund_cluster_table fc ON i.ics_number_id = fc.ics_number\r" +
            "\n            WHERE i.ics_number_id LIKE '%{0}%' AND tr.serial_number = '{1}' LIMIT 1 ;";

        // 0 - minimum lim | 1 - status | 2 - searchwords | 3 - from date | 4 - to date 
        public static readonly string get_ics_table = "SELECT DISTINCT i.ics_number_id AS ics_number, \r" +
            "\ne.entity_name AS entity_name, \r" +
            "\nemp.employee_name AS employee_name, \r" +
            "\nt.item_type AS brief_item, \r" +
            "\nr.serial_number AS sn, \r" +
            "\ni.transfer_date\r\nFROM item_ics_table i \r" +
            "\nINNER JOIN transfer_current_table r \r" +
            "\nON i.ics_number_id = r.ics_number_id \r" +
            "\nINNER JOIN entity_table e\r" +
            "\nON i.entity_id = e.entity_id\r" +
            "\nINNER JOIN employee_table emp\r" +
            "\nON i.receiver = emp.employee_id\r" +
            "\nINNER JOIN items_table it\r" +
            "\nON r.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d\r" +
            "\nON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_type_table t\r" +
            "\nON d.item_type_id = t.item_type_id\r\nWHERE \r" +
            "\nr.transfer_return_date IS NULL AND i.`status` = {1}\r" +
            "\nAND i.transfer_date BETWEEN '{3}' AND '{4}'\r" +
            "\nHAVING (ics_number LIKE '%{2}%'\r" +
            "\nOR entity_name LIKE '%{2}%'\r" +
            "\nOR brief_item LIKE '%{2}%'\r" +
            "\nOR sn LIKE '%{2}%'\r" +
            "\nOR employee_name LIKE '%{2}%')\r" +
            "\nLIMIT {0}, 15;";
        // 0 - minimum lim | 1 - status | 2 - searchwords | 3 - sort string | 4 - to date 
        public static readonly string get_specific_ics_table = "SELECT DISTINCT i.ics_number_id AS ics_number, \r" +
            "\ne.entity_name AS entity_name, \r" +
            "\nemp.employee_name AS employee_name, \r" +
            "\nt.item_type AS brief_item, \r" +
            "\nr.serial_number AS sn, \r" +
            "\ni.transfer_date\r\nFROM item_ics_table i \r" +
            "\nINNER JOIN transfer_current_table r \r" +
            "\nON i.ics_number_id = r.ics_number_id \r" +
            "\nINNER JOIN entity_table e\r" +
            "\nON i.entity_id = e.entity_id\r" +
            "\nINNER JOIN employee_table emp\r" +
            "\nON i.receiver = emp.employee_id\r" +
            "\nINNER JOIN items_table it\r" +
            "\nON r.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d\r" +
            "\nON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_type_table t\r" +
            "\nON d.item_type_id = t.item_type_id\r\nWHERE \r" +
            "\nr.transfer_return_date IS NULL AND i.`status` = {1}\r" +
            "\nAND i.transfer_date BETWEEN '{4}' AND '{5}'\r" +
            "\nHAVING ({3} LIKE '%{2}%')\r" +
            "\nLIMIT {0}, 15;";
        // 0 - minimum lim | 1 - status | 2 - searchwords | 3 - from date | 4 - to date 
        public static readonly string get_general_ics_table = "SELECT DISTINCT i.ics_number_id AS ics_number, \r" +
            "\ne.entity_name AS entity_name, \r" +
            "\nemp.employee_name AS employee_name, \r" +
            "\nt.item_type AS brief_item, \r" +
            "\nr.serial_number AS sn, \r" +
            "\ni.transfer_date\r\nFROM item_ics_table i \r" +
            "\nINNER JOIN transfer_current_table r \r" +
            "\nON i.ics_number_id = r.ics_number_id \r" +
            "\nINNER JOIN entity_table e\r" +
            "\nON i.entity_id = e.entity_id\r" +
            "\nINNER JOIN employee_table emp\r" +
            "\nON i.receiver = emp.employee_id\r" +
            "\nINNER JOIN items_table it\r" +
            "\nON r.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d\r" +
            "\nON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_type_table t\r" +
            "\nON d.item_type_id = t.item_type_id\r\nWHERE \r" +
            "\nr.transfer_return_date IS NULL AND i.`status` = {1}\r" +
            "\nAND i.transfer_date BETWEEN '{4}' AND '{5}'\r" +
            "\nLIMIT {0}, 15;";
        // 0 - minimum lim | 1 - status | 2 - searchwords | 3 - from date | 4 - to date 
        public static readonly string count_ics_table = "SELECT DISTINCT COUNT(*)\r" +
            "\nFROM item_ics_table i \r" +
            "\nINNER JOIN transfer_current_table r \r" +
            "\nON i.ics_number_id = r.ics_number_id \r" +
            "\nINNER JOIN entity_table e\r" +
            "\nON i.entity_id = e.entity_id\r" +
            "\nINNER JOIN employee_table emp\r" +
            "\nON i.receiver = emp.employee_id\r" +
            "\nINNER JOIN items_table it\r\nON r.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d\r" +
            "\nON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_type_table t\r\nON d.item_type_id = t.item_type_id\r" +
            "\nWHERE \r\nr.transfer_return_date IS NULL AND i.`status` = {1}\r" +
            "\nAND i.transfer_date BETWEEN '{3}' AND '{4}'\r" +
            "\nAND (i.ics_number_id LIKE '%{2}%'\r" +
            "\nOR e.entity_name LIKE '%{2}%'\r" +
            "\nOR t.item_type LIKE '%{2}%'\r" +
            "\nOR r.serial_number LIKE '%{2}%'\r" +
            "\nOR emp.employee_name LIKE '%{2}%')\r" +
            "\nLIMIT {0}, 15";

        public static readonly string get_max_transfer_date = "SELECT max(transfer_date) FROM item_ics_table;";
        public static readonly string get_max_transfer_date_acclogs = "SELECT max(activity_datetime) FROM log_table WHERE activity_type = 1;";
        public static readonly string get_max_transfer_date_actlogs = "SELECT max(activity_datetime) FROM log_table WHERE activity_type = 2;";
        #endregion
        #region Return ICS Table
        // 0 - minimum limit | 1 - status | 2 - search words | 
        public static readonly string get_return_ics_table = "SELECT DISTINCT i.ics_number_id AS ics_number, \r" +
            "\n            e.entity_name AS entity_name, \r" +
            "\n            emp.employee_name AS employee_name, \r" +
            "\n            t.item_type AS brief_item, \r" +
            "\n            r.serial_number AS sn, \r" +
            "\n            i.transfer_date,\r" +
            "\n            r.transfer_return_date\r" +
            "\n\t\t\t\tFROM item_ics_table i \r" +
            "\n            INNER JOIN transfer_current_table r \r" +
            "\n            ON i.ics_number_id = r.ics_number_id\r" +
            "\n            INNER JOIN entity_table e\r" +
            "\n            ON i.entity_id = e.entity_id\r" +
            "\n            INNER JOIN employee_table emp\r" +
            "\n            ON i.receiver = emp.employee_id\r" +
            "\n            INNER JOIN items_table it\r" +
            "\n            ON r.item_code = it.item_code\r" +
            "\n            INNER JOIN item_desc_table d\r" +
            "\n            ON it.item_desc_id = d.item_desc_id\r" +
            "\n            INNER JOIN item_type_table t\r" +
            "\n            ON d.item_type_id = t.item_type_id\r" +
            "\n\t\t\t\tWHERE\r" +
            "\n            r.transfer_return_date IS NOT NULL AND i.`status` = {1}\r" +
            "\n            HAVING (ics_number LIKE '%{2}%'\r" +
            "\n            OR entity_name LIKE '%{2}%'\r" +
            "\n            OR brief_item LIKE '%{2}%'\r" +
            "\n            OR sn LIKE '%{2}%'\r" +
            "\n            OR employee_name LIKE '%{2}%')\r" +
            "\n            LIMIT {0}, 15;";
        #endregion
        #region Serial Number
        // 0 - minimum limit | 1 - status | 2 - searchwords |
        public static readonly string get_all_serial_num_item_table = "SELECT tr.serial_number, it.item_code,\r\nCONCAT(b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS item_description,\r\nemp.employee_name AS currently_held_by,\r\nemp.employee_name AS last_held_by\r\nFROM transfer_current_table tr\r\nINNER JOIN items_table it ON tr.item_code = it.item_code\r\nINNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r\nINNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r\nINNER JOIN item_type_table t ON d.item_type_id = t.item_type_id \r\nINNER JOIN item_ics_table i ON tr.ics_number_id = i.ics_number_id\r\nINNER JOIN employee_table emp ON i.receiver = emp.employee_id\r\nWHERE tr.`status` = 1 \r\nHAVING (serial_number LIKE '%%'\r\nOR item_code LIKE '%%'\r\nOR item_description LIKE '%%'\r\nOR currently_held_by LIKE '%%'\r\nOR last_held_by LIKE '%%')\r\nLIMIT 0, 15;\r\n";
        // 0 - minimum limit | 1 - status | 2 - searchwords |
        public static readonly string get_all_serial_num_item_table2 = "SELECT tr.serial_number," +
            "\n            it.item_code," +
            "\n            CONCAT(b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS item_description," +
            "\n            CASE " +
            "\n           WHEN tr.transfer_return_date IS NULL " +
            "\n  THEN emp.employee_name" +
            "\n           ELSE 'none'" +
            "\n       END AS currently_held_by," +
            "\n       CASE " +
            "\n           WHEN tr.transfer_return_date IS NOT NULL " +
            "\n  THEN emp.employee_name" +
            "\n           ELSE 'active'" +
            "\n       END AS last_held_by" +
            "\n            FROM transfer_current_table tr" +
            "\n            INNER JOIN items_table it ON tr.item_code = it.item_code" +
            "\n            INNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id" +
            "\n            INNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id" +
            "\n            INNER JOIN item_type_table t ON d.item_type_id = t.item_type_id " +
            "\n            INNER JOIN item_ics_table i ON tr.ics_number_id = i.ics_number_id" +
            "\n            INNER JOIN employee_table emp ON i.receiver = emp.employee_id" +
            "\nWHERE tr.`status` = {1}" +
            "\n            AND tr.serial_number != 'none' " +
            "\nHAVING" +
            "\n            (serial_number LIKE '%{2}%'" +
            "\n            OR item_code LIKE '%{2}%'" +
            "\n            OR item_description LIKE '%{2}%'" +
            "\nOR currently_held_by LIKE '%{2}%'" +
            "\n            OR last_held_by LIKE '%{2}%');";
        // 0 - minimum limit | 1 - status | 2 - searchwords | 3 - sortstring
        public static readonly string get_specific_serial_num_item_table = "SELECT tr.serial_number,\r" +
            "\nit.item_code,\r" +
            "\nCONCAT(b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS item_description,\r" +
            "\nCASE \r" +
            "\n WHEN tr.transfer_return_date IS NULL \r" +
            "\nTHEN emp.employee_name\r\nELSE 'none'\r\nEND AS currently_held_by,\r" +
            "\nCASE \r" +
            "\nWHEN tr.transfer_return_date IS NOT NULL \r" +
            "\nTHEN emp.employee_name\r\nELSE 'active'\r" +
            "\nEND AS last_held_by\r" +
            "\nFROM transfer_current_table tr\r" +
            "\nINNER JOIN items_table it ON tr.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r" +
            "\nINNER JOIN item_type_table t ON d.item_type_id = t.item_type_id \r" +
            "\nINNER JOIN item_ics_table i ON tr.ics_number_id = i.ics_number_id\r" +
            "\nINNER JOIN employee_table emp ON i.receiver = emp.employee_id\r" +
            "\nWHERE tr.`status` = {1}\r" +
            "\nAND tr.serial_number != 'none' HAVING\r" +
            "\n({3} LIKE '%{2}%')\r" +
            "\nLIMIT {0}, 15;";
        // 0 - minimum limit | 1 - status | 
        public static readonly string get_general_serial_num_item_table = "SELECT tr.serial_number,\r" +
            "\nit.item_code,\r" +
            "\nCONCAT(b.item_brand, ' - ', t.item_type, ' - ', d.product_name) AS item_description\r" +
            "\nFROM transfer_current_table tr\r" +
            "\nINNER JOIN items_table it ON tr.item_code = it.item_code\r" +
            "\nINNER JOIN item_desc_table d ON it.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id\r" +
            "\nINNER JOIN item_type_table t ON d.item_type_id = t.item_type_id WHERE tr.`status` = {1}\r" +
            "\nAND tr.serial_number != 'none' LIMIT {0}, 15;";
        #endregion
        #region Specific Serial Number
        public static readonly string get_specific_sn_item = "SELECT tr.ics_number_id,\r" +
            "\nemp1.employee_name AS receiver,\r" +
            "\nemp2.employee_name AS giver,\r" +
            "\nics.transfer_date,\r" +
            "\ntr.transfer_return_date AS ret_date\r" +
            "\n FROM transfer_current_table tr \r" +
            "\nINNER JOIN item_ics_table ics ON tr.ics_number_id = ics.ics_number_id\r" +
            "\nINNER JOIN employee_table emp1 ON ics.receiver = emp1.employee_id\r" +
            "\nINNER JOIN employee_table emp2 ON ics.giver = emp2.employee_id\r" +
            "\nWHERE tr.serial_number LIKE '%{1}%' \r" +
            "\nHAVING (ics_number_id LIKE '%{2}%' OR \r" +
            "\nreceiver LIKE '%{2}%' OR \r" +
            "\ngiver LIKE '%{2}%' OR \r" +
            "\ntransfer_date LIKE '%{2}%' OR \r" +
            "\nret_date LIKE '%{2}%')\r" +
            "\nORDER BY ics.transfer_date DESC\r" +
            "\nLIMIT {0}, 15;";
        #endregion
        public static readonly string get_blank_tracking_table = "SELECT \r" +
            "\ntr.item_code, \r" +
            "\n(SELECT CONCAT(b.item_brand, \" - \", t.item_type, \" - \", d.product_name) \r" +
            "\n) AS 'Item_Description',\r" +
            "\ntr.serial_number,\r" +
            "\nu.unit,\r" +
            "\ntr.quantity,\r" +
            "\ni.unit_cost,\r" +
            "\n(tr.quantity * i.unit_cost) AS 'Total_Cost',\r" +
            "\ni.est_useful_life FROM transfer_current_table tr\r" +
            "\nINNER JOIN items_table i ON tr.item_code = i.item_code\r" +
            "\nINNER JOIN item_unit_table u ON i.unit_id = u.unit_id\r" +
            "\nINNER JOIN item_desc_table d ON i.item_desc_id = d.item_desc_id\r" +
            "\nINNER JOIN item_brand_table b ON d.item_brand_id = b.item_brand_id \r" +
            "\nINNER JOIN item_type_table t ON d.item_type_id = t.item_type_id\r" +
            "\nHAVING tr.item_code = null;";
        // 0 - item column | 1 - item table | 2 conditional column | 3 - conditional variable
        public static readonly string get_quantity_general = "SELECT {0} FROM {1} WHERE {2} = {3} LIMIT 1;";
        // 0 - conditional variable
        public static readonly string get_quantity_item = "SELECT quantity FROM items_table WHERE item_code = {0} LIMIT 1;";
        // 0 - ics number | 1 - entity id | 2 - receiver | 3 - giver | 4 - CurrentUser.user_name
        public static readonly string insert_ics = "INSERT INTO item_ics_table (ics_number_id, entity_id, receiver, giver, added_by)\r" +
            "\nSELECT * FROM \r" +
            "\n(SELECT \r" +
            "\n'{0}', \r" +
            "\n\t'{1}', \r" +
            "\n\t'{2}', \r" +
            "\n\t'{3}', \r" +
            "\n\t'{4}')\r" +
            "\nAS tmp WHERE NOT EXISTS (SELECT \r" +
            "\n\tics_number_id \r" +
            "\nFROM \r" +
            "\n\titem_ics_table\r" +
            "\nWHERE \r" +
            "\n\tics_number_id =  '{0}')\r" +
            "\nLIMIT 1;";
        // 0 - ics number | 1 - item_code | 2 - serial number | 3 - quantity  | 4 - total price | 5 - CurrentUser.user_name
        public static readonly string insert_transferred_item = "INSERT INTO transfer_current_table \r" +
            "\n(ics_number_id, item_code, serial_number, quantity, total_price, created_by)\r" +
            "\nSELECT * FROM \r" +
            "\n(SELECT \r" +
            "\n\t'{0}', '{1}', '{2}', '{3}', '{4}', '{5}') AS tmp\r" +
            "\nWHERE NOT EXISTS (\r" +
            "\n    SELECT serial_number FROM transfer_current_table \r" +
            "\n    WHERE serial_number = '{2}'\r" +
            "\n) LIMIT 1;";
        // 0 - quantity | 1 - item_code
        public static readonly string update_item_quantity = "UPDATE items_table SET quantity = quantity - {0} WHERE item_code = '{1}';";
        // 0 - ics number | 1 - fund_cluster
        public static readonly string insert_fund_cluster = "INSERT INTO ics_fund_cluster_table " +
            "(ics_number, fund_cluster) " +
            "SELECT * FROM " +
            "(SELECT '{0}', '{1}') AS tmp " +
            "WHERE NOT EXISTS " +
            "(SELECT ics_number " +
            "FROM ics_fund_cluster_table " +
            "WHERE ics_number = '{0}' ) " +
            "LIMIT 1;";
        // 0 - employee name | 1 - employee position | 2 - employee office
        public static readonly string get_employee_id = "SELECT e.employee_id FROM employee_table e\r" +
            "\nINNER JOIN employee_office_table o ON e.employee_office_id = o.employee_office_id\r" +
            "\nINNER JOIN employee_position_table p ON e.employee_position_id = p.employee_position_id\r" +
            "\nWHERE e.employee_name = '{0}' \r" +
            "\nAND p.employee_position = '{1}' \r" +
            "\nAND o.employee_office = '{2}' \r" +
            "\nLIMIT 1;";
        // 0 - employee name | 1 - employee position | 2 - employee office
        public static readonly string get_employee_id_name = "SELECT e.employee_id FROM employee_table e\r" +
            "\nINNER JOIN employee_office_table o ON e.employee_office_id = o.employee_office_id\r" +
            "\nINNER JOIN employee_position_table p ON e.employee_position_id = p.employee_position_id\r" +
            "\nWHERE e.employee_name = '{0}' \r" +
            "\nAND p.employee_position LIKE '%{1}%' \r" +
            "\nAND o.employee_office LIKE '%{2}%' \r" +
            "\nLIMIT 1;";
        // 0 - entity name
        public static readonly string get_entity_id = "SELECT entity_id " +
            "FROM entity_table " +
            "WHERE entity_name = '{0}' " +
            "LIMIT 1;";
        #endregion
        public static readonly string count_total_result = "SELECT COUNT(*) AS total_results FROM ({0}) AS subquery_alias;";
        public static readonly string set_new_supplier = "INSERT INTO item_supplier_table (supplier_name, supplier_address, supplier_contact_num, supplier_contact_person, added_by)\r" +
                                                     "VALUES ('{0}','{1}','{2}','{3}','{4}')";
    }
}
