namespace NotaAlunoApi.Utils
{
    public class ValidaRG
    {
        public static bool RG(string rg)
        {
            rg = rg.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();

            int n1 = int.Parse(rg.Substring(0, 1));
            int n2 = int.Parse(rg.Substring(1, 1));
            int n3 = int.Parse(rg.Substring(2, 1));
            int n4 = int.Parse(rg.Substring(3, 1));
            int n5 = int.Parse(rg.Substring(4, 1));
            int n6 = int.Parse(rg.Substring(5, 1));
            int n7 = int.Parse(rg.Substring(6, 1));
            int n8 = int.Parse(rg.Substring(7, 1));

            string dv = rg.Substring(8, 1);

            int soma = n1 * 2 + n2 * 3 + n3 * 4 + n4 * 5 + n5 * 6 + n6 * 7 + n7 * 8 + n8 * 9;

            string digitoVerificador = Convert.ToString(soma % 11);

            if(digitoVerificador == "1")
            {
                digitoVerificador = "X";
            }
            else if(digitoVerificador == "0")
            {
                digitoVerificador = "0";
            }
            else
            {
                digitoVerificador = (11 - int.Parse(digitoVerificador)).ToString();
            }

            if(digitoVerificador == dv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
