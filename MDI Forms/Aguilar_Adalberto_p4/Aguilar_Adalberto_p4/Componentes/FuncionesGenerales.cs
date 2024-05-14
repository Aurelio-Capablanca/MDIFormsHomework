using Aguilar_Adalberto_p4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Componentes
{
    internal class FuncionesGenerales
    {

        public Int32 validarEnteros(String value)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(value);
                return num;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            return num;
        }

        public Double validarDecimales(String value)
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(value);
                return num;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            return num;
        }

        protected Double ConvertirLibrasKilogramos(Double libras)
        {
            return libras * 0.453592;
        }

        protected Double ConvertirKilogramosLibras(Double kilogramos)
        {
            return kilogramos * 2.205;
        }

        public static List<ValoresLista> LlenarComboBoxGenero()
        {
            List<ValoresLista> genero = new List<ValoresLista>();
            genero.Add(new ValoresLista { valor = "0", miembro = "Seleccione una Opción" });
            genero.Add(new ValoresLista { valor = "2", miembro = "Femenino" });
            genero.Add(new ValoresLista { valor = "6", miembro = "Masculino" });
            return genero;
        }

        public static List<ValoresLista> LlenarComboBoxConversiones()
        {
            List<ValoresLista> genero = new List<ValoresLista>();
            genero.Add(new ValoresLista { valor = "0", miembro = "Seleccione una Opción" });
            genero.Add(new ValoresLista { valor = "1", miembro = "Libras a Kilogramos" });
            genero.Add(new ValoresLista { valor = "2", miembro = "Kilogramos a Libras" });
            return genero;
        }

    }
}
