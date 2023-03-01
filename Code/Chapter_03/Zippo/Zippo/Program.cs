namespace Zippo
{
    internal class Program
    {
        static void Main()
        {
            Pizzazz foztrot = new Pizzazz() { Zippo = 2 };
            foztrot.Bamboo(foztrot.Zippo);
            Pizzazz november = new Pizzazz() { Zippo = 3 };
            Abacabadra tango = new Abacabadra() { Vavavoom = 4 };
            while (tango.Lala(november.Zippo))
            {
                november.Zippo *= -1;
                november.Bamboo(tango.Vavavoom);
                foztrot.Bamboo(november.Zippo);
                tango.Vavavoom -= foztrot.Zippo;
            }
            Console.WriteLine($"november.Zippo = {november.Zippo}");
            Console.WriteLine($"foxtrot.Zippo = {foztrot.Zippo}");
            Console.WriteLine($"tango.Vavavoom = {tango.Vavavoom}");
        }
    }

    public class Pizzazz 
    {
        public int Zippo;

        public void Bamboo(int eek)
        {
            Zippo += eek;
        }
    }

    public class Abacabadra
    {
        public int Vavavoom;

        public bool Lala(int floq)
        {
            if (floq < Vavavoom) 
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    }

}