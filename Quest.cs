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
        Fury FuryEnemy = new Fury();
        Abraxis AbraxisEnemy = new Abraxis();
        Absalom AbsalomEnemy = new Absalom();
        public Fury fury;
        public Abraxis abraxis;
        public Absalom absalom;
        public int numeroSorteado;
        public Personagem personagem;

        public Quest(Personagem Player) {
            fury = FuryEnemy;
            abraxis = AbraxisEnemy;
            absalom = AbsalomEnemy;
            personagem = Player;
            ConsoleKeyInfo keyInfo;
            do {
                Console.WriteLine("\nPress enter key to roll the dice that decides your fate! Muahahahahaha!");
                keyInfo = Console.ReadKey(true); // Lê a tecla pressionada sem exibir no console

                if (keyInfo.Key == ConsoleKey.Enter){
                    Random rnd = new Random();
                    numeroSorteado = rnd.Next(1, 4);
                    // Aqui é onde a tecla Enter foi pressionada!
                }
                else{
                    Console.WriteLine("\nWrong key! Pitiful human...");
                }

            } while (keyInfo.Key != ConsoleKey.Enter);
            Escolha(numeroSorteado);

        }

        public void Escolha(int numero) {
            Console.Clear();
            Console.WriteLine("\nYour lucky number (or not) is " + numero + "!");
            Console.WriteLine("\nYour quest is...");
            switch (numero) {
                case 1:
                    Console.WriteLine("\nErase humankind from this world!");
                    case1();
                    break;
                case 2:
                    Console.WriteLine("\nErradicate all demons from this world!");
                    case2();
                    break;
                case 3:
                    Console.WriteLine("\nCollect all lost souls of the Well of Souls!");
                    case3();
                    break;
            }
        }

        public void case1(){
            Console.WriteLine("\nTo destroy mankind you must annihilate" + " " + fury.name + ", the one called Protector of Mankind.");
            Console.WriteLine("\nHow do you want to approach her?");
            Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nFURY HEALTH:" + fury.health);
            Console.WriteLine("\n1 for slow but strong attack\n2 for fast but normal attack");
            Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
            string resposta = Console.ReadLine();

            while (true)
            {

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
                if (fury.health <= 0){
                    fury.Victory();
                    break;
                }
                if (personagem.health <= 0 && personagem.guardianAngelHealth == 1){
                    personagem.health += personagem.health + 15;
                    personagem.guardianAngelHealth = 0;
                    if(personagem.health < 0)
                        personagem.health = 0;
                    Console.WriteLine("\nYou guardian angel saved you! He grants his life to resurrect you with more " + 15 + " health points!");
                }

                if (personagem.health <= 0 && personagem.guardianAngelHealth == 0){
                    fury.Defeat();
                    break;
                }
                
                 // Exibir o status atual antes de perguntar novamente
                Console.WriteLine("\nWhat's your next move? 1 or 2?");
                Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nFURY HEALTH:" + fury.health); ;
                resposta = Console.ReadLine();

            }
            
        }


        public void case2(){
            Console.WriteLine("\nTo erradicate all demons from this world, you must face the one who's been ploting a war into this world, his name is: \n" + abraxis.name + "!");
            Console.WriteLine("\nWhat's your move?");
            Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nABRAXIS HEALTH:" + abraxis.health);
            Console.WriteLine("\n1 for slow but strong attack\n2 for fast but normal attack");
            Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
            string resposta = Console.ReadLine();

            while (true)
            {

                if (resposta == "1")
                {
                    personagem.health -= abraxis.dexterity;
                    abraxis.health -= personagem.strength;
                    abraxis.Scream();
                }
                else if (resposta == "2")
                {
                    personagem.health -= abraxis.strength;
                    abraxis.health -= personagem.dexterity;
                    abraxis.Taunt();
                }
                else
                {
                    Console.WriteLine("\nYou must answer me exactly as I've asked, you fool!");
                    Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                    resposta = Console.ReadLine();
                    continue;
                }

                if (abraxis.health <= 0){
                    abraxis.Victory();
                    break;
                }

                if (personagem.health <= 0 && personagem.guardianAngelHealth == 1){
                    personagem.health += personagem.health + 20;
                    personagem.guardianAngelHealth = 0;
                    if (personagem.health < 0)
                        personagem.health = 0;
                    Console.WriteLine("\nYou guardian angel saved you! He grants his life to resurrect you with more " + 20 + " health points!");
                }

                if (personagem.health <= 0 && personagem.guardianAngelHealth == 0){
                    abraxis.Defeat();
                    break;
                }

                Console.WriteLine("\nWhat's your next move? 1 or 2?");
                Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nABRAXIS HEALTH:" + abraxis.health);
                resposta = Console.ReadLine();

            }
        }

        public void case3(){

            Console.WriteLine("\nSo, you've reached the tree of life, the last chance to collect all lost souls and finally give them peace..." +
            "\nAre you ready to face " + absalom.name + " to accomplish this mission?");
            Console.WriteLine("\nWhat's your move?");
            Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nABSALOM HEALTH:" + absalom.health);
            Console.WriteLine("\n1 for slow but strong attack\n2 for fast but normal attack");
            Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
            string resposta = Console.ReadLine();

            while (true)
            {

                if (resposta == "1")
                {
                    personagem.health -= absalom.dexterity;
                    absalom.health -= personagem.strength;
                    absalom.Scream();
                }
                else if (resposta == "2")
                {
                    personagem.health -= absalom.strength;
                    absalom.health -= personagem.dexterity;
                    absalom.Taunt();
                }
                else
                {
                    Console.WriteLine("\nYou must answer me exactly as I've asked, you fool!");
                    Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                    resposta = Console.ReadLine();
                    continue;
                }

                if (absalom.health <= 0){
                    absalom.Victory();
                    break;
                }

                if (personagem.health <= 0 && personagem.guardianAngelHealth == 1){
                    personagem.health += personagem.health + 25;
                    personagem.guardianAngelHealth = 0;
                    if (personagem.health < 0)
                        personagem.health = 0;
                    Console.WriteLine("\nYou guardian angel saved you! He grants his life to resurrect you with more " + 25 + " health points!");
                }

                if (personagem.health <= 0 && personagem.guardianAngelHealth == 0){
                    absalom.Defeat();
                    break;
                }

                Console.WriteLine("\nWhat's your next move? 1 or 2?");
                Console.WriteLine("\nSlow attacks do " + personagem.strength + " of damage and Fast attacks do " + personagem.dexterity);
                Console.WriteLine("\nYOUR LIFE:" + personagem.health + "\nABSALOM HEALTH:" + absalom.health);
                resposta = Console.ReadLine();

            }


        }
    }
}