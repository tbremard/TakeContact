using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;

namespace Cmd
{
    public class LocalDbService : IDBService
    {
        //http://arcanecode.com/2007/01/25/create-a-sql-server-compact-edition-database-with-c/
        int iEntries = 0;
        protected SqlCeConnection sql;
        const string DatabaseFileName = "Database.sdf";
        public bool Connect()
        {
            if(File.Exists(DatabaseFileName) == false)
            {
                this.RebuildDatabase();
            }
            sql = new SqlCeConnection();
            sql.ConnectionString = this.GetConnectionString(); //"Data Source=" + DatabaseFileName + ";Persist Security Info=True";
            sql.Open();
            return true;
        }

        private string GetConnectionString()
        {
            string connectionString;
            string password = "XoRu";
            connectionString = string.Format("DataSource=\"{0}\"; Password='{1}'", DatabaseFileName, password);
            return connectionString;
        }
        public bool Disconnect()
        {
            try
            {
                if (sql == null)
                    return false;
                sql.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
            return true;
        }
        const string UserTable = "Users";

        public bool AddNewEntry(LineEntry e)
        {
            if (e == null)
                return false;
            if (sql == null)
                return false;

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO " + UserTable + "(FirstName, LastName, Email) values('" + e.FirstName + "', '" + e.LastName + "', '" + e.Email + "')";
            cmd.Connection = this.sql;
            cmd.ExecuteNonQuery();
            iEntries++;
            Console.WriteLine("adding entry:" + e.FirstName);
            return true;
        }

        public void RebuildDatabase()
        {
            this.BuildDatabase();
            this.CreateUsersTable();
        }

        private bool BuildDatabase()
        {
            string connectionString;
            connectionString = this.GetConnectionString();
            if (File.Exists(DatabaseFileName))
            {
                File.Delete(DatabaseFileName);
            }

            SqlCeEngine en = new SqlCeEngine(connectionString);
            en.CreateDatabase();
            return true;
        }

        private void CreateUsersTable()
        {
            SqlCeConnection con = null;
            string connectionString;
            connectionString = this.GetConnectionString();
            con = new SqlCeConnection(connectionString);
            con.Open();
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "CREATE TABLE " + UserTable + " (FirstName NVARCHAR(100), LastName NVARCHAR(100), Email NVARCHAR(100))";
            cmd.ExecuteNonQuery();
        }
        
        public bool ClearDatabase()
        {
            this.RebuildDatabase();
            return true;
        }

        public int GetNumberEntries()
        {
            int ret = 0;
            try
            {
                if (sql == null)
                    return 0;
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*)  From " + UserTable ;
                cmd.Connection = this.sql;
                object o;

                o = cmd.ExecuteScalar();
                ret = (int) o;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
            return ret;

        }

        public List<LineEntry> GetEntries()
        {
            List<LineEntry> ret = new List<LineEntry>();

            try
            {
                if (sql == null)
                    return ret;

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select *  From " + UserTable + " ORDER BY LastName ASC";
                cmd.Connection = this.sql;
                SqlCeDataReader reader = cmd.ExecuteReader();
                // Iterate through the results
                //
                while (reader.Read())
                {
                    LineEntry e = new LineEntry();

                    e.FirstName = reader.GetString(0);
                    e.LastName= reader.GetString(1);
                    e.Email = reader.GetString(2);

                    ret.Add(e);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
            return ret;
        }
    }
}
