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
            while (true)
            {
                Random rnd = new Random();
                int randomize = rnd.Next(0, 100);
                eagleorreshka = Convert.ToInt32(randomize);
                if (eagleorreshka % 2==0) 
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
                 shans = (eagle / brosok)*100;
                Console.WriteLine("Шанс выпадения орла="+shans+"%"+"   "+"Кол-во бросков="+brosok+"   "+ "eagle=" + eagle + "    "+ "reshka=" + reshka);
            }            
        }
    }
}
