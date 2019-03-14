using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;
        
        public string Nome { get => _nome; set => _nome = value; }
        public double Nota1 { get => _nota1; set => _nota1 = value; }
        public double Nota2 { get => _nota2; set => _nota2 = value; }
        public double Nota3 { get => _nota3; set => _nota3 = value; }

        //metodo que faz calcula da media do aluno
        public double VerificaMedia()
        {
            return (this.Nota1 + this.Nota2 + this.Nota3) / 3;
        }
    }
}
