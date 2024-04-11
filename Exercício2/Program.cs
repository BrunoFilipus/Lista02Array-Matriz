namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] { 15, 2, 23, 14, 11 };
            int maior = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (maior < numeros[i])
                {
                    maior = numeros[i];
                }
                if (menor > numeros[i])
                {
                    menor = numeros[i];
                }
                //for (int j = 4; j >= 0; j--)
                //{
                //    maior = numeros[i] > numeros[j] ? numeros[i] : numeros[j];
                //    menor = numeros[i] < numeros[j] ? numeros[j] : numeros[i];
                //}
            }
            Console.WriteLine($"O maior é {maior} e o menor é {menor}.");

            //for (int i = 0; i <= numeros.Length; i++)
            //{
            //    if (numeros[0] < numeros[1])
            //    {
            //        troca = numeros[0];
            //        numeros[0] = numeros[1];
            //        numeros[1] = troca;
            //    }
            //    if (numeros[0] < numeros[2])
            //    {
            //        troca = numeros[0];
            //        numeros[0] = numeros[2];
            //        numeros[2] = troca;
            //    }
            //    if (numeros[0] < numeros[3])
            //    {
            //        troca = numeros[0];
            //        numeros[0] = numeros[3];
            //        numeros[3] = troca;
            //    }
            //    if (numeros[0] < numeros[4])
            //    {
            //        troca = numeros[0];
            //        numeros[0] = numeros[4];
            //        numeros[4] = troca;
            //    }
            //}
            //for (int i = 0; i <= numeros.Length; i++)
            //{
            //    if (numeros[4] > numeros[1])
            //    {
            //        troca = numeros[4];
            //        numeros[4] = numeros[1];
            //        numeros[1] = troca;
            //    }
            //    if (numeros[4] > numeros[2])
            //    {
            //        troca = numeros[4];
            //        numeros[4] = numeros[2];
            //        numeros[2] = troca;
            //    }
            //    if (numeros[4] > numeros[3])
            //    {
            //        troca = numeros[4];
            //        numeros[4] = numeros[3];
            //        numeros[3] = troca;
            //    }
            //}
            //Console.WriteLine($"Maior número {numeros[0]} Menor número {numeros[4]}");
        }
    }
}
