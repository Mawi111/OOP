using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_2
{
    internal class Hra
    {
        Lokace hrad = new Lokace("Hrad", "Stojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná.");
        Lokace les1 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
        Lokace les2 = new Lokace("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
        Lokace les3 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
        Lokace rybnik = new Lokace("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.");
        Lokace les4 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
        Lokace dum = new Lokace("Dům", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, která se line z hromady vedle vstupních dveří.");

    }
}
