using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euromilhoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int nestrela = 0, nnumero = 0;
        private const string cruz = "x";
        private euromilhoes E = new euromilhoes();
        
        private void estrela(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.Estrela(Convert.ToInt32(tmp.Tag)-1);
            teste.Text = tmp.Tag.ToString();
        }

        private void numeros(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.Numeros(Convert.ToInt32(tmp.Tag)-1);
            teste.Text = E.listanum;

        }
    }
}