using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopEX
{
    public partial class ExeL : Form
    {
        public ExeL()
        {
            InitializeComponent();
        }
        int I;
        
        
        private void ExeL_Load(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num, x, Y;

            num = Convert.ToInt32(txtNum.Text);

            I = num - 1;

            x = num * I;


            txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());


            while (I > 1)
            {
                I--;

                x = x * I;

                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());

            }


        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num, x, Y;

            num = Convert.ToInt32(txtNum.Text);
            I = num - 1;

            x = num * I;

            txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());

            for (I = num - 2; I > 0; I--)
            {
                x = x * I;

                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
        }

        private void btnDWhile_Click(object sender, EventArgs e)
        {
            int num, x, Y;

            num = Convert.ToInt32(txtNum.Text); 

            I = num - 1;

            x = num * I;

            txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());


            do
            {
                I--;
                
                x = I * x;                                

                txtResult.Text = String.Concat(txtResult.Text, "\r\n", x.ToString());

            } while (I > 1);

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
