using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bollBoy
{
    class Program
    {
        static void Main(string[] args)
        {

            double MonsterHP = 152.00;
            double MonsterDEF = 0.10;

            double PlayerHP = 50.00;
            double PlayerDEF = 0.16;
            double PlayerATK = 28.00;

            Console.Clear();

            Console.WriteLine("Olá senhor tudo bem, qual e o seu nome?");
            String Nome = Console.ReadLine();

            Console.WriteLine("Olá" + " " + Nome);

            Console.WriteLine("A não um monstro está atacando");

            Console.WriteLine();
            Console.WriteLine("Iniciando comabate");
            Console.ReadKey();

            Console.Clear();
        Finish:
            while (PlayerHP > 0 && MonsterHP > 0){

                Console.WriteLine("Quer ver os status?");

                ConsoleKeyInfo Tecla;
                Tecla = Console.();
                if (Tecla.Key == ConsoleKey.Add)
                {
                    Console.();
                }
                if (Tecla.Key == ConsoleKey.S)
                {

                    Console.WriteLine("Player Status - " + "Defend: " + PlayerDEF + "  " + "HP: " + PlayerHP);
                    Console.WriteLine("Monster Status - " + "Defend: " + MonsterDEF + "  " + "HP: " + MonsterHP);
                }

                Console.WriteLine();
                Random RandomATK = new Random();
                Random RandomDEF = new Random();
                int RandomAtackerMonster = RandomATK.Next(0, 36);
                int ProbalidadeDeDefesaPLA = RandomDEF.Next(0, 100);
                PlayerHP = PlayerHP - (RandomAtackerMonster - (ProbalidadeDeDefesaPLA * PlayerDEF));
                Console.WriteLine("Monstro atacou: " + RandomAtackerMonster);
                Console.WriteLine();

                Console.WriteLine("usar a tecla A para atacar usar a tecla D para defende e Usar tecla H para curar");

                Tecla = Console.ReadKey();
                
                if (Tecla.Key == ConsoleKey.A)
                {
                    Random RandomATKplayer1 = new Random();
                    Random ProbabilidadeDeDEfMNST = new Random();
                    int ATKPrandom = RandomATKplayer1.Next(0, 28);
                    int DEFMrandom = ProbabilidadeDeDEfMNST.Next(0, 100);
                    MonsterHP = MonsterHP - (ATKPrandom - (DEFMrandom * MonsterDEF));
                    double DanoAtck = MonsterHP - (ATKPrandom - (DEFMrandom * MonsterDEF));
                    Console.WriteLine("Você Atacou: " + DanoAtck + " De Dano do monster e ele defendeu mais de " + 4 + "%");
                    Console.WriteLine();
                    if (MonsterHP < 36)
                    {
                        PlayerHP = PlayerHP + PlayerHP;
                        Console.WriteLine("");
                        Console.WriteLine("O monstro se curou");
                    }
                    if (MonsterDEF < 0.1 && MonsterHP < 36)
                    {
                        PlayerDEF = PlayerDEF + PlayerDEF;
                        Console.WriteLine("");
                        Console.WriteLine("O monstro se curou");
                    }
                }
                if (Tecla.Key == ConsoleKey.D)
                {
                    PlayerDEF = PlayerDEF + PlayerDEF;
                    Console.WriteLine("Você Ganhou: " + 2 + "%" + " " + "de defesa");
                    Console.WriteLine();
                    if (Tecla.Key == ConsoleKey.H)
                    {
                        PlayerHP += 86;
                        Console.WriteLine("Você ganhou: " + 8 + " de vida");
                        Console.WriteLine();
                    }
                }
}
            ConsoleKeyInfo TeclaFinal;
            Console.Clear();
            if (PlayerHP > 0)
            {
                Console.WriteLine("Você Ganhou");
            }
                Console.WriteLine("Game Over");
                Console.WriteLine("Quer termina o jogo jogo escrever S");
            TeclaFinal = Console.ReadKey();
            if (TeclaFinal.Key == ConsoleKey.S)
            {
                goto Finish;
            }
            Console.ReadKey();

        }
    }
}
