using System.Globalization;
using System.Text.RegularExpressions;

namespace NotaAlunoApi.Utils
{
    public class ValidaDataAni
    {
        public static bool ValidaData(string data)
        {
            DateTime resultado = DateTime.MinValue;
            
            if (DateTime.TryParse(data, out resultado))
            {
                return true;
            }
            return false;
        }
    }
}
