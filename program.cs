using System.Text;

Console.WriteLine("Nyilvántartási Rendszer");
Console.WriteLine();

Console.Write("Érkezőt rögzítessz (1) vagy Keresel (2) vagy ki akarsz lépni (3)?" );
int valasztas = int.Parse(Console.ReadLine());

while (true)
{
    if (valasztas == 3)
    {
        break;
    }
    while (valasztas != 1 && valasztas != 2)
    {
        Console.WriteLine("Helytelen szám, csak 1-est (Rögzítés) vagy 2-es (keresés) választható");
        Console.Write("Érkezőt rögzítessz (1) vagy Keresel (2)? ");
        valasztas = int.Parse(Console.ReadLine());
    }


    if (valasztas == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Nyilvántartás");
        Console.Write("Érkezés ideje: ");
        string most = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine(most);
        Console.Write("Ember (1) vagy Autó (2) érkezett? Visszalépés (3) ");
        int tipus = int.Parse(Console.ReadLine());

      


        Console.WriteLine();
        while (tipus != 1 && tipus != 2)
        {
            Console.WriteLine("Helytelen szám, csak 1-est (Személy) vagy 2-es (autó) van nyilvántartásban.");
            Console.Write("Ember (1) vagy Autó (2) érkezett? ");
            tipus = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        if (tipus == 1)
        {
            Console.Write("Adja meg a személy nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Adja meg a személyi azonosító számát: ");
            string azon = Console.ReadLine();
            string path = "nyilvantartas.csv";
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                sw.WriteLine($"{most};{nev};{azon}");
            }

        }

        else if (tipus == 2)
        {
            Console.Write("Adja meg az autó típusát: ");
            string autotipus = Console.ReadLine();
            Console.Write("Adja meg az autó rendszámát: ");
            string rendszam = Console.ReadLine();

            string path = "nyilvantartas.csv";
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                sw.WriteLine($"{most};{autotipus};{rendszam}");
            }


        }

    }

    if (valasztas == 2)
    {

    }
    ;
}
