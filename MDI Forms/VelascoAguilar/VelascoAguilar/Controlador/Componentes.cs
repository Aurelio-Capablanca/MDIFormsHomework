using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelascoAguilar.Controlador
{
    class Componentes
    {

        public Int32 validarEnteros(String value) {
            int num = 0;
            try
            {
                num = Convert.ToInt32(value);
                return num;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: "+ex.Message);
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


    }
}
