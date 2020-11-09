using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL
    {
        private static SqlConnection conn;
        private static string conString;

        public DAL()
        {
            conString = $@"Data Source=CELSO-PC; 
                        Initial Catalog=DBSYSTEKNA; 
                        Persist Security Info=True; 
                        User ID=ADMIN_CELSO; 
                        Password=35316Ji@852";

            conn = new SqlConnection(conString);
        }

        /// <summary>
        /// Método close
        /// </summary>
        public void Close() { if (conn.State == ConnectionState.Open) { conn.Close(); } }

        /// <summary>
        /// Método open
        /// </summary>
        public SqlConnection Open() { if (conn.State == ConnectionState.Closed) { conn.Open(); } return conn; }

        /// <summary>
        /// Método open private
        /// </summary>
        private static SqlConnection _Open()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            return conn;
        }

        /// <summary>
        /// Método de Retorno de Lista de Dados
        /// </summary>
        public static DataTable dtaGet(string cmd)
        {
            DataTable dt = new DataTable();
            SqlCommand cmmd = new SqlCommand(cmd, _Open());
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Método de Execução: INSERT, UPDATE, DELETE
        /// </summary>
        public void Set(string cmd)
        {
            SqlCommand cmmd = new SqlCommand(cmd, _Open());
            cmmd.ExecuteNonQuery();
        }
    }
}
