using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_IMS.Utilities
{
    internal class RandomAlphanumericString
    {
        private readonly Random random = new Random();
        Database_Manager database_Manager = new Database_Manager();
        private int Random_Number(int min, int max)
        {
            return random.Next(min, max);
        }

        private string Random_NumberSet(int max)
        {
            var builder = new StringBuilder(max);
            for (int i = 0; i < max; i++)
            {
                builder.Append(random.Next(9));
            }
            return builder.ToString();
        }
        private string RandomString(int size, bool lowercase = false)
        {
            var builder = new StringBuilder(size);

            char offset = lowercase ? 'a' : 'A';
            const int letterOffset = 26;

            for(int i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + letterOffset);
                builder.Append(@char);
            }

            return lowercase ? builder.ToString().ToLower() : builder.ToString();
        }
        private string Random_Alpha_Num(int size = 2, string startLetter = "I")
        {
            int one_num = 1;
            int two_num = 1;
            var builder = new StringBuilder(size);
            builder.Append(startLetter);
            for (int i = 0; i < size; i++)
            {
                two_num += one_num;
                builder.Append(Random_NumberSet(one_num));
                one_num += two_num;
                builder.Append(RandomString(two_num));
            }
            
            return builder.ToString();
        }
        public string Generate_RandomString(int size = 2)
        {
            string randomString = Random_Alpha_Num(size);
            int check = 0;
            using (database_Manager)
                check = Convert.ToInt32(database_Manager.ExecuteScalar(string.Format(Database_Query.check_existing_item_desc_id, randomString)));
            if(check == 1) randomString = Generate_RandomString();
            return randomString;
        }
        public string Generate_RandomString(string query, int size = 2)
        {
            string randomString = Random_Alpha_Num(size);
            int check = 0;
            using (database_Manager)
                check = Convert.ToInt32(database_Manager.ExecuteScalar(string.Format(query, randomString)));
            if (check == 1) randomString = Generate_RandomString(query);
            return randomString;
        }
    }
}
