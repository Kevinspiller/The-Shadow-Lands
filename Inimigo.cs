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
    internal class Inimigo : Personagem{
        public int enemyPower;
        //criando um construtor
        public Inimigo(){
            name = "Abraxis";
            health = 120;
            strength = 10000;
            level = 10;
            dexterity = 10;
            enemyPower = 9999;

        }

        public void Taunt(){
            Console.WriteLine("Hahahaha, that's the best you can do?");
        }
    }
}
