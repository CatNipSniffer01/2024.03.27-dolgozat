using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1{
    public class Class1{
            public string Name { get; set; }
            public string Type { get; set; }
            public int ExpirationDate { get; set; }
            public string Calories { get; set; }

        public Class1(string name, string type, int expirationDate, string calories)
        {
            Name = name;
            Type = type;
            ExpirationDate = expirationDate;
            Calories = calories;
        }

        public override string? ToString()
        {
            return "én egy: "+Name+" vagyok, a"+Type+"-hoz tartozom. Szavatossági időm: "+ExpirationDate+". Calória számom: "+Calories;
        }
    }
}