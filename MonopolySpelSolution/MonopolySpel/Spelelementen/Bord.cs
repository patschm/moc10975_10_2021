using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Bord
    {
        private Vak[] vakken = new Vak[40];

        public Bord()
        {
            Initialize();
        }

        private void Initialize()
        {
            Stad onsDorp =      new Stad { Naam = "Ons Dorp" };
            Stad arnhem =       new Stad { Naam = "Arnhem" };
            Stad haarlem =      new Stad { Naam = "Haarlem" };
            Stad utrecht =      new Stad { Naam = "Utrecht" };
            Stad groningen =    new Stad { Naam = "Groningen" };
            Stad denHaag =      new Stad { Naam = "Den Haag" };
            Stad rotterdam =    new Stad { Naam = "Rotterdam" };
            Stad amsterdam =    new Stad { Naam = "Amsterdam" };

            Vul<Start           >( 0, "Start"                   );

            Vul<Straat          >( 1, "Dorpstraat"              , onsDorp );
            Vul<Kans            >( 2, "Kans"                    );
            Vul<Straat          >( 3, "Brink"                   , onsDorp );
            Vul<Kans            >( 4, "Kans"                    );
            Vul<Station         >( 5, "Station Zuid"            );
            Vul<Straat          >( 6, "Steenstraat"             , arnhem );
            Vul<Kans            >( 7, "Kans"                    );
            Vul<Straat          >( 8, "Ketelstraat"             , arnhem );
            Vul<Straat          >( 9, "Velderplein"             , arnhem);
            Vul<Cel             >(10, "Gevangenis"              );

            Vul<Straat          >(11, "Barteljorisstraat"       , haarlem);
            Vul<Nutsvoorziening >(12, "Electriciteitsbedrijf"   );
            Vul<Straat          >(13, "Wijweg"                  , haarlem);
            Vul<Straat          >(14, "Houtstraat"              , haarlem);
            Vul<Station         >(15, "Station West"            );
            Vul<Straat          >(16, "Neude"                   , utrecht);
            Vul<Kans            >(17, "Kans"                    );
            Vul<Straat          >(18, "Biltstraat"              , utrecht);
            Vul<Straat          >(19, "Vreeburg"                , utrecht);
            Vul<Parkeren        >(20, "Vrij Parkeren"           );

            Vul<Straat          >(21, "A-Kerkhof"               , groningen);
            Vul<Kans            >(22, "Kans"                    );
            Vul<Straat          >(23, "Groote Markt"            , groningen);
            Vul<Straat          >(24, "Heerstraat"              , groningen);
            Vul<Station         >(25, "Station Noord"           );
            Vul<Straat          >(26, "Spui"                    , denHaag);
            Vul<Straat          >(27, "Plein"                   , denHaag);
            Vul<Nutsvoorziening >(28, "Waterleiding"            );
            Vul<Straat          >(29, "Lange Poten"             , denHaag);
            Vul<Politie         >(30, "Naar de Gevangenis"      );

            Vul<Straat          >(31, "Hofplein"                , rotterdam);
            Vul<Straat          >(32, "Blaak"                   , rotterdam);
            Vul<Kans            >(33, "Kans"                    );
            Vul<Straat          >(34, "Coolsingel"              , rotterdam);
            Vul<Station         >(35, "Station Oost"            );
            Vul<Kans            >(36, "Kans"                    );
            Vul<Straat          >(37, "Leidschestraat"          , amsterdam);
            Vul<Kans            >(38, "Kans"                    );
            Vul<Straat          >(39, "Kalverstraat"            , amsterdam);

            foreach(Vak vak in vakken)
            {
                if (vak is Kans)
                {
                    ((Kans)vak).parkeren = (Parkeren)vakken[20];
                }
                else if(vak is Politie)
                {
                    ((Politie)vak).cel = (Cel)vakken[10];
                }
            }
        }

        public Vak GetStart()
        {
            return vakken[0];
        }
        private void Vul<T>(int index, string naam, Stad stad = null) where T: Vak, new()
        {
            vakken[index] = new T { Index = index, Naam = naam };

            if (stad != null)
            {
                ((Straat)vakken[index]).MijnStad = stad;
                stad.Straten.Add((Straat)vakken[index]);
            }
        }

        public Vak Vraag(Vak vak, int worp)
        {
            return vakken[(vak.Index + worp) % vakken.Length];
        }
    }
}
