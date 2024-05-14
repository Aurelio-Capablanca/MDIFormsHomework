using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelascoAguilar.Controlador;
using VelascoAguilar.Modelo;
using System.Windows.Forms;

namespace VelascoAguilar
{
    class IMCCalculo : Componentes
    {

        private Variables variables = new Variables();

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
            variables.Peso = pesoValidado;
            variables.Altura = alturaValidada;
            return true;
        }

        private Double ConvertirLibrasKilogramos(Int32 libras)
        {
            return libras * 0.453592;
        }

        public Double Calcular(String peso, String altura)
        {
            bool resultado = Validar(peso, altura);
            if (resultado.Equals(false))
                return 0;
            return ConvertirLibrasKilogramos(variables.Peso) / Math.Pow(variables.Altura, 2);
        }

    }
}
