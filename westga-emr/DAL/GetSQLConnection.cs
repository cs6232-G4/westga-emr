using System.Data.SqlClient;

namespace westga_emr.DAL
{
    /// <summary>
    /// This class manages the connection to the cs6232-g4 database on SQL Server
    /// </summary>
    public class GetSQLConnection
    {
        /// <summary>
        /// Returns the connection to SQL Server's WestGA-EMR database
        /// </summary>
        /// <returns>The SqlConnection to TechSupport DB</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=cs6232-g4;Integrated Security=True");
        }
    }
}
