using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Shadow_Lands{
    //Classe Quest: Implemente uma classe que
    //contenha no mínimo duas funções que representem
    //missões ou desafios que o jogador deve superar.
    //Essas funções devem influenciar o curso do jogo.


    internal class Quest{

        public int numeroSorteado;
        public Personagem personagem;
        public Inimigo inimigo;

        public Quest(Personagem Player, Inimigo Enemy){

            personagem = Player;
            inimigo = Enemy;
            inimigo.name = "Fury";
            ConsoleKeyInfo keyInfo;
            do {
                Console.WriteLine("\nPress enter key to roll the dice that decides your fate! Muahahahahaha!");
                keyInfo = Console.ReadKey(true); // Lê a tecla pressionada sem exibir no console

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Random rnd = new Random();
                    int numeroSorteado = rnd.Next(1, 7);
                    Console.WriteLine("\nYour lucky number (or not) is " + numeroSorteado + "!");
                    // Aqui é onde a tecla Enter foi pressionada!
                }
                else
                {
                    Console.WriteLine("\nWrong key! Pitiful human...");
                }

            } while (keyInfo.Key != ConsoleKey.Enter);
            Escolha(numeroSorteado);
        }

        public void Escolha(int numero){
            Console.WriteLine("\nYour quest is...");
            switch (1){
                case 1:
                    Console.WriteLine("\nErase humankind from this world!");
                    case1();
                    break;
                case 2:
                    Console.WriteLine("\nErradicate all demons of this land!");
                    case2();
                    break;
                case 3:
                    Console.WriteLine("\nChoose to save yourself or your brother...");
                    case3();
                    break;
                case 4:
                    Console.WriteLine("\nAbandon your duty and claim all power you can have!");
                    case4();
                    break;
                case 5:
                    Console.WriteLine("\nCollect all human souls and bring them to me!");
                    case5();
                    break;
                default:
                    Console.WriteLine("Collect all human souls and bring them to me!");
                    case6();
                    break;

            }
        }
        public void case1() {
            Console.WriteLine("\nSo your quest is to destroy mankind, are you feeling good about this?");
            Console.WriteLine("\nYes or No?");
            string resposta = Console.ReadLine();
            do {
                if (resposta == "Yes") {
                    Console.WriteLine("\nI knew you had hate in your heart!");
                }
                if (resposta == "No") {
                    Console.WriteLine("\nWell, you're gonna do it anyway!");
                }
                if (resposta != "Yes" && resposta !="No") {
                    Console.WriteLine("\nYou must answer me exactly as I've asked, you fool!");
                    Console.WriteLine("\nYes or No?");
                    resposta = Console.ReadLine();

                }
            } while (resposta!= "Yes" && resposta != "No") ;

            Console.WriteLine("\nTo destroy mankind you must annihilate" + inimigo.name +", the one called Protector of the Mankind");
            Console.WriteLine("\nHow do you want to approach her?");
            Console.WriteLine("\nPress 1 for slow but powerfull attack or 2 for more than one attack but less powerfull");
            Console.WriteLine("\nSlow attacks do 10 of damage and Fast attacks do 5");
            resposta = Console.ReadLine();
            do
            {
                Console.WriteLine("Your life:" + personagem.health + "-" + " Fury Health:" + inimigo.health);
                if (resposta == "1")
                {
                    personagem.health -= 20;
                    inimigo.health -= 10;
                 //   Console.WriteLine("\n Your li");
                    inimigo.Taunt();
                }
                if (resposta == "2")
                {
                    personagem.health -= 10;
                    inimigo.health = inimigo.health - (5 * 2);
                    Console.WriteLine("\n");
                }
                if (resposta != "1" && resposta != "2")
                {
                    Console.WriteLine("\nYou must answer me exactly as I've asked, you fool!");
                    Console.WriteLine("\n1 or 2?");
                    resposta = Console.ReadLine();

                }
            } while ((resposta != "1" && resposta != "2") && (personagem.health > 0 || inimigo.health > 0));
        }


          /* int dinheiro = 0;

            Console.WriteLine("Você chegou no mercado e viu o cofre aberto");
            Console.WriteLine("aperte S para olhar ou N para ir embora");
            string resposta = Console.ReadLine();
            if (resposta == "S"){
                Console.WriteLine(personagem.name + " viu muitos dinheiros");
                Console.WriteLine(personagem.name + "tinha " + dinheiro + "reais");
                dinheiro += 10000;
                personagem.health--;
                Console.WriteLine(personagem.name + " pegou um bolo de ntoas e agora você tem " + dinheiro + "reais");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" correeeeeee");

                }
            }
            else
            {
                Console.WriteLine("voce voltou pra casa");
            }*/


        public void case2(){
        }
        public void case3(){
        }
        public void case4(){
        }
        public void case5(){
        }
        public void case6(){
        }

    }
}