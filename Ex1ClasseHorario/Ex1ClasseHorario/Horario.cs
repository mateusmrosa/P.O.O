using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1ClasseHorario
{
    class Horario
    {
        private int hora;
        private int minuto;
        private int segundo;

        public Horario(int hora, int minuto, int segundo)
        {
            hora = 0;
            minuto = 0;
            segundo = 0;
        }

        public int Hora { get => hora; set => hora = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        public int Segundo { get => segundo; set => segundo = value; }


        public void incrementaHorarioEmHora(int hora, int minuto, int segundo)
        {
            hora += hora;
            minuto += minuto;
            segundo += segundo;
        }

        public void Decrementa(int hora, int minuto, int segundo)
        {
            hora -= hora;
            minuto -= minuto;
            segundo -= segundo;
        }

    }
}

