
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MyVokabulary.Repository.Models
{
    public class User
    {
       
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
      
        public List<LanguageDoublet>? languageDoublets{ get; set; }
    }
}
