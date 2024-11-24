﻿using System;
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
                strength = 25;
                dexterity = 20;
            }

            public void Taunt(){
                Fury Enemy = new Fury();
                Console.WriteLine("\n"+Enemy.name+":" + "Hahahaha, that's the best you can do?");
            }
            public void Scream(){
                Fury Enemy = new Fury();
                Console.WriteLine("\n"+Enemy.name+":" + "Ahhhh, you bastard!");
            }
        }
 }
