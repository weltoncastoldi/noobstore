using System.Text.RegularExpressions;

namespace NoobStore.Core.DomainObjects
{
    /// <summary>
    /// Conceito de Acertion Concern
    /// </summary>
    public class Validacoes
    {
        public static void ValidarSeIgual(object objeto1, object objeto2, string mensagem)
        {
            if (!objeto1.Equals(objeto2)) throw new DomainException(mensagem);
        }
        public static void ValidarSeDiferente(object objeto1, object objeto2, string mensagem)
        {
            if (objeto1.Equals(objeto2)) throw new DomainException(mensagem);
        }
        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarExpressao(string pattern, string valor, string mensagem)
        {
            var regex = new Regex(pattern);
            if (!regex.IsMatch(valor)) throw new DomainException(mensagem);
        }
        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length == 0) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(long valor, long minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(double valor, double minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(decimal valor, decimal minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(int valor, int minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeFalso(bool boolvalor, string mensagem)
        {
            if (boolvalor) throw new DomainException(mensagem);
        }
        public static void ValidarSeVerdadeiro(bool boolvalor, string mensagem)
        {
            if (!boolvalor) throw new DomainException(mensagem);
        }
    }
}