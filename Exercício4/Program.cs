namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primeiro = new int[3] { 11, 12, 13 };
            int[] segundo = new int[3] { 11, 12, 13 };
            int[] terceiro = new int[3];

            for (int i = 0; i < primeiro.Length; i++)
            {
                terceiro[i] = primeiro[i] + segundo[i];
            }
            foreach (int a in terceiro)
            {
                Console.WriteLine(a);
            }
        }
    }
}
