namespace Reply.Shared.Validation
{
    public static class CPFValidation
    {
        /// <summary>
        /// Method responsible for validate CPF value
        /// algorithm meet on  http://www.macoratti.net/alg_cpf.htm
        /// </summary>
        /// <param name="cpf">number matching a CPF</param>
        /// <returns></returns>
        public static bool Validate(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempNumber;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempNumber = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempNumber[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempNumber = tempNumber + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempNumber[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
