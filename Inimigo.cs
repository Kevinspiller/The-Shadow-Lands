using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Shadow_Lands{

    /// <summary>
    /// Classe Inimigo: Desenvolva uma classe para os inimigos
    /// que o personagem enfrentará. Esta classe deve herdar da 
    /// classe Personagem, podendo ter atributos e métodos adicionais
    /// específicos dos inimigos. 
    /// </summary>
    //  dois pontos para herdar personagem
    internal class Inimigo : Personagem {
        //criando um construtor
        public Inimigo() {
            name = "";
            health = 100;
            strength = 20;
            dexterity = 25;

        }
    }

        internal class Fury : Personagem
        {

            public Fury()
            {
                name = "Fury";
                health = 100;
                strength = 30;
                dexterity = 15;
            }

            public void Taunt(){
                Fury Enemy = new Fury();
                Console.WriteLine("\n"+Enemy.name+": " + "Hahahaha, that's the best you can do?");
            }
            public void Scream(){
                Fury Enemy = new Fury();
                Console.WriteLine("\n"+Enemy.name+": " + "Ahhhh, you bastard!");
            }
            public void Defeat(){
                Fury Enemy = new Fury();
                Console.WriteLine("\nYOU LOST! - " + Enemy.name+": I knew you were weak but not that much! More luck next time hahahaha");
                Console.ReadKey();
            }
            public void Victory(){
                Fury Enemy = new Fury();
                Console.WriteLine("\nYOU WON! - " +Enemy.name +": You've destroyed the balance of the Universe, mere fool! I hope you are happy...");
                Console.ReadKey();
            }
        }

        internal class Abraxis : Personagem{

            public Abraxis(){
                name = "Abraxis";
                health = 110;
                strength = 20;
                dexterity = 15;
            }

            public void Taunt(){
                Abraxis Enemy = new Abraxis();
                Console.WriteLine("\n" + Enemy.name + ":" + " You really are a fool for thinking you can defeat me!");
            }
            public void Scream(){
                Abraxis Enemy = new Abraxis();
                Console.WriteLine("\n" + Enemy.name + ": " + " Maybe I've underestimated you!");
            }

            public void Defeat(){
                Abraxis Enemy = new Abraxis();
                Console.WriteLine("\nYOU LOST! - " + Enemy.name + ": Not even a million of you could possibly defeat me...");
                Console.ReadKey();
            }
            public void Victory(){
                Abraxis Enemy = new Abraxis();
                Console.WriteLine("\nYOU WON! - " + Enemy.name + ": You will see that in the end I'm not the bad guy... Ahhhrgh!");
                Console.ReadKey();
            }

        }

        internal class Absalom : Personagem {

            public Absalom(){
                name = "Absalom";
                health = 120;
                strength = 30;
                dexterity = 10;
            }

            public void Taunt() {
                Absalom Enemy = new Absalom();
                Console.WriteLine("\n" + Enemy.name + ": " + "You've grown weak!");
            }
            public void Scream() {
                Absalom Enemy = new Absalom();
                Console.WriteLine("\n" + Enemy.name + ": " + "You cannot defeat me, without forever damming your soul!");
            }
            public void Defeat(){
                Absalom Enemy = new Absalom();
                Console.WriteLine("\nYOU LOST! - " + Enemy.name + ": You were always weak, don't even bother next time! HAHAHAHAHA");
                Console.ReadKey();
            }
            public void Victory(){
                Absalom Enemy = new Absalom();
                Console.WriteLine("\nYOU WON! - " + Enemy.name + ": I can't believe I've been defeated by a mortal like you! Ahhhrgh!");
                Console.ReadKey();
            }

    }


}
