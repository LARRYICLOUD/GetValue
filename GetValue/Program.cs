using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Declaramos una variable de tipo "Type" y le asignamos nuestra enumeracion
            Type tipoEnumeracion = typeof(Continentes);

            //Matriz para almacenar la devolucion de "GetValues"
            Continentes[] constantesContinentes;
            //Le asignamos la devolucion del metodo "GetValues" a nuestra matriz "constantesContinentes"
            constantesContinentes = (Continentes[])Enum.GetValues(tipoEnumeracion);

            //Recorremos a la matriz
            foreach (Continentes elemento in constantesContinentes)
            {
                Console.WriteLine(elemento);
            }
        }
    }

    enum Continentes
    {
        Africa,
        America,
        Asia,
        Europa,
        Oceania
    }
}
