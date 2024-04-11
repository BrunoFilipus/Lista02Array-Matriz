namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            foreach (int a in numeros)
            {
                Console.WriteLine(a);
            }
        }
    }
}
