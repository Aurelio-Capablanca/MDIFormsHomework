using Aguilar_Adalberto_p4.Componentes;
using Aguilar_Adalberto_p4.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Controlador
{
    internal class ConversionesControlador : FuncionesGenerales
    {

        private readonly Conversiones conversiones = new Conversiones();

        private bool Validar(string valor, string categoria)
        {
            double valorValidado = validarDecimales(valor);
            if (categoria.Equals("0")) 
            {
                MessageBox.Show("Debe seleccionar un valor de la lista");
                return false;
            }
            if (valorValidado.Equals(0))
            {
                MessageBox.Show("Error al Ingresar El Valor");
                return false;
            }            
            conversiones.Valor = valorValidado;            
            return true;
        }

        public Double Calcular(string categoria, string valor)
        {
            bool resultado = Validar(valor,categoria);
            if (resultado.Equals(false))
                return 0;
            return categoria.Equals("1") ? ConvertirLibrasKilogramos(conversiones.Valor) : ConvertirKilogramosLibras(conversiones.Valor);
        }



    }
}
