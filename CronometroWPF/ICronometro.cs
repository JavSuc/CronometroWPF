using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronometroWPF
{
    public interface ICronometro
    {
        //       string ValueCrono { get; }
        int Segundos { get; }
        int Minutos { get; }
        int Horas { get; }
        void Arrancar();
        void Pausar();
        void Stop();
        void Avanza();
    }
}
