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
    public partial class EscolhaTemaVista : Form
    {
        public EscolhaTemaVista()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            main.ActiveForm.WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.TemaCorVista = "BLUE";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
            
           


        }

        private void btn_propCoffee_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "COFFEE";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void btn_PropLight_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "LIGHT";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void btn_PropOcean_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "OCEAN";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void btn_PropSunrise_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "SUNRISE";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void btn_PropMidnight_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "MIDNIGHT";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void btn_PropEctoplasm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaCorVista = "ECTOPLASM";
            Form f = new PropsTema();
            f.MdiParent = main.ActiveForm;
            f.Show();
            this.Close();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EscolhaTemaVista_Load(object sender, EventArgs e)
        {
            Point p = new Point(0, 0);
            this.Location = p;
        }
    }
}
