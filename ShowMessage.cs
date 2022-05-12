namespace csharp_es03_mattina
{
    internal class ShowMessage
    {

        //static fa in modo che il metodo sia accessibile
        public static void AppendMessage(string s)
        {

            //implementazione foreach
            int pos = 0;
            foreach (char c in s)
            {
                if (pos == 10)
                {
                    Console.WriteLine();
                    pos = 0;

                }
                Console.Write(c);
                pos++;
            }


            //implementazione iterativa
            /*while (s.Length > 10)
            {
                Console.WriteLine(s.Substring(0, 10));
                s = s.Substring(10);

            }
            Console.WriteLine(s);*/



            //implementazione ricorsiva
            /*if (s.Length > 10)
            {
            Console.WriteLine(s.Substring(0, 10));
                AppendMessage(s.Substring(10));

            } else
            {
                Console.WriteLine(s);
            }*/
        }

    }
}
