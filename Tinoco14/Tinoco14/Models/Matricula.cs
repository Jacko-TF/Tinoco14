using System;
using System.Collections.Generic;
using System.Text;

namespace Tinoco14.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Curso { get; set; }
        public string Gender { get; set; }
    }
}
