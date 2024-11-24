using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Shadow_Lands {
    //Classe Quest: Implemente uma classe que
    //contenha no mínimo duas funções que representem
    //missões ou desafios que o jogador deve superar.
    //Essas funções devem influenciar o curso do jogo.


    internal class Quest {
        Fury Enemy = new Fury();
        public Fury fury;
        public int numeroSorteado;
        public Personagem personagem;

        public Quest(Personagem Player) {
            fury = Enemy;
            personagem = Player;
            ConsoleKeyInfo keyInfo;
            do {
                Console.WriteLine("\nPress enter key to roll the dice that decides your fate! Muahahahahaha!");
                keyInfo = Console.ReadKey(true); // Lê a tecla pressionada sem exibir no console

                if (keyInfo.Key == ConsoleKey.Enter){
                    Random rnd = new Random();
                    int numeroSorteado = rnd.Next(1, 3);
                    Console.WriteLine("\nYour lucky number (or not) is " + numeroSorteado + "!");
                    // Aqui é onde a tecla Enter foi pressionada!
                }
                else{
                    Console.WriteLine("\nWrong key! Pitiful human...");
                }

            } while (keyInfo.Key != ConsoleKey.Enter);
            Escolha(numeroSorteado);
        }

        public void Escolha(int numero) {
            
            Console.WriteLine("\nYour quest is...");
            switch (1) {
                case 1:
                    Console.WriteLine("\nErase humankind from this world!");
                    case1();
                    break;
                case 2:
                    Console.WriteLine("\nErradicate all demons from this world!");
                    case2();
                    break;
                default:
                    Console.WriteLine("\nCollect all lost souls of the Well of Souls!");
                    case3();
                    break;
            }
        }

        public void case1()
        {
            Console.WriteLine("\nTo destroy mankind you must annihilate" + " " + fury.name + ", the one called Protector of the Mankind.");
            Console.WriteLine("\nHow do you want to approach her?");
            Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nFURY HEALTH:" + fury.health);
            Console.WriteLine("\n1 for slow and strong attack\n2 for fast but normal attack");
            Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
            string resposta = Console.ReadLine();

            while (true){

                if (resposta == "1")
                {
                    personagem.health -= fury.dexterity;
                    fury.health -= personagem.strength;
                    fury.Scream();
                }
                else if (resposta == "2")
                {
                    personagem.health -= fury.strength;
                    fury.health -= personagem.dexterity;
                    fury.Taunt();
                }
                else
                {
                    Console.WriteLine("\nYou must answer me exactly as I've asked, you fool!");
                    Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                    resposta = Console.ReadLine();
                    continue;
                }

                // Verificar condições de vitória ou derrota dentro do loop
                if (fury.health <= 0)
                {
                    Console.WriteLine("\nCongratulations, you've defeated Fury!");
                    break; // Encerra o loop quando Fury for derrotada
                }

                if (personagem.health <= 0)
                {
                    Console.WriteLine("\nI knew you were weak but not that much! More luck next time hahahaha");
                    break; // Encerra o loop quando o personagem for derrotado
                }

                // Exibir o status atual antes de perguntar novamente
                Console.WriteLine("\nYOUR LIFE: " + personagem.health + " -" + " FURY HEALTH: " + fury.health);
                Console.WriteLine("\nWhat's your next move? 1 or 2?");
                Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                resposta = Console.ReadLine();

            }
            
        }


        public void case2(){
        }
        public void case3(){
        }
    }
}