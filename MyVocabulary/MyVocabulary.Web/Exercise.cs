using System.Security.Cryptography;

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
        public static Exercise RandomSort(Exercise exercise)
        {
            var rnd = new Random();
            for (int i = 0; i < rnd.Next(5); i++)
            {
                var a = exercise.AnswerOptions[0];
                exercise.AnswerOptions[0] = exercise.AnswerOptions[2];
                exercise.AnswerOptions[2] = a;
                a = exercise.AnswerOptions[1];
                exercise.AnswerOptions[1] = exercise.AnswerOptions[3];
                exercise.AnswerOptions[3] = a;
                a = exercise.AnswerOptions[1];
                exercise.AnswerOptions[1] = exercise.AnswerOptions[2];
                exercise.AnswerOptions[2] = a;
            }
            return exercise;
        }
    }
}
