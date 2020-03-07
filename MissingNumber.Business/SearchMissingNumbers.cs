using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers.Business
{
    /// <summary>
    /// Clase que implementa un función para buscar entre dos listados los numeros perdidos.
    /// </summary>
    public static class SearchMissingNumbers
    {
        /// <summary>
        /// Funcion para buscar entre dos cadenas de texto lo numeros perdidos.
        /// </summary>
        public static String SearchMissingNumbersChain(String inputText)
        {
            try
            {
                String response = String.Empty;
                List<string> listaTextoP = inputText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                String linea1 = listaTextoP[0];
                String linea2 = listaTextoP[1];
                String linea3 = listaTextoP[2];
                String linea4 = listaTextoP[3];
                if (!int.TryParse(linea1, out Int32 nroItemsLista1))
                {
                    response = Messages._001;
                }
                else
                {
                    if (!int.TryParse(linea3, out Int32 nroItemsLista2))
                    {
                        response = Messages._002;
                    }
                    else
                    {
                        String[] arreglo1 = linea2.Split(' ');
                        String[] arreglo2 = linea4.Split(' ');
                        if (nroItemsLista1 != arreglo1.Length)
                        {
                            response = Messages._003;
                        }
                        else
                        {
                            if (nroItemsLista2 != arreglo2.Length)
                            {
                                response = Messages._004;
                            }
                            else
                            {
                                String invalidString = String.Empty;
                                Validations.IsNumericList(arreglo1, ref invalidString);
                                if (!String.IsNullOrEmpty(invalidString))
                                {
                                    response = String.Format(Messages._005, invalidString);
                                }
                                else
                                {
                                    invalidString = String.Empty;
                                    Validations.IsNumericList(arreglo2, ref invalidString);
                                    if (!String.IsNullOrEmpty(invalidString))
                                    {
                                        Console.WriteLine(String.Format(Messages._006, invalidString));
                                    }
                                    String[] listLost = Utilities.SearchInListMissingNumber(arreglo1, arreglo2);
                                    String[] listWithoutNulls = Utilities.CleanNullData(listLost);
                                    Int32[] listNumeric = Utilities.ConvertArrayStringToInt(listWithoutNulls);
                                    Array.Sort(listNumeric);
                                    if(!Validations.IsLessThan(listNumeric, Convert.ToInt32(Parameters.TopValue)))
                                    {
                                        response = Messages._007;
                                    }
                                    response = Utilities.ArrayToString(listNumeric, Parameters.Separator);
                                }
                            }
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
