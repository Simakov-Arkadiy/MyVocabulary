namespace MyVocabulary.Web
{
    public class Exercise
    {
        public string GivenWord;
        public string[] AnswerOptions;
        public Exercise(string givenWord, string[] answerOptions) 
        {
            GivenWord = givenWord;
            AnswerOptions = answerOptions;
        }
    }
}
