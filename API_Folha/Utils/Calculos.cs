namespace API.Utils
{
    public class Calculos
    {
        public static double CalcularSalarioBruto(int quantidadeHoras, double valorHora)
            => quantidadeHoras * valorHora;

        public static double CalcularImpostoRenda(double bruto)
        {
            if (bruto <= 1903.98) return 0;

            if (bruto <= 2826.65) return bruto * 0.075 - 142.8;
                                
            if (bruto <= 3751.05) return bruto * 0.15 - 354.80;

            if (bruto <= 4664.68) return bruto * 0.225 - 636.13;
                
            return bruto * 0.275 - 869.36;
        }

        public static double CalcularInss(double bruto)
        {
            if(bruto <= 1693.72) return bruto * 0.08;

            if(bruto <= 2822.90) return bruto * 0.09;

            if(bruto <= 5645.80) return bruto * 0.11;

            return 621.03;
        }

        public static double CalcularFgts(double bruto) =>
            bruto * 0.08;

        public static double CalcularSalarioLiquido
            (double bruto, double renda, double inss) =>
            bruto - renda - inss;
    }
}