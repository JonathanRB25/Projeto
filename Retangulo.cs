using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

    

    public double GetArea()
        {
            return Largura * Altura;
        }

        public double GetPerimetro()
        {
            double soma = Largura + Altura;
            return soma * 2;
        }

    }
}    
        

