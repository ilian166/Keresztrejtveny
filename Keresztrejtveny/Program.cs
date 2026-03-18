namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeresztrejtvenyRacs kr = new KeresztrejtvenyRacs("kr2.txt");
            Console.WriteLine("5. feladat: A keresztrejtvény méretei:");
            Console.WriteLine($"Sorok száma: {kr.SorokDb}");
            Console.WriteLine($"Oszlopok száma: {kr.OszlopokDb}");
            Console.WriteLine("\n6. feladat: A beolvasott keresztrejtvény:");
            kr.Megjelenit();
        }



    }
}
