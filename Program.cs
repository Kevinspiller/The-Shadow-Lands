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