using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ouvrier : Employee
    {
        private int cadre;
        private double salaire;
        public static int SMIG = 2500;
        private DateTime dateentree;
        private DateTime dateTime;

      

        public Ouvrier(int id, string name, string lastName, int age, DateTime dateTime) : base(id, name, lastName, age)
        {
            this.dateTime = dateTime;
        }

        public DateTime Dateentree
        {
            get { return dateentree; }
            set { dateentree = value; }
        }

        public override string ToString()
        {
            return "Employé:" + " " + base.ToString() + " Date d'entrée: " + dateentree.ToShortDateString();
        }
       

        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateentree.Year;
            if (dateentree.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (SMIG + Anciennete * 100 <= 2 * SMIG)
                salaire = SMIG + Anciennete * 100;
            else
                salaire = SMIG * 2;

            return salaire;
        }
        
    }
}
