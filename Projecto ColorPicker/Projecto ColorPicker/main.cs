using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_ColorPicker
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Point l = new Point(184, 37);
            Form f = new EscolhaTemaVista();
            f.MdiParent = this;
            f.Location = l;
            f.Show();
            f.BringToFront();
            
            //Form f2 = new PropsTema();
            //f2.MdiParent = this;
            //f2.Show();
            //f2.SendToBack();
        }

        private void btn_TemaPersonalizado_Click(object sender, EventArgs e)
        {
            Form f = new PersonalizarCor();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_Temas_Click(object sender, EventArgs e)
        {
            Form f = new EscolhaTemaVista();
            f.MdiParent = this;
            f.Show();
        }
    }
}
