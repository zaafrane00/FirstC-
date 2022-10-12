using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Patron : Employee
    {
        public static  double chiffAffaire;
        private float pourcentage;

        public Patron(int id, string name, string lastname, int age, DateTime dn, float p)
        : base(id, name, lastname, age)
        {
            this.pourcentage = p;
        }


        public override string ToString()
        {
            return "Patron: " + " " + base.ToString() + " Pourcentage: " + pourcentage + "%";
        }
       

        public override double GetSalaire()
        {
            return Math.Round((chiffAffaire * pourcentage / 100) / 12, 2);
            
        }
    }
}
