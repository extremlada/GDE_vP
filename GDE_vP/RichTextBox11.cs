using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GDE_vP
{
    public class Database
    {
        public MySqlConnection conn;
        public string server { get; set; }
        public string database;
        public string uid;
        public string password;
    }
}