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
    public partial class FormDataNilai : Form
    {
        public FormDataNilai()
        {
            InitializeComponent();
        }

        private void FormDataNilai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTINilaiDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTINilaiDataSet.Nilai);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
