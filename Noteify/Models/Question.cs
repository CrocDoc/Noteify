using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int IDCorrectAnswer { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
