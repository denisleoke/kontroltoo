using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali meetod:");
            Console.WriteLine("1. SkipWhile");
            Console.WriteLine("2. ThenByDecending");
            Console.WriteLine("3. IfjaElse");
            Console.WriteLine("4. ForLoop");


            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    SkipAndSkipWhile();
                    break;
                case 2:
                    ThenByDescendingLINQ();
                    break;
                case 3:
                    IfjaElse();
                    break;
                case 4:
                    ForLoop();
                    break;
                default:
                    Console.WriteLine("Vigane valik!");
                    break;
            }
        }




        public static void ThenByDescendingLINQ()
        {
            Console.WriteLine("ThenByDescending");

            var thenByDescending = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age);

            foreach (var people in thenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

       

        public static void SkipAndSkipWhile()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("----------Skip--------------");
            //jätab esimesed kolm rida välja
            var skip = PeopleList.peoples.Take(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("----------SkipWhile--------------");
            //näitab kõiki, kellel on neli või vähem tähemärki 
            var skipWhile = PeopleList.peoples.TakeWhile(s => s.Name.Length > 4);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Name);
            }
        }

         static void IfjaElse()
         {
            Console.WriteLine("Kui url on vale, siis annab" +
             "veateate. Kui on õige, siis ütleb, " +
             "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/Ingvar/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Ingvar/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");

            }
            }

        static void ForLoop()
        {
            {
                int i, j, rows;

                Console.WriteLine("Numbri püramiid");

                Console.WriteLine("Sisesta ridade arv");

                rows = Convert.ToInt32(Console.ReadLine());


                for (i = 0; i <= rows; i++)
                {
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        //Console.Write("{0} ", t++);
                        Console.Write("1"); //kui paned selle, siis saad püramiidi
                    }
                    Console.Write("\n");
                }
            }
        }
    } 
}

                







