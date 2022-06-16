using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataMahasiswa formDataMahasiswa = new FormDataMahasiswa();
            formDataMahasiswa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataNilai formDataNilai = new FormDataNilai();
            formDataNilai.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataPeriode formDataPeriode = new FormDataPeriode();
            formDataPeriode.Show();
        }
    }
}
