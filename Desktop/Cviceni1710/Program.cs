namespace Cviceni2210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Udalost u1 = new Udalost(Typ.Systemova, Uroven.Informace, "Popiiiiiiiisek");
            Udalost u2 = new Udalost(Typ.Hardwarova, Uroven.Varovani, "Popiiisek");
            Udalost u3 = new Udalost(Typ.Systemova, Uroven.Chyba, "Popiiiiiiiiseeeeeeeeek");
            Udalost u4 = new Udalost(Typ.Systemova, Uroven.Informace, "Popiisekkkkk");

            Seznam s = new Seznam();

            s.Add(u1);
            s.Add(u2);
            s.Add(u3);
            s.Add(u4);

            Console.WriteLine(s);

            Console.WriteLine();

            Console.WriteLine(s.Filtr(Typ.Systemova, Uroven.Jiny));








        }
    }
}