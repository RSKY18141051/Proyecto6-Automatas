using System;
using System.Collections.Generic;
using System.Text;

namespace Sintaxis3
{
    class Sintaxis : Lexico
    {
        public Sintaxis()
        {
            Console.WriteLine("Iniciando analisis sintactico.");
            NextToken();
        }

        public Sintaxis(string nombre) : base(nombre)
        {
            Console.WriteLine("Iniciando analisis sintactico.");
            NextToken();
        }

        protected void match(string espera)
        {
            //Console.WriteLine(getContenido() + " = " + espera);
            if (espera == getContenido())
            {
                NextToken();
            }
            else
            {
                bitacora.WriteLine("ERROR DE SINTAXIS EN LINEA {0}, EN CARACTER {1}", linea, caracter);
                bitacora.WriteLine("ERROR DE SINTAXIS: SE ESPERA UN " + espera);
                Console.WriteLine("ERROR DE SINTAXIS EN LINEA {0}, EN CARACTER {1}", linea, caracter);
                throw new Exception("ERROR DE SINTAXIS: SE ESPERA UN " + espera);
            }
        }

        protected void match(clasificaciones espera)
        {
            //Console.WriteLine(getContenido() + " = " + espera);
            if (espera == getClasificacion())
            {
                NextToken();
            }
            else
            {
                bitacora.WriteLine("ERROR DE SINTAXIS EN LINEA {0}, EN CARACTER {1}", linea, caracter);
                bitacora.WriteLine("ERROR DE SINTAXIS: SE ESPERA UN " + espera);
                Console.WriteLine("ERROR DE SINTAXIS EN LINEA {0}, EN CARACTER {1}", linea, caracter);
                throw new Exception("ERROR DE SINTAXIS: SE ESPERA UN " + espera);
            }
        }
    }
}