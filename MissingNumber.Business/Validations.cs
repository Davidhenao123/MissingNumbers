using System;

namespace MissingNumbers.Business
{
    class Validations
    {
        /// <summary>
        /// Función para indicar si un numero es valido o no.
        /// </summary>
        /// <param name="Chain"></param>
        /// <returns></returns>
        static public bool IsNumeric(String text)
        {
            bool response = false;
            if (int.TryParse(text, out var numero))
            {
                response = true;
            }
            return response;
        }
        /// <summary>
        /// Fiunción para validar si la diferencia de un dato respecto de otro es mayor al tope.
        /// </summary>
        /// <param name="Maximo"></param>
        /// <param name="Minimo"></param>
        /// <returns></returns>
        static public bool DifferenceGreaterThan(int max, int min, int Top)
        {
            bool response = false;
            if ((max - min) > 100)
            {
                response = true;
            }
            return response;
        }
        /// <summary>
        /// Función para validar si los datos del arreglo son numericos.
        /// </summary>
        /// <param name="arreglo"></param>
        /// <returns></returns>
        static public bool IsNumericList(String[] arreglo, ref String noValid)
        {
            bool response = false;
            foreach (string dato in arreglo)
            {
                if (!int.TryParse(dato, out var numero))
                {
                    noValid += noValid + "|";
                }
            }
            return response;
        }
        /// <summary>
        /// Función para validar valor tope
        /// </summary>
        /// <param name="listNumeric"></param>
        /// <returns></returns>
        static public Boolean IsLessThan(Int32[] listNumeric, Int32 topValue)
        {
            Boolean indicator;
            if (listNumeric.Length >= 2)
            {
                if ((listNumeric[listNumeric.Length - 1] - listNumeric[0]) > topValue)
                {
                    indicator = false;
                }
                else
                {
                    indicator = true;
                }
            }
            else
            {
                indicator = false;
            }
            return indicator;
        }
    }
}
