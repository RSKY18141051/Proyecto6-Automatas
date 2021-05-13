using System;

namespace Sintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Lenguaje l = new Lenguaje("C:\\Archivos\\Suma.cpp"))
                {
                    l.Programa();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
