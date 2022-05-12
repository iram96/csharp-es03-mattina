namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.AppendMessage("piiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiip");

            int valore;

            /*while (int.TryParse(Console.ReadLine(), out valore))
            {
                Console.WriteLine(Borsellino.Add(valore));

            }*/

            Salvadanaio salva1 = new Salvadanaio();
            Salvadanaio salva2 = new Salvadanaio();

            while (int.TryParse(Console.ReadLine(), out valore))
            {
                Console.WriteLine(salva1.Add(valore)); //add primo salvadanaio
                valore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(salva2.Add(valore)); //add secondo salvadanaio

            }

        }
    }
}