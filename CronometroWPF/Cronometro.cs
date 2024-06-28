using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CronometroWPF
{
    internal class Cronometro : DispatcherTimer, ICronometro
    {
 
        public int Segundos { get; set; }
        public int Minutos { get; set; }
        public int Horas { get; set; }

        private Cronometro()
        {
            Segundos = 0;
            Minutos = 0;
            Horas = 0;
        }

        public static Cronometro Create(EventHandler eventHandler)
        {
            Cronometro chrono = new Cronometro
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            chrono.Tick += eventHandler;
            return chrono;
        }

        public void Pausar()
        {
            base.Stop();
        }

        public void Avanza()
        {
            Segundos++;
            if (Segundos == 60)
            {
                Minutos++;
                Segundos = 0;
                if (Minutos == 60)
                {
                    Horas++;
                    Minutos = 0;
                    Segundos = 0;
                }
            }
        }

        public new void Arrancar()
        {
            base.Start();
        }

        public new void Stop()
        {
            base.Stop();
            Segundos = 0;
            Minutos = 0;
            Horas = 0;
        }
    }

}
