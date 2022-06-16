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
    public partial class FormDataMahasiswa : Form
    {
        public FormDataMahasiswa()
        {
            InitializeComponent();
        }

        private void FormDataMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIMahasiswaDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIMahasiswaDataSet.Mahasiswa);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
