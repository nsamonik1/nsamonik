using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsamonik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float polumjer = 0;
            float povrsina = 0;
            float opseg = 0;

            float.TryParse(txtPolumjer.Text, out polumjer);
            if (polumjer > 0)
            {
                povrsina = polumjer * polumjer * (float)Math.PI;
                opseg = 2 * polumjer * (float)Math.PI;
                txtPovrsina.Text = povrsina.ToString();
                txtOpseg.Text = opseg.ToString();
                novaMetoda(polumjer);
            }
            
        }

        private void novaMetoda(float polumjer)
        {
            if (chkSpremi.Checked == true) lstRezultati.Items.Add(polumjer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstRezultati.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstRezultati_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;
            float.TryParse(lstRezultati.SelectedItem.ToString(), out polumjer);
            txtPolumjer.Text = polumjer.ToString();
            novaMetoda(polumjer);
        }
    }
}
