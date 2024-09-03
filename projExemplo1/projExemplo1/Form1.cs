using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projExemplo1
{
    public partial class Form1 : Form
    {
        private Button btnOK;
        private Label lblTexto;
        private TextBox txtTexto;
        private CheckBox[] caixinhas;

        public Form1()
        {
            InitializeComponent();
            InitializeMyComponents();
            InitializeLittleBoxes();
        }

        private void InitializeLittleBoxes()
        {
            caixinhas = new CheckBox[5];
            for(int i=0; i<5; ++i)
            {
                caixinhas[i] = new CheckBox();
                caixinhas[i].Parent = this;
                caixinhas[i].Top = 25*(i+1);
                caixinhas[i].Left = 200;
                caixinhas[i].Text = "Caixa " + (i+1).ToString();
                caixinhas[i].Checked = (i % 2 == 0);
                caixinhas[i].Click += new EventHandler(click);
            }
        }

            private void InitializeMyComponents()
        {
            btnOK = new Button();
            lblTexto = new Label();
            txtTexto = new TextBox();
            btnOK.Parent = this;
            lblTexto.Parent = this;
            txtTexto.Parent = this;
            btnOK.Left = 50;
            btnOK.Top = 150;
            txtTexto.Left = 50;
            txtTexto.Top = 50;
            lblTexto.Left = 50;
            lblTexto.Top = 100;
            btnOK.Text = "OK";
            btnOK.Click += new EventHandler(clicouNoOK);
        }

        private void click(object sender, EventArgs e)
        {
            /*
            if (((CheckBox)sender).Checked)
                lblTexto.Text = "SIM";
            else
                lblTexto.Text = "NÂO";
            */
            lblTexto.Text = (((CheckBox)sender).Checked) ? "SIM" : "NÂO";

        }

        private void clicouNoOK(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
        }

            private void clicouNoBotao(object sender, EventArgs e)
        {

            /*
            if (sender == button1)
                label1.Text = "Veio do Button1";
            else  
                label1.Text = "Veio do Button2";
            */
            label1.Text = "Veio do " + ((Button)sender).Text;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
