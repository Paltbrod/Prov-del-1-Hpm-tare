using System;

namespace Hpmätare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tycker programmet som helhet funkar fine även om jag vet att jag skulle kunna göra det mer effektivt men grundideen funkar ändå som den ska.
            int hp = (5);


            Console.WriteLine("Tja tja dehär är en cool hpMätare som jag försökt slänga ihop");
            Console.WriteLine("Du börjar med det här som hp");
            Console.WriteLine("[=====]100%");
            Console.WriteLine("Om du lyckas dö med så mycket Hp så vet jag inte vad jag ska säga men jag tror på dig");

            while (hp! > 0) // så länge hp inte är mindre en 0 så körs loopen
            {
                int dmg = (1);
                hp = hp - dmg;

                Console.ReadLine();

                if (hp == 4)
                {
                    Console.WriteLine("Hp[====]80% det är nog lungt du klarar dig ur dehär");
                }

                else if (hp == 3)
                {
                    Console.WriteLine("Hp[===]60% inte så värst farligt fattar att de börjar bli tufft men sluta vara en sån mes");
                }
                else if (hp == 2)
                {
                    Console.WriteLine(">Hp[==]40% det här börjar ju se lite mörkt ut för din del men det ordnar sig säkert ska du se");
                }
                else if (hp == 1)
                {
                    Console.WriteLine("HP[=]20% och jag som hade hopp för dig jag ger upp lycka till hejdå");
                }

                else if (hp == 0)
                {
                    Console.WriteLine("HP [] shit du dog vilken noob hade ändå inget hopp för dig från första början");
                }

            }


            Console.ReadLine();


        }
    }
}
