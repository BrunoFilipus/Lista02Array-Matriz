namespace Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] animais = new string [5,4] {
                { "Fido", "Cachorro", "5", "10kg" },
                { "Whiskers", "Gato", "5", "5kg" },
                { "Buddy", "Cachorro", "3", "8kg" },
                { "Fluffy", "Gato", "2", "4kg" },
                { "Spot", "Cachorro", "4", "12kg" } };
            
            Console.Write("Digite o que deseja procurar: ");
            string busca = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Nome \t\tEspécie \t\tIdade \t\tPeso");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (busca == animais[i,j])
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            Console.Write($"{animais[i,k]}\t\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
