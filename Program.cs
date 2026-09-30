//2.feladat
List<int> lepesszamok = new List<int>();
Console.WriteLine("=== Heti Lépésszám Rögzítése ===");

for(int i=0; i < 5; i++)
{
    Console.Write($"{i+1}. nap lépésszáma: ");
    int megadott = int.Parse(Console.ReadLine());
    lepesszamok.Add(megadott);
}
//3.feladat
double osszeg = 0;
for (int i = 0; i < 5; i++)
{
    osszeg += lepesszamok[i];
    //osszeg=osszeg+lepesszamok[i];
}
//osszeg = lepesszamok.Sum();
double átlag = osszeg/lepesszamok.Count;


