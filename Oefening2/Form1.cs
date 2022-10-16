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
        Stapel<String> listString = new Stapel<String>();
        Stapel<TestClass> listObj = new Stapel<TestClass>();

        private void btn_toevoegen_int_Click(object sender, EventArgs e)
        {
            int int_var = int.Parse(tb_int.Text);

            listInt.voegToe(int_var);

        }

        private void btn_verwijderen_int_Click(object sender, EventArgs e)
        {
            int removedInt = listInt.Verwijderen();
            MessageBox.Show("Verwijderde int: " + removedInt.ToString());
        }

        private void btn_leegmaken_int_Click(object sender, EventArgs e)
        {
           listInt.Leegmaken();
            MessageBox.Show("De stapel werd leeg gemaakt.");
        }

        private void btn_toon_int_Click(object sender, EventArgs e)
        {
            tb_res_int.Text = listInt.ToString();
            MessageBox.Show(tb_res_int.Text = listInt.ToString());
        }

        private void btn_aanwezig_int_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tb_int.Text);
            bool aanwezig = listInt.isAanwezig(x);
            MessageBox.Show(aanwezig.ToString());
        }

        private void btn_copy_int_Click(object sender, EventArgs e)
        {
            Stapel<int> listInt_copy = new Stapel<int>();
            listInt_copy = listInt.Copy();
            MessageBox.Show(listInt_copy.ToString());
        }

        private void btn_toevoegen_str_Click(object sender, EventArgs e)
        {
            listString.voegToe(tb_str.Text);
        }

        private void btn_verwijderen_str_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verwijderde int: " + listString.Verwijderen().ToString());
        }

        private void btn_leegmaken_str_Click(object sender, EventArgs e)
        {
            listString.Leegmaken();
            MessageBox.Show("De stapel werd leeg gemaakt.");
        }

        private void btn_toon_str_Click(object sender, EventArgs e)
        {
            tb_res_string.Text = listString.ToString();
            MessageBox.Show(tb_res_string.Text = listString.ToString());
        }

        private void btn_aanwezig_str_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listString.isAanwezig(tb_str.Text).ToString());
        }

        private void btn_copy_str_Click(object sender, EventArgs e)
        {
            Stapel<String> listString_copy = new Stapel<String>();
            listString_copy = listString.Copy();
            MessageBox.Show(listString_copy.ToString());
        }

        private void btn_toevoegen_obj_Click(object sender, EventArgs e)
        {
            listObj.voegToe(new TestClass(tb_obj.Text));
        }

        private void btn_verwijderen_obj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listObj.Verwijderen().ToString());
        }

        private void btn_leegmaken_obj_Click(object sender, EventArgs e)
        {
            listObj.Leegmaken();
            MessageBox.Show("De stapel werd leeg gemaakt.");
        }

        private void btn_toon_obj_Click(object sender, EventArgs e)
        {
            tb_res_obj.Text = listObj.ToString();
            MessageBox.Show(tb_res_obj.Text = listObj.ToString());
        }

        private void btn_aanwezig_obj_Click(object sender, EventArgs e)
        {
            TestClass test = new TestClass(tb_obj.Text);
            bool aanwezig = listObj.isAanwezig(test);
            MessageBox.Show(aanwezig.ToString());

        }

        private void btn_copy_obj_Click(object sender, EventArgs e)
        {
            Stapel<TestClass> listObj_copy = new Stapel<TestClass>();
            listObj_copy = listObj.Copy();
            MessageBox.Show(listObj_copy.ToString());
        }
    }
}