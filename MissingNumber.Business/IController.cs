using System;

namespace MissingNumbers.Business
{
    public interface IController
    {
        /// <summary>
        /// Implementa la funcion SearchMissingNumbersChain del componente Business
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        String SearchMissingNumbersChain(String inputText);
        /// <summary>
        /// Escribi Excepción en archivo.
        /// </summary>
        /// <param name="msg"></param>
        void WriteLog(String msg);
    }
}
