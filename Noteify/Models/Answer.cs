using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public byte[] Picture { get; set; }
        public bool IsPicture { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
