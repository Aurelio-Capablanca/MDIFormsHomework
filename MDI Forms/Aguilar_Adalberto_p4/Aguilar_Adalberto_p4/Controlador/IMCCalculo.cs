using Aguilar_Adalberto_p4.Componentes;
using Aguilar_Adalberto_p4.Modelo.IMCModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Controlador.IMCControlador
{
    internal class IMCCalculo : FuncionesGenerales
    {
        private readonly IMC imc = new IMC();

        private bool Validar(String peso, String altura)
        {
            int pesoValidado = validarEnteros(peso);
            double alturaValidada = validarDecimales(altura);
            if (pesoValidado.Equals(0))
            {
                MessageBox.Show("Error al Ingresar el Peso");
                return false;
            }
            if (alturaValidada.Equals(0))
            {
                MessageBox.Show("Error al Ingresar la altura");
                return false;
            }
            imc.Peso = pesoValidado;
            imc.Altura = alturaValidada;
            return true;
        }


        public Double Calcular(String peso, String altura)
        {
            bool resultado = Validar(peso, altura);
            if (resultado.Equals(false))
                return 0;
            return ConvertirLibrasKilogramos(imc.Peso) / Math.Pow(imc.Altura, 2);
        }

    }
}
