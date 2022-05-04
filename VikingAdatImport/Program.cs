using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VikingLottoAdatBazis;

namespace VikingAdatImport
{
    class Program
    {
        static void Main(string[] args)
        {
            VikingContext db = new VikingContext();
            if (!db.LottoSzamok.Any())
            {
                string[] sorok = null;
                bool sikeresFileNyitas = true;
                //Console.WriteLine(args[0]);
                try
                {
                    sorok = File.ReadAllLines(args[0]);
                }
                catch (Exception)
                {
                    sikeresFileNyitas = false;
                    Console.WriteLine("A megadott fájlnév nem megfelelő! pl.:filaname.csv");
                }
                if (sikeresFileNyitas)
                {
                    List<LottoSzam> szamok = new List<LottoSzam>();
                    foreach (var sor in sorok)
                    {
                        try
                        {
                            szamok.Add(new LottoSzam(sor));
                        }
                        catch (Exception)
                        {    }
                    }
                    db.LottoSzamok.AddRange(szamok);
                    db.SaveChanges();
                    Console.WriteLine("Sorok száma: "+db.LottoSzamok.Count()+" db");
                }
            }
            else
            {
                Console.WriteLine("Az adattábla már létezik!");
            }
        }
    }
}
