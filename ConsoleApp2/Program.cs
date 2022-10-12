// See https://aka.ms/new-console-template for more information



using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        // Console.WriteLine(args.Length);

        Ouvrier o = new Ouvrier(1, "Nom1", "Prenom1",20, new DateTime(2000, 4, 5));
        Console.Out.WriteLine(o);
        Console.Out.WriteLine("Salaire de l'employé: " + o.GetSalaire());
  
        Cadre c = new Cadre(2, "Nom2", "Prenom2", 44,new DateTime(1986, 4, 3), 3);
        Console.Out.WriteLine(c);
        Console.Out.WriteLine("Le salaire du cadre est: " + c.GetSalaire());
        Patron.chiffAffaire = 50000;

        Patron p = new Patron(3, "Nom3", "Prenom3",44, new DateTime(1970, 6, 6), 3);
        Console.Out.WriteLine(p);
        Console.Out.WriteLine("Le salaire du patron est: " + p.GetSalaire());
        


    }
}