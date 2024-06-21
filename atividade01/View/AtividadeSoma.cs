using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade01.View
{
    public partial class AtividadeSoma : Form
    {
        public AtividadeSoma()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt16(txb_1.Text);
            int Valor2 = Convert.ToInt16(txb_2.Text);
            int Soma = Valor1 + Valor2;
            
            lbl_somar.Text = Soma.ToString();
        }
    }
}
