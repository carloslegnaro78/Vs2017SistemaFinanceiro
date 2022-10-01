using System.Data.SqlClient;

namespace Model.Dao
{
    class ConexaoDB
    {
        private static ConexaoDB objConexaoDb = null;
        private SqlConnection con;

        private ConexaoDB()
        {
            
            con = new SqlConnection("Data Source=PC-CARLOS\\SQLSERVER2019;Initial Catalog=financeiro;User ID=legnaro;Password=1234");
            
        }

        public static ConexaoDB saberEstado()
        {
            if (objConexaoDb == null)
            {
                objConexaoDb = new ConexaoDB();
            }

            return objConexaoDb;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void CloseDB()
        {
            objConexaoDb = null;
        }
    }
}
