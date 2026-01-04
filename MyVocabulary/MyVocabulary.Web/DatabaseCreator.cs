using Microsoft.Data.SqlClient;
namespace MyVocabulary.Web
{
    public class DatabaseCreator
    {
        public static void CreateDataBase()
        {

            try
            {
                DataBase.GetFromBase("asd");
            }
            catch (SqlException ex)
            {
                string connectionString = DataBase.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = "CREATE TABLE Words(ID INT IDENTITY, russianWord NVARCHAR(30), englishWord NVARCHAR(30), priority INT)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}