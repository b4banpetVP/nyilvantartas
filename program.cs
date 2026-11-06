using System.Text;

Console.WriteLine("Nyilvántartási Rendszer");
Console.WriteLine();
Console.Write("Érkezés ideje: ");
string most = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine(most);
Console.Write("Ember (1) vagy Autó (2) érkezett? ");
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