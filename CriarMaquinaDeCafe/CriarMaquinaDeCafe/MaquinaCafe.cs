using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarMaquinaDeCafe
{
    class MaquinaCafe
    {
        //atributos/propriedades
        private double _valorCafe;
        private double _qtdeCafeVendidos;
        private double _valorInserido;
        private double _valorTroco;

        //get/set
        public double ValorCafe { get => _valorCafe; set => _valorCafe = value; }
        public double QtdeCafeVendidos { get => _qtdeCafeVendidos; set => _qtdeCafeVendidos = value; }
        public double ValorInserido { get => _valorInserido; set => _valorInserido = value; }
        public double ValorTroco { get => _valorTroco; set => _valorTroco = value; }

        //métodos

        public void InserirMoeda(double valorInserido)
        {
            valorInserido++;
        }

        public void pegarCafe()
        {
            return;
        }

        public double getValorCafe()
        {
            return ValorCafe;
        }

        public double pegarTroco(double valorCafe, double valorInserido)
        {
            return _valorTroco = valorInserido - ValorCafe;
        }

        public void reiniciarVenda()
        {
            _valorCafe = 0;
        }


        //public int getQtdeCafesVendidos()
        //{

        //}

        //public double getValorInserido(double valor)
        //{

        //}

        public double setValorCafe(double valorCafe)
        {
            return valorCafe;
        }



        public double retornaTotalVendido(double qtdeCafeVendidos)
        {
            return qtdeCafeVendidos;
        }
    }
}







        
