using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models{
    public class Adatok{
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Birthplace { get; set; }
        public string? Occupation { get; set; }
        public string? Birthdate { get; set; }
        public test() { }

        public Munkahely(string? sor){
            string[] t = sor.Split(';');
            Name = t[0];
            Age = Convert.ToInt32(t[1]);
            Birthplace = t[2];
            Occupation = t[3];
            Birthdate = t[4];
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}