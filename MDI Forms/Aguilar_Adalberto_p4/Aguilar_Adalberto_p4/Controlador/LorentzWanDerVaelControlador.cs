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
    internal class LorentzWanDerVaelControlador : FuncionesGenerales
    {

        private readonly LorentzWanDerVael lorentz = new LorentzWanDerVael();

        private bool Validar(String genero, String altura)
        {
            int generoValidado = validarEnteros(genero);
            double alturaValidada = validarDecimales(altura);
            if (generoValidado.Equals(0))
            {
                MessageBox.Show("Error al Ingresar el Genero");
                return false;
            }
            if (alturaValidada.Equals(0))
            {
                MessageBox.Show("Error al Ingresar la Altura");
                return false;
            }
            lorentz.Genero = generoValidado;
            lorentz.Altura = alturaValidada;
            return true;
        }

        public Double CalcularLorentz(String genero, String altura)
        {
            bool resultado = Validar(genero, altura);
            if (resultado.Equals(false))
                return 0;            
            double calculo = lorentz.Genero.Equals(2) ? (lorentz.Altura - 100) - (lorentz.Altura - 150) / 2 : (lorentz.Altura - 100) - (lorentz.Altura - 150) / 4;
            return calculo;
        }

        public Double CalcularWanDerVael(String genero, String altura)
        {
            bool resultado = Validar(genero, altura);
            if (resultado.Equals(false))
                return 0;
            double determinar = lorentz.Genero.Equals(2) ? 0.6 : 0.75;
            return ((lorentz.Altura - 150) * determinar) + 50;
        }
    }
}
