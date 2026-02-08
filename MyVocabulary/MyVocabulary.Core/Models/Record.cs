using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core.Models
{
    public class Record
    {
        public int Id { get; }
        public string RussianWord { get; }
        public string EnglishWord { get; }

        private Record(int id, string russianWord, string englishWord)
        {
            Id = id;
            RussianWord = russianWord;
            EnglishWord = englishWord;
        }

        public static (Record record, string error) Create(int id, string russianWord, string englishWord)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(russianWord) || string.IsNullOrEmpty(englishWord))
            {
                error = "Нельзя создать запись с пустым словом";
            }
            var record = new Record(id, russianWord, englishWord);
            return (record, error);
        }
    }
}
