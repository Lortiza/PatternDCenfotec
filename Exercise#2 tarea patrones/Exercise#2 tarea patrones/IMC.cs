using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_tarea_patrones
{
    public class IMC
    {
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public double Resultado { get; private set; }
        public NivelIMC Nivel { get; private set; }

        public void Calcular()
        {
            Resultado = Peso / (Estatura * Estatura);

            if (Resultado < 18.5)
            {
                Nivel = NivelIMC.BajoPeso;
            }
            else if (Resultado < 24.9)
            {
                Nivel = NivelIMC.Normal;
            }
            else if (Resultado < 29.9)
            {
                Nivel = NivelIMC.Sobrepeso;
            }
            else
            {
                Nivel = NivelIMC.Obeso;
            }
        }


        public string NivelDescripcion()
        {
            switch (Nivel)
            {
                case NivelIMC.BajoPeso:
                    return "Bajo peso. Menos de 18.5";
                case NivelIMC.Normal:
                    return "Normal. Entre 18.5 y 24.9";
                case NivelIMC.Sobrepeso:
                    return "Sobrepeso. Entre 25.0 y 29.9";
                case NivelIMC.Obeso:
                    return "Obesidad. Más de 30.0";
                default:
                    return string.Empty;
            }
        }


    }





    public enum NivelIMC
    {
        BajoPeso,
        Normal,
        Sobrepeso,
        Obeso
    }



    }

