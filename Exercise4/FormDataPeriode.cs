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
    public partial class FormDataPeriode : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
       
        public FormDataPeriode()
        {
            InitializeComponent();
        }

        private void FormDataPeriode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'periodeDataSet.Periode' table. You can move, or remove it, as needed.
            this.periodeTableAdapter.Fill(this.periodeDataSet.Periode);



            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            buttonSave.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {//save
            dt = periodeDataSet.Tables["Periode"];
            dr = dt.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dt.Rows.Add(dr);
            periodeTableAdapter.Update(periodeDataSet);
            textBox1.Text = System.Convert.ToString(dr[0]);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            buttonAdd.Enabled = true;
            buttonSave.Enabled = false;

            MessageBox.Show("Data Berhasil Disimpan");


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            buttonSave.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            buttonAdd.Enabled = false;

            

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = textBox1.Text;
            dr = periodeDataSet.Tables["Periode"].Rows.Find(code);
            dr.Delete();
            periodeTableAdapter.Update(periodeDataSet);

            MessageBox.Show("Data Berhasil Dihapus");
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
