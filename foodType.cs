using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmm
{
    internal class foodType
    {
        string name;
        int carbs, fat;
        int protein;
        static int count=0;

        public foodType(string name, int carbs, int fat, int protein)
        {
           this.name = name;
           this.carbs = carbs;
           this.fat = fat;
           this.protein = protein;
           count++;
        }

        public string Name { get => name; set => name = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }
        public int Protein { get => protein; set => protein = value; }
        public static int Count { get => count; set => count = value; }

        public override string ToString()
        {
            string ispis = "Ime proizvoda: " + this.name + "\n"
                + "Proteini: " + this.protein + "%\n"
                + "Carbs: " + this.carbs + "%\n" 
                + "Fat: " + this.fat + "%\n"
                + "Counter: " + count + "\n";
            return ispis;
        }
    }
}
