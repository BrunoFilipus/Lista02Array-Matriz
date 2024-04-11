namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor para {i}, {j}: ");
                    numeros[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{numeros[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
