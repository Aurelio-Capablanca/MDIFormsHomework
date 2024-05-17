using Aguilar_Adalberto_p4.Componentes;
using Aguilar_Adalberto_p4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Controlador
{
    internal class MCLICControlador : FuncionesGenerales
    {
        private readonly MLIC mlic = new MLIC();

        private bool Validar(String altura)
        {            
            double alturaValidada = validarDecimales(altura);            
            if (alturaValidada.Equals(0))
            {
                MessageBox.Show("Error al Ingresar la Altura");
                return false;
            }
            mlic.Altura = alturaValidada;           
            return true;
        }

        public double CalcularMLIC(String altura) {
            bool resultado = Validar(altura);
            if (resultado.Equals(false))
                return 0;
            double calculo = (50 + (0.75 * (mlic.Altura - 150)));
            return calculo < 0 ? calculo * -1 : calculo;
        }

    }
}
