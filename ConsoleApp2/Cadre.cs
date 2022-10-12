using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cadre: Employee
    {
        private int indice;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        public Cadre(int id, string name, string lastname, int age, DateTime dn, int indice)
            : base(id, name, lastname, age)
        {
            this.indice = indice;
        }

        public override string ToString()
        {
            return "Cadre: " + " " + base.ToString() + " Indice: " + indice;
        }

        public override double GetSalaire()
        {
            if (indice == 1)
                return 13000;
            else if (indice == 2)
                return 15000;
            else if (indice == 3)
                return 17000;
            else if (indice == 4)
                return 20000;
            else
                return -1;                                 
        }
    }
    
}
