using System.Text;

Console.WriteLine("Nyilvántartási Rendszer");

while (true)
{
    Console.WriteLine();
    Console.Write("Érkezőt rögzítesz (1), keresel (2) vagy kilépsz (0)? ");
    int valasztas = int.Parse(Console.ReadLine());

    if (valasztas == 0)
    {
        break; 
    }

    while (valasztas != 1 && valasztas != 2 && valasztas != 0)
    {
        Console.WriteLine("Helytelen szám, csak 1 (Rögzítés), 2 (keresés) vagy 0 (kilépés) választható");
        Console.Write("Érkezőt rögzítessz (1), keresel (2) vagy kilépsz (0)? ");
        valasztas = int.Parse(Console.ReadLine());
    }


    if (valasztas == 1)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Nyilvántartás");
            string most = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"Érkezés ideje: {most}");
            Console.WriteLine("0 megadásával visszalép");
            Console.Write("Ember (1) vagy Autó (2) érkezett? ");
            int tipus = int.Parse(Console.ReadLine());

            if (tipus == 0)
            {
                break; 
            }

            while (tipus != 1 && tipus != 2)
            {
                Console.WriteLine("Helytelen szám, csak 1 (Személy) vagy 2 (autó) van nyilvántartásban.");
                Console.Write("Ember (1) vagy Autó (2) érkezett? ");
                tipus = int.Parse(Console.ReadLine());
            }

            string path = "nyilvantartas.csv";
            if (tipus == 1)
            {
                Console.Write("Adja meg a személy nevét: ");
                string nev = Console.ReadLine();
                Console.Write("Adja meg a személyi azonosító számát: ");
                string azon = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                    sw.WriteLine($"{most};{nev};{azon},személy");
            }
            else
            {
                Console.Write("Adja meg az autó típusát: ");
                string autotipus = Console.ReadLine();
                Console.Write("Adja meg az autó rendszámát: ");
                string rendszam = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                    sw.WriteLine($"{most};{autotipus};{rendszam};jármű");
            }
        }
    }
    else if (valasztas == 2)
    {
        if (File.Exists("nyilvantartas.csv"))
        {
            Console.WriteLine("Keresés");
            Console.WriteLine();
            Console.WriteLine("Adjon meg egy információt: ");
            string info = Console.ReadLine();


            foreach (string sor in File.ReadLines("nyilvantartas.csv"))
            {
                if (sor.Contains(info))
                {
                    Console.WriteLine(sor);
                }

            }
        }
        else
        {
            Console.WriteLine("Még üres a nyilvántartás.");
        }
    }
}