using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lauch2
{
    internal class ProcessItem
    {
        public string Filename { get; set; }
        public string workDir { get; set; }
        public string Arguments { get; set; }
        public int ID { get; set; }

        public int ProcessID { get; set; }



        public static ProcessItem Factory(string filename, string dir, string arguments)
        {
            ProcessItem pr = new ProcessItem();

            pr.Filename = filename;
            pr.workDir = dir;
            pr.Arguments = arguments;

            return pr;
        }

        public static bool save(ProcessItem pr)
        {
            var conn = Connection();
            try {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO process (filename, workdir, arguments, process_id) 
                                            VALUES (@filename, @workdir, @arguments, @process_id)";

                    cmd.Parameters.AddWithValue("@filename", pr.Filename);
                    cmd.Parameters.AddWithValue("@workdir", pr.workDir);
                    cmd.Parameters.AddWithValue("@arguments", pr.Arguments);
                    cmd.Parameters.AddWithValue("@process_id", 0);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            } finally
            {
                conn.Close();
            }
        }

        public static bool DeleteById(int id)
        {
            var conn = Connection();
            try
            {
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM process where id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
               return false;
            }

        }

        public static bool UpdateId(string id, int process_id)
        {
            var conn = Connection();
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE process SET process_id = @process_id WHERE id = @id";

                    cmd.Parameters.AddWithValue("@process_id", process_id);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<ProcessItem> getAll()
        {
            var conn = Connection();

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM process";

                var reader = cmd.ExecuteReader();

                List<ProcessItem> items = new List<ProcessItem>();
                               

                while (reader.Read()) { 
                    ProcessItem item = new ProcessItem();
                    item.ID = reader.GetInt32(0);
                    item.Filename = reader.GetString(1);
                    item.workDir = reader.GetString(2);
                    item.Arguments = reader.GetString(3);
                    item.ProcessID = reader.GetInt32(4);

                    items.Add(item);
                }
                return items;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return [];
            } finally
            {
                conn.Close();
            }

            return [];
        }

        public static SQLiteConnection Connection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string outDir = Path.Join(path, ".lauch");

            bool dirExists = Directory.Exists(outDir);

            if (!dirExists)
            {
                Directory.CreateDirectory(outDir);
            }

            //System.Data.SQ

            string outFile = Path.Combine(outDir, "data.sqlite");

            try {
                if (!File.Exists(outFile)) { 
                    SQLiteConnection.CreateFile(outFile);
                }
                SQLiteConnection conn = new SQLiteConnection($"Data Source={outFile}; Version=3");
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS process (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    filename text,
                    workdir text,
                    arguments text,
                    process_id int
                )";

                cmd.ExecuteNonQuery();

                return conn;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
