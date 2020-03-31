using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Domains;

namespace Calculadora.Interfaces
{
    public interface ICalculadoraRepository
    {
       
        double Somar(double N1, double N2, Operacao operacao);

        double Subt( Operacao operacao);
    }
}
