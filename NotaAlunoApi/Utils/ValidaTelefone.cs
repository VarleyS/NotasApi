using System.Text.RegularExpressions;

namespace NotaAlunoApi.Utils
{
    public class ValidaTelefone
    {
        public static bool ValidaTel(string telefone)
        {
            Regex regex = new Regex(@"^\(\d{2}\)\d{5}-\d{4}$"); // formato (xx)xxxxx-xxxx

            if(!regex.IsMatch(telefone))
            {
                return false;
            }
            else
                return true;
        }
    }
}
