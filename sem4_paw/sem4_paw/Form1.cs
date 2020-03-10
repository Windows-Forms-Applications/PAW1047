using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem4_paw
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                char sex = Convert.ToChar(cbSex.Text);
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string nume = tbNume.Text;
                string[] noteS = tbNote.Text.Split(',');
                int[] note = new int[noteS.Length];
                for (int i = 0; i < noteS.Length; i++)
                    note[i] = Convert.ToInt32(noteS[i]);
                Student s = new Student(cod, sex, varsta, nume, note);
                listaStud.Add(s);
                MessageBox.Show(s.ToString());
                functiaMea(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //tbCod.Clear();
                //tbVarsta.Clear();
                //cbSex.Text = "";
                //tbNume.Clear();
                //tbNote.Clear();
                functiaMea(this, e);
            }
        }

        private void functiaMea(object sender, EventArgs e)
        {
            tbCod.Clear();
            tbVarsta.Clear();
            cbSex.Text = "";
            tbNume.Clear();
            tbNote.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.Show();
        }
    }
}
