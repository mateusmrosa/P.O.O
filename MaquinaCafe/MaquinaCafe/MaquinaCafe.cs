using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    class MaquinaCafe
    {
        private double _valorCafe;
        private double _qtdeCafeVendidos;
        private double _valorInserido;
        private double _valorTroco;

        public double ValorCafe { get => _valorCafe; set => _valorCafe = value; }
        public double QtdeCafeVendidos { get => _qtdeCafeVendidos; set => _qtdeCafeVendidos = value; }
        public double ValorInserido { get => _valorInserido; set => _valorInserido = value; }
        public double ValorTroco { get => _valorTroco; set => _valorTroco = value; }


        public void inserirMoeda(double valorInserido)
        {
            valorInserido++;
        }

        public void pegarCafe()
        {
            return;
        }

        public double pegarTroco(double valorTroco)
        {
            valorTroco = ValorInserido - _valorCafe;
            return valorTroco;
        }

        public void reiniciarVenda()
        {

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

        public bool iniciaMaquina(double valorCafe)
        {
            return true;
        }

        public double retornaTotalVendido(double qtdeCafeVendidos)
        {
            return qtdeCafeVendidos;
        }

        public double getValorCafe()
        {
            return ValorCafe;
        }
    }
}
