using System;
using System.Collections.Generic;

public class FaixaIRRF
{
    public double LimiteMin { get; set; }
    public double LimiteMax { get; set; }
    public double Aliquota { get; set; }
    public double Deducao { get; set; }

    public bool DentroDaFaixa(double salarioBase)
    {
        return salarioBase >= LimiteMin && salarioBase <= LimiteMax;
    }
}

public class CalculadoraIRRF
{
    private List<FaixaIRRF> faixas = new List<FaixaIRRF>
    {
        new FaixaIRRF { LimiteMin = 0,        LimiteMax = 2428.80, Aliquota = 0.0,   Deducao = 0.0 },
        new FaixaIRRF { LimiteMin = 2428.81,  LimiteMax = 2826.65, Aliquota = 0.075, Deducao = 182.16 },
        new FaixaIRRF { LimiteMin = 2826.66,  LimiteMax = 3751.05, Aliquota = 0.15,  Deducao = 394.16 },
        new FaixaIRRF { LimiteMin = 3751.06,  LimiteMax = 4664.68, Aliquota = 0.225, Deducao = 675.49 },
        new FaixaIRRF { LimiteMin = 4664.69,  LimiteMax = double.MaxValue, Aliquota = 0.275, Deducao = 908.73 }
    };

    public double CalcularIRRF(double salarioBruto, double inssDesconto)
    {
        double salarioBase = salarioBruto - inssDesconto;

        // Encontra a faixa correspondente
        FaixaIRRF faixa = faixas.Find(f => f.DentroDaFaixa(salarioBase));

        // Cálculo do imposto
        double irrf = salarioBase * faixa.Aliquota - faixa.Deducao;

        // IRRF não pode ser negativo
        return irrf < 0 ? 0 : Math.Round(irrf, 2);
    }
}

public class Program
{
    public static void Main()
    {
        CalculadoraIRRF calc = new CalculadoraIRRF();

        double salarioBruto = 3000.00;
        double inss = 258.83;

        double irrf = calc.CalcularIRRF(salarioBruto, inss);

        Console.WriteLine("IRRF calculado: R$ " + irrf);
    }
}
