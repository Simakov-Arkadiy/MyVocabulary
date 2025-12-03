using Microsoft.Data.SqlClient;
namespace MyVocabulary.Web
{
    public class DataBase
    {
        public int Id;
        public string EnglishWord;
        public string RussianWord;
        //public DataBase(string englishWord, string russianWord) 
        //{
        //    Id = 1;
        //    EnglishWord = englishWord;
        //    RussianName = russianWord;
        //}
        public DataBase(int id, string englishWord,string russianWord) 
        { 
            Id = id;
            EnglishWord = englishWord;
            RussianWord = russianWord;
        }
        public static void PostToBase(string englishWord, string russianWord)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=vocabulary;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = $"INSERT INTO Words(englishWord, russianWord, priority) VALUES('{englishWord}','{russianWord}','5')";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        }
        public static DataBase GetFromBase(string wordOfSearch)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=vocabulary;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = $"SELECT * FROM Words WHERE englishWord = '{wordOfSearch}' OR russianWord = '{wordOfSearch}'";
            SqlCommand cmd = new SqlCommand(query , sqlConnection);
            var cmdAnswer = cmd.ExecuteReader();
            if (cmdAnswer.HasRows)
            {
                cmdAnswer.Read();
                var dataBaseString = new DataBase( (int)cmdAnswer.GetValue(0), $"{cmdAnswer.GetValue(1)}", $"{cmdAnswer.GetValue(2)}");
                return dataBaseString;
            }
            var dataBaseFalseString = new DataBase(0, "absent", "absent");
            cmdAnswer.Close();
            return dataBaseFalseString;

        }
        public static Exercise GetExercise()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=vocabulary;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = $"SELECT [ID][englishWord],[russianWord] FROM Words WHERE priority > 1 ORDER BY [priority] DESC";
        }
    }
}
