using System;

namespace EclairProject
{
    public static class ClasseValida
    {
        public static bool IsSite(string site)
        {
            int ponto = site.IndexOf(".");
            if (ponto < 1)
                return false;
            else
                return true;
        }

        public static bool IsEmail(string email)
        {
            int arr = email.IndexOf("@");
            if (arr < 1) // Checa por 1 arroba
                return false;
            if (email.IndexOf("@", arr + 1) > -1) //Checa por um 2º arroba
                return false;

            int arr2 = email.IndexOf(".", arr + 1);
            if (arr2 < 1)
                return false;

            return true;
        }

        public static bool Data(string data)
        {
            DateTime dt;
            return DateTime.TryParse(data, out dt);
        }

        public static bool IsTel(string Tel)
        {
            string Telefone = Tel.Replace("(", "").Replace(")", "").Replace("-", "");
            if (Tel.Length > 9)
            {
                long r;
                if (long.TryParse(Telefone, out r)) { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }
        }

        public static bool IsCep(string cepp)
        {
            string Cep = cepp.Replace("-", "");
            int r;
            if (int.TryParse(Cep, out r)) { return true; }
            else { return false; }
        }

        public static bool IsCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length == 11)
            {
                if (cpf == "11111111111") { return false; }
                if (cpf == "22222222222") { return false; }
                if (cpf == "33333333333") { return false; }
                if (cpf == "44444444444") { return false; }
                if (cpf == "55555555555") { return false; }
                if (cpf == "66666666666") { return false; }
                if (cpf == "77777777777") { return false; }
                if (cpf == "88888888888") { return false; }
                if (cpf == "99999999999") { return false; }

                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                { return false; }
                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                { resto = 0; }
                else
                { resto = 11 - resto; }
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                { soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i]; }
                resto = soma % 11;
                if (resto < 2)
                { resto = 0; }
                else
                { resto = 11 - resto; }
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
            else { return false; }
        }

        public static bool IsIE(string ie)
        {
            int digito1;
            int digito2;
            int resto1;
            int resto2;
            int soma = 0;
            int soma2 = 0;
            ie = ie.Replace(".", "");

            int[] multiplicador1 = new int[8] { 1, 3, 4, 5, 6, 7, 8, 10 };
            int[] multiplicador2 = new int[8];
            int[] multiplicador3 = new int[11] { 3, 2, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador4 = new int[11];
            ie = ie.Substring(0, 12);

            for (int i = 0; i < 8; i++)
            {
                multiplicador2[i] = multiplicador1[i] * int.Parse(ie[i].ToString());
                soma = soma + multiplicador2[i];
            }
            resto1 = soma % 11;
            if (resto1 > 10)
            {
                digito1 = resto1 / 10;
            }
            else
            {
                digito1 = resto1;
            }
            /////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 11; i++)
            {
                multiplicador4[i] = multiplicador3[i] * int.Parse(ie[i].ToString());
                soma2 = soma2 + multiplicador4[i];
            }
            resto2 = soma2 % 11;
            if (resto2 > 10)
            {
                digito2 = resto2 / 10;
            }
            else
            {
                digito2 = resto2;
            }

            if (int.Parse(ie[8].ToString()) == digito1)
            {
                if (int.Parse(ie[11].ToString()) == digito2)
                {
                    return true;
                }
                else return false;
            }
            else return false;
            /////////////////////////////////////////////////////////////////////////////////////
        }

        public static bool IsRG(string rg)
        {
            int digito;
            string tempRg;
            int soma;
            int resto;
            soma = 0;
            rg = rg.Trim();
            string rgsonumero = rg.Replace(".", "").Replace("-", "");
            string rgfinal = rgsonumero.Replace("x", "");
            if (rgfinal.Length == 9)
            {
                tempRg = rgfinal.Substring(0, 9);
                int[] multiplicador1 = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] multiplicador2 = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    multiplicador2[i] = multiplicador1[i] * int.Parse(tempRg[i].ToString());
                }
                for (int i = 0; i < 8; i++)
                {
                    soma = soma + multiplicador2[i];
                }
                resto = soma % 11;
                digito = 11 - resto;
                if (digito == 10)
                {
                    if (tempRg == "x")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (digito == int.Parse(tempRg[8].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsCnpj(string vrCNPJ)
        {
            string CNPJ = vrCNPJ.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");

            int[] digitos, soma, resultado;
            int nrDig; string ftmt; bool[] CNPJOk;

            ftmt = "6543298765432";

            digitos = new int[14];
            soma = new int[2]; soma[0] = 0; soma[1] = 0;

            resultado = new int[2];
            resultado[0] = 0; resultado[1] = 0;

            CNPJOk = new bool[2]; CNPJOk[0] = false;
            CNPJOk[1] = false;
            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));

                    if (nrDig <= 11) soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12) soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }
                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1)) CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    else CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }
                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch { return false; }
        }
    }
}