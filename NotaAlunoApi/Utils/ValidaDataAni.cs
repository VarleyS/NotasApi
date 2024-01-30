using System.Globalization;
using System.Text.RegularExpressions;

namespace NotaAlunoApi.Utils
{
    public class ValidaDataAni
    {

        public static void ValidaDataAniversario(DateTime data)
        {
            var teste = data.ToString();

            var match = Regex.Match(teste.ToString(), @"^([1-9]|([012][0-9])|(3[01]))\/([0]{0,1}[1-9]|1[012])\/\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]$g");
            

            if (match.Success)
            {
                Console.WriteLine("Data Valida!");
            }

        }
    }
}
