using System;
using System.Collections.Generic;
using System.Text;

namespace MyVokabulary.Repository.Models
{
    public class LanguageDoublet
    {
        public int Id { get; set; }
        public string RusianWord { get; set; }
        public string EnglisfWord { get; set; }

        public List<User> Users { get; set; }
    }
}
