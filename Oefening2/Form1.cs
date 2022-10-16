using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stapel<int> listInt = new Stapel<int>();

        private void btn_toevoegen_int_Click(object sender, EventArgs e)
        {
            listInt.voegToe(int.Parse(tb_int.Text));

        }

        private void btn_verwijderen_int_Click(object sender, EventArgs e)
        {
            int verwijder_int = listInt.Verwijderen();
            tb_int.Text = verwijder_int.ToString();
        }

        private void btn_leegmaken_int_Click(object sender, EventArgs e)
        {

        }
    }
}