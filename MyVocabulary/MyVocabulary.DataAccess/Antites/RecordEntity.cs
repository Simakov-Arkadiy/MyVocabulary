using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.DataAccess.Antites
{
    public class RecordEntity
    {
        public int Id { get; set; }
        public string RussianWord { get; set; }
        public string EnglishWord { get; set; }
    }
}
