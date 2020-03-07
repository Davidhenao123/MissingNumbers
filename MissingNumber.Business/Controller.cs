using MissingNumbers.Business;
using System;

namespace MissingNumbers.Business
{
    public class Controller : IController
    {
        /// <summary>
        /// Controladora
        /// </summary>
        public Controller()
        {

        }
        #region MissingNumbers
        /// <summary>
        /// Funcion para buscar entre dos cadenas de texto lo numeros perdidos.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public String SearchMissingNumbersChain(String inputText)
        {
            return MissingNumbers.Business.SearchMissingNumbers.SearchMissingNumbersChain(inputText);
        }
        #endregion
        #region Utilities
        /// <summary>
        /// Escribi Excepción en archivo.
        /// </summary>
        /// <param name="msg"></param>
        public void WriteLog(String msg)
        {
            MissingNumbers.Business.Utilities.WriteLog(msg);
        }
        #endregion
    }
}
