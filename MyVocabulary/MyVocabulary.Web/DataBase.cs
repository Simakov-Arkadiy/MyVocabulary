using Microsoft.Data.SqlClient;
namespace MyVocabulary.Web
{
    public class DataBase
    {
        //private string connectionString = "Data Source=localhost;Initial Catalog=vocabulary;Integrated Security=True;Encrypt=False";
        //private string englishWord;
       // private string russianWord;
        //public DataBase(string englisWord, string rusianWord) 
        //{ 
         //   this.englishWord = englisWord;
         //   this.russianWord = rusianWord;
       // }
        public static void PostToBase(string englishWord, string russianWord)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=vocabulary;Integrated Security=True;Encrypt=False";
        //DataBase dataBaseObject = new DataBase(englishWord, russianWord);
        SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = $"INSERT INTO Words(englishWord, russianWord) VALUES('{englishWord}','{russianWord}')";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        }
    }
}
