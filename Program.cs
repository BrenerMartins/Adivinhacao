namespace adivinhacao;

class Program
{
    static void Main(string[] args)
    {
        Jogo();
    }

    static void Jogo() {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Bem vindo ao Jogo de adivinhação!");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Digite um número para coomeçar :)");
        

        int numeroSecreto = int.Parse(Console.ReadLine());
        numeroSecreto = 42;
        
        do
        {
            Console.Write("Digite um número entre 1 e 100: ");
            int chute = int.Parse(Console.ReadLine());

            if (chute == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                break;
            }
            else if (chute < numeroSecreto)
            {
                Console.WriteLine("O número é maior.");
            }
            else
            {
                Console.WriteLine("O número é menor.");
            }

        } while (true);

    }
}
