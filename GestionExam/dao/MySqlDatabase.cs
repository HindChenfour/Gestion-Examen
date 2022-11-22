using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace GestionExam.dao {
    class MySqlDatabase {
        private String server = "localhost";
        private String user;
        private String pwd;
        private String source;

        private String connectionString;
        private MySqlConnection db;


        public MySqlDatabase() {

        }

        public MySqlDatabase(String user, String pwd, String source) {
            this.user = user;
            this.pwd = pwd;
            this.source = source;

            connectionString = "SERVER=" + server + ";DATABASE=" + source + ";UID=" + user + ";PASSWORD=" + pwd;

            OpenConnection();
        }

        public MySqlDatabase(String source) : this("root", "", source) {

        }

        public MySqlDatabase(String server, String user, String pwd, String source) {
            this.server = server;
            this.user = user;
            this.pwd = pwd;
            this.source = source;

            connectionString = "SERVER=" + server + ";DATABASE=" + source + ";UID=" + user + ";PASSWORD=" + pwd;
            OpenConnection();
        }

        public void OpenConnection() {
            db = new MySqlConnection(connectionString);
            try {
                db.Open();
                Console.WriteLine("Connection établie ...");
            }

            catch (Exception e) {
                Console.WriteLine("Erreur : " + e.Message);
            }
        }

        public List<Object[]> SelectQuery(String query) {
            MySqlCommand cmd = new MySqlCommand(query, db);
            List<Object[]> data = new List<Object[]>();

            try {
                MySqlDataReader reader = cmd.ExecuteReader();

                int cols = reader.FieldCount;

                int j = 0;
                while (reader.Read()){
                    for (int i = 0; i < cols; i++) {
                        data[i][j] = reader.GetValue(i);
                    }
                    j++;
                }
                reader.Close();
                return data;
            }

            catch (Exception e) {
                Console.WriteLine("Erreur : " + e.Message);
                 return null;
           }
        }

        public int UpdateQuery(String query) {
            MySqlCommand cmd = new MySqlCommand(query, db);

            try {
                return cmd.ExecuteNonQuery();
            }

            catch (Exception e) {
                Console.WriteLine("Erreur : " + e.Message);
                return -1;
            }
        }

        public int insert(String tableName, params Object[] row) {
            String query = "INSERT INTO " + tableName + " VALUES('" + row[0] + "'";

            for (int i = 1; i < row.Length; i++) {
                query += ", '" + row[i] + "'";
            }
            query += ")";

            return UpdateQuery(query);
        }

        public List<Object[]> select(String tableName, String columnName, Object value) {
            String query = "SELECT * FROM " + tableName + " WHERE " + columnName + " = '" + value + "'";
            return SelectQuery(query);
        }

        public List<Object[]> selectAll(String tableName) {
            String query = "SELECT * FROM " + tableName;
            return SelectQuery(query);
        }
     }
}
