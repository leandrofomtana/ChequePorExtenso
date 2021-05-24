using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso
{
    public class NumeroExtenso
    {
        private readonly double numeroTotal;
        private long reais;
        private int centavos;
        public NumeroExtenso(double numeroTotal)
        {
            this.numeroTotal = numeroTotal;
        }

        public double NumeroTotal => numeroTotal;

        public long Reais { get => reais; set => reais = value; }
        public int Centavos { get => centavos; set => centavos = value; }

        private void SeparaCentavoReal()
        {
            string numero = NumeroTotal.ToString();
            if (numero.Contains(","))
            {
                string[] numeros = numero.Split(',');
                Reais = Int64.Parse(numeros[0]);
                Centavos = Int32.Parse(numeros[1]);
            }
            else
                Reais = Int64.Parse(numero);
        }

        private string Digitos(int n)
        {
            string s = "";
            switch (n)
            {
                case 1:
                    s = "um";
                    break;
                case 2:
                    s = "dois";
                    break;
                case 3:
                    s = "três";
                    break;
                case 4:
                    s = "quatro";
                    break;
                case 5:
                    s = "cinco";
                    break;
                case 6:
                    s = "seis";
                    break;
                case 7:
                    s = "sete";
                    break;
                case 8:
                    s = "oito";
                    break;
                case 9:
                    s = "nove";
                    break;
            }
            return s;
        }
        private string DezADezenove(int n)
        {
            string s = "";
            switch (n)
            {
                case 10:
                    s = "dez";
                    break;
                case 11:
                    s = "onze";
                    break;
                case 12:
                    s = "doze";
                    break;
                case 13:
                    s = "treze";
                    break;
                case 14:
                    s = "quatorze";
                    break;
                case 15:
                    s = "quinze";
                    break;
                case 16:
                    s = "dezesseis";
                    break;
                case 17:
                    s = "dezessete";
                    break;
                case 18:
                    s = "dezoito";
                    break;
                case 19:
                    s = "dezenove";
                    break;
            }
            return s;
        }
        private string RestoDezenas(int n)
        {
            string s = "";
            switch (n)
            {
                case 20:
                    s = "vinte";
                    break;
                case 30:
                    s = "trinta";
                    break;
                case 40:
                    s = "quarenta";
                    break;
                case 50:
                    s = "cinquenta";
                    break;
                case 60:
                    s = "sessenta";
                    break;
                case 70:
                    s = "setenta";
                    break;
                case 80:
                    s = "oitenta";
                    break;
                case 90:
                    s = "noventa";
                    break;
            }
            return s;
        }
        private string Centenas(int n, bool cento)
        {
            string s = "";
            switch (n)
            {
                case 100:
                    s = "cem";
                    break;
                case 200:
                    s = "duzentos";
                    break;
                case 300:
                    s = "trezentos";
                    break;
                case 400:
                    s = "quatrocentos";
                    break;
                case 500:
                    s = "quinhentos";
                    break;
                case 600:
                    s = "seiscentos";
                    break;
                case 700:
                    s = "setecentos";
                    break;
                case 800:
                    s = "oitocentos";
                    break;
                case 900:
                    s = "novecentos";
                    break;
            }
            if (s == "cem" && cento == true)
                s = "cento";
            return s;
        }
        private string OrdemDeDezenasExtenso(int n)
        {
            string s = "";
            if (n < 10)
                s += Digitos(n);
            else if (n < 20)
                s += DezADezenove(n);
            else if (n < 100)
            {
                int dezena = n / 10 * 10;
                int digitos = n % 10;
                s += RestoDezenas(dezena);
                if (digitos > 0)
                    s += " e " + Digitos(digitos);
            }
            return s;
        }
        private string OrdemDeCentenasExtenso(int n3Casa)
        {

            string s = "";
            if (n3Casa < 100)
            {
                s = OrdemDeDezenasExtenso(n3Casa);
            }
            else
            {
                int centena = n3Casa / 100 * 100;
                int dezenaEDigitos = n3Casa % 100;
                if (dezenaEDigitos != 0)
                {
                    s += Centenas(centena, true);
                    s += " e " + OrdemDeDezenasExtenso(dezenaEDigitos);
                }
                else
                    s += Centenas(centena, false);
            }
            return s;
        }
        public string DivisaoDe3em3()
        {
            string s;
            string montagem = "";
            string[] de3Em3 = null;
            s = reais.ToString();
            int numeroDeCasas = s.Length;
            if (numeroDeCasas > 3)
            {
                for (int i = numeroDeCasas - 3; i > 0; i -= 3)
                {
                    s = s.Insert(i, ",");
                }
                de3Em3 = s.Split(',');
                int a = de3Em3.Length;
                foreach (var item in de3Em3)
                {
                    bool singular = false;
                    int numero = Int32.Parse(item);
                    int casaCentena = numero / 100;
                    int dezenas = numero % 100;
                    if (numero == 1)
                        singular = true;
                    if (casaCentena != 0 && dezenas == 0 && a == 1)
                        montagem += "e " + OrdemDeCentenasExtenso(numero);
                    else
                        montagem += OrdemDeCentenasExtenso(numero) + TipoDe3(a,singular);
                    a--;
                }
            }
            return montagem;
        }

        private string TipoDe3(int a, bool singular)
        {
            string s = "";
            switch (a)
            {
                case 4:
                    s = " bilhões ";
                    if (singular == true)
                        s = " bilhão ";
                    break;
                case 3:
                    s = " milhões ";
                    if (singular == true)
                        s = " milhão ";
                    break;
                case 2:
                    s = " mil ";
                    break;
            }
            return s;
        }

        private string RealExtenso()
        {
            string s = "";
            if (reais < 1000)
            {
                s = OrdemDeCentenasExtenso((int)reais);
            }
            else {
                s = DivisaoDe3em3();
            }
                if (reais == 1)
                s += " real";
            else
                s += " reais";
            return s;
        }

        private string CentavoExtenso()
        {
            string s = OrdemDeDezenasExtenso(centavos);
            if (centavos == 1)
                s += " centavo";
            else
                s += " centavos";
            return s;
        }

        public string Extenso()
        {
            string extenso = "";
            bool real = false;
            SeparaCentavoReal();
            if (reais != 0)
            {
                extenso += RealExtenso();
                real = true;
            }
            if (centavos != 0)
            {
                if (real == true)
                    extenso += " e ";
                extenso += CentavoExtenso();
            }
            return char.ToUpper(extenso[0]) + extenso.Substring(1);

        }


    }
}

