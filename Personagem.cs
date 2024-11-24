using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Shadow_Lands{
    /* Classe Personagem: Crie uma classe que 
     * represente o personagem do jogador, contendo 
     * atributos básicos como nome, saúde, força, etc.  */
    internal class Personagem{
        //atributos
        public string name;
        public float health;
        public float strength;
        public float dexterity;
        public string guardianAngel;

        //construtor
        public Personagem(){
            //dados padrao
            name = "";
            health = 100;
            strength = 10;
            dexterity = 5;
            guardianAngel = "";

        }
        public Personagem(string nomeDado, int idade){
            //recebe o nome quando cria a classe
            name = nomeDado;
            //dados padrao
            health = 70;
            strength = 40;
            dexterity = 25;
            guardianAngel = "Kevin";
            Console.WriteLine("\nHello mortal one called: " + nomeDado);
            Console.WriteLine("\nFarewell, now let's see who will accompany you in your journey...");
            if(name != guardianAngel){
                Console.WriteLine("\nYour Guardian Angel goes by the name of " + guardianAngel);
            } else {
                Console.WriteLine("\nBy the gods, your name is the same of your Guardian Angel: " + guardianAngel + "!");
            }
        }

    }
}
