using System;

namespace trenya
{
    class Program
    {
        static void Main()
        {
            double brosok;
            double reshka = 0;
            double eagle = 0;
            int eagleorreshka;
            double shans;
            int choice;
            int n;

            Console.WriteLine("Введите будем ли мы бросать несколько раз монету или бросков будет неограниченное кол-во раз.");
            Console.WriteLine("1- это бесконечное кол-во бросков,2-это конечное кол-во бросков.");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1)

                while (true)
                {

                    Random rnd = new Random();
                    int randomize = rnd.Next(0, 100);
                    eagleorreshka = Convert.ToInt32(randomize);
                    if (eagleorreshka % 2 == 0)
                    {
                        //eagle
                        eagle++;
                    }
                    else
                    {
                        //reshka
                        reshka++;
                    }
                    brosok = eagle + reshka;
                    shans = (eagle / brosok) * 100;
                    Console.WriteLine("Шанс выпадения орла=" + shans + "%" + "   " + "Кол-во бросков=" + brosok + "   " + "eagle=" + eagle + "    " + "reshka=" + reshka);
                }
            //====================================================================================================================================================================================================
            //НАДО БУДЕТ СДЕЛАТЬ КОД КОРОЧЕ(А ПОКА Я НЕ ЗНАЮ КАК)
            //====================================================================================================================================================================================================

            else if (choice == 2)
                Console.WriteLine("Введите сколько бросков монеты мы сделаем.");
                 int.TryParse(Console.ReadLine(), out n);
                 while (n > 0)
                 {
                     n--;

                    Random rnd = new Random();
                    int randomize = rnd.Next(0, 100);
                    eagleorreshka = Convert.ToInt32(randomize);
                    if (eagleorreshka % 2 == 0)
                    {
                        //eagle
                        eagle++;
                    }
                    else
                    {
                        //reshka
                        reshka++;
                    }
                    brosok = eagle + reshka;
                    shans = (eagle / brosok) * 100;
                    Console.WriteLine("Шанс выпадения орла=" + shans + "%" + "   " + "Кол-во бросков=" + brosok + "   " + "eagle=" + eagle + "    " + "reshka=" + reshka);
               
            } 
        }
        
    }
}
