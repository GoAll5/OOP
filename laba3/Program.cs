using System;
using laba3.Land;
using laba3.Air;
using System.Collections.Generic;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport ts1 = new Bactrian("Двугорбый верблюд", 10, 30);
            Transport ts2 = new AllTerainBoots("Ботинки-вездеходы", 6, 60);
            Transport ts3 = new CamelSpeedBoat("Верблюд-быстроход", 40, 10);
            Transport ts4 = new Centaur("Кентавр", 15, 8);
            Transport ts5 = new MyLand("MeLand", 10, 10, 5);
            Transport ts6 = new Broom("Метла", 20);
            Transport ts7 = new FlyCarpet("Ковер-самолет", 10);
            Transport ts8 = new Mortar("Ступа", 8);
            Transport ts9 = new MyAir("MeAir", 100, 50);

            List<Transport> ts = new List<Transport>();
            ts.Add(ts1);
            ts.Add(ts2);
            ts.Add(ts3);
            ts.Add(ts4);
            ts.Add(ts5);
            ts.Add(ts6);
            ts.Add(ts7);
            ts.Add(ts8);
            ts.Add(ts9);

            AllTsRace race = new AllTsRace(1000, ts);
            Transport first = race.Champion();
            string actual = first.Name;

            Console.WriteLine(actual);
        }
    }
}
