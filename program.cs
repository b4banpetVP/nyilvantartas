Console.WriteLine("Nyilvántartási Rendszer");
Console.WriteLine();
Console.Write("Érkezés ideje: ");
DateTime most = DateTime.Now;
Console.WriteLine(most);
Console.Write("Ember (1) vagy Autó (2) érkezett? ");
int tipus = int.Parse(Console.ReadLine());

if (tipus == 1)
{
    Console.Write("Adja meg a személy nevét: ");
    string nev=Console.ReadLine();
    Console.Write("Adja meg a személyi azonosító számát: ");
    string azon=Console.ReadLine();

}