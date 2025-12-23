using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyVocabulary.Web.Pages
{
    public class ExerciseModel : PageModel
    {
        public string giwenWord;
        public string[] answerOption;
        public string translationGiwenWord;

        //public ExerciseModel(string GiwenWord, string[] AnswerOption, string TranslationGiwenWord)
        //{
        //    giwenWord = ExerciseModel.OnGet().exerciseModel.giwenWord;
        //    answerOption = ExerciseModel.OnGet().exerciseModel.answerOption;
        //    translationGiwenWord = ExerciseModel.OnGet().translationGiwenWord;
        //}


        public void OnGet()
        {
            var exerciseObject = DataBase.GetExercise();
            var a = exerciseObject.AnswerOptions[0];
            exerciseObject = Exercise.RandomSort(exerciseObject);
            giwenWord = exerciseObject.GivenWord;
            answerOption = exerciseObject.AnswerOptions;
            translationGiwenWord = a;
        }
    }
}
