namespace csharp_es03_mattina
{
    public class Borsellino
    {
        static int iSomma = 0;
        public static int Add(int valore)
        {

            iSomma += valore;
            return iSomma;
        }
    }
}
