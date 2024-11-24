namespace The_Shadow_Lands{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("So, you've stepped into the Shadow Lands... You're either brave or stupid.");
            Console.WriteLine("\nEither way, what's your name?");
            //O jogo deve começar pedindo ao jogador para inserir o nome do personagem.
            string nome = Console.ReadLine();
            Console.WriteLine("\nThat's an odd name you have, tell me, how old are you?");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 50){
                Console.WriteLine("You must be crazy to come here that old!\nAnyway...");
            }
            else {
                Console.WriteLine("\nI guess you're not that old to be here...");
            }
            Personagem Player = new Personagem(nome, idade);
            Quest tarefa = new Quest(Player);

        }
    }
}

/*

Classe Quest: Implemente uma classe que contenha no mínimo duas funções que representem missões ou desafios que o jogador deve superar. Essas funções devem influenciar o curso do jogo. 
 

Implementação  
 Use esse nome de maneira criativa ao longo do jogo para personalizar a experiência. 
Inicie a narrativa introduzindo o jogador a uma das funções da classe Quest. 
Estabeleça condições claras de vitória e derrota no jogo. 
Desafio Extra: 
Classe Inventário: Para aqueles que buscam um desafio adicional, crie uma classe Inventário que permita ao personagem armazenar itens que podem ser utilizados ao longo do jogo. 


Critérios de Avaliação: 
Uso de variáveis (1,0) 
Uso de operadores (1,0) 
Uso de estruturas condicionais (1,0) 
Uso de estruturas de repetição (1,0) 
Uso de métodos (1,0) 
Uso de classes (1,0) 
Uso de herança (1,0) 
Execução sem bugs (3,0) 
 

Observação Importante: Para garantir a originalidade do trabalho, cada aluno deverá incluir uma variável ou um elemento único que remeta ao seu próprio nome. Isso pode ser implementado de diversas formas, como um item especial no inventário, um inimigo nomeado ou uma característica única do personagem.  

 

Formato de Entrega: Envie o código em um arquivo .zip que contenha todos os arquivos necessários para a execução do jogo. A escolha da linguagem de programação fica a critério do aluno.  

 */