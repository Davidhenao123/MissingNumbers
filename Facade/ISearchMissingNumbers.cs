using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers.Facade
{
    public interface ISearchMissingNumbers
    {
        /// <summary>
        /// Implementa la funcion SearchMissingNumbersChain del componente Business
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        String SearchMissingNumbersChain(String inputText);
    }
}
