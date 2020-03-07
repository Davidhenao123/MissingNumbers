using System;
using System.Diagnostics;
using System.Linq;

namespace MissingNumbers.Business
{
    /// <summary>
    /// Clase que proporciona utilidades de uso general.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Order un array de forma ordena.
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static String[] SortArray(String[] arrayString)
        {
            Array.Sort(arrayString);
            return arrayString;
        }
        /// <summary>
        /// Función para eliminar los datos repetidos de un array tipo texto.
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static String[] DeleteRepeatData(String[] arrayString)
        {
            String[] response = arrayString.Distinct().ToArray();
            return response;
        }
        /// <summary>
        /// Función para eliminar los datos nulos de un arrary tipo texto.
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static String[] CleanNullData(String[] arrayString)
        {
            string[] response = arrayString.Where(y => y != null).ToArray();
            return response;
        }
        /// <summary>
        /// Función para convertir un array en una cadena de texto con el separador indicado
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static String ArrayToString(String[] arrayString, String separator)
        {
            String response = String.Empty;
            arrayString.ToList().ForEach(i => response += i.ToString() + separator);
            return response.Trim();
        }
        /// <summary>
        /// Función para convertir un array numerico en una cadena de texto con el separador indicado
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static String ArrayToString(Int32[] arrayString, String separator)
        {
            String response = String.Empty;
            arrayString.ToList().ForEach(i => response += i.ToString() + separator);
            return response.Trim();
        }
        /// <summary>
        /// Función para convertir un array String a Int
        /// </summary>
        /// <param name="arrayString"></param>
        /// <returns></returns>
        public static Int32[] ConvertArrayStringToInt(String[] arrayString)
        {
            Int32[] response = new Int32[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                response[i] = Convert.ToInt32(arrayString[i]);
            }
            return response;
        }
        /// <summary>
        /// Función para comparar los dos listados
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arrayTwo"></param>
        /// <returns></returns>
        public static String[] SearchInListMissingNumber(String[] arrayOne, String[] arrayTwo)
        {
            int indicePeridos = 0;
            String[] combined = new string[arrayOne.Length + arrayTwo.Length];
            String[] response = new String[arrayOne.Length + arrayTwo.Length];
            Array.Copy(arrayOne, combined, arrayOne.Length);
            Array.Copy(arrayTwo, 0, combined, arrayOne.Length, arrayTwo.Length);
            combined = Utilities.DeleteRepeatData(combined);
            foreach (String item in combined)
            {
                String[] ListaA = arrayOne.Where(y => y == item).ToArray();
                String[] ListaB = arrayTwo.Where(y => y == item).ToArray();
                if (ListaA.Length != ListaB.Length)
                {
                    response[indicePeridos] = item;
                    indicePeridos += 1;
                }
            }
            return response;
        }
        /// <summary>
        /// Escribi Excepción en archivo.
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteLog(String msg)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("TextWriterOutput.log", "myListener"));
            msg = DateTime.Today.ToString() + " " + msg;
            Trace.TraceInformation(msg);
            Trace.Flush();
        }
    }
}
