using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclairProject
{
    public static class ClasseValida
    {
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
            string Telefone = Tel.Replace("(", "").Replace(")","").Replace("-","");
            long r;
            if (long.TryParse(Telefone, out r))    {return true;}
                     else                                    {return false;}
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
                     if (cpf == "11111111111")   {return false;}
                     if (cpf == "22222222222")   {return false;} 
                     if (cpf == "33333333333")   {return false;}
                     if (cpf == "44444444444")   {return false;}
                     if (cpf == "55555555555")   {return false;} 
                     if (cpf == "66666666666")   {return false;}
                     if (cpf == "77777777777")   {return false;}
                     if (cpf == "88888888888")   {return false;}
                     if (cpf == "99999999999")   {return false;}

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
                 else   {return false;}
            }

        public static bool IsIE(string ie)
        {
            string iesonumero = ie.Replace(".", "").Replace("-", "");
            System.Windows.Forms.MessageBox.Show(iesonumero);
            if (iesonumero.Length == 12)
            {

                long r;
                if (long.TryParse(iesonumero, out r)) { return true; }
                else { return false; }
            }
            else { return false; }
        }
      
        public static bool IsRG(string rg)
        {

                string rgsonumero = rg.Replace(".", "").Replace("-", "");
                string rgfinal = rgsonumero.Replace("x", "");
            if (rgfinal.Length == 9)
            {
                int r = 9;
                     if (int.TryParse(rgfinal, out r))    {return true;}
                     else                                    {return false;}
            }
            else                                             {return false;}
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