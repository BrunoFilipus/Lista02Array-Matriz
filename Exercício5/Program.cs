namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[4, 4] { { 100, 15, 33, 22 }, { 45, 111, 9, 30 }, { 90, 23, 21, 53 }, { 1, 88, 105, 29 } };
            int maior = numeros[0, 0];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (maior < numeros[i, j])
                    {
                        maior = numeros[i, j];
                    }
                }
            }
            Console.WriteLine(maior);
        }
    }
}
