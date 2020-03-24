using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem6_paw
{
    public partial class Form2 : Form
    {
        float procentDobanda = 0.15f;
        float gradIndatorare = 0.7f;
        List<Credit> listaCredite = new List<Credit>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Introduceti suma!");
            else
                if (tbVenit.Text == "")
                    errorProvider1.SetError(tbVenit, "Introduceti venitul!");
                else
                    if (tbPerioada.Text == "")
                        errorProvider1.SetError(tbPerioada, "Introduceti perioada!");
                    else
                    {
                        try
                        {
                            int suma = Convert.ToInt32(tbSuma.Text);
                            int perioada = Convert.ToInt32(tbPerioada.Text);
                            int venit = Convert.ToInt32(tbVenit.Text);
                            float creditMax = venit * perioada * 12 * gradIndatorare * (1 + procentDobanda);
                            if (suma > creditMax)
                                MessageBox.Show("Suma ceruta e prea mare!");
                            else
                            {
                                float rata = suma / perioada / 12 * (1 + procentDobanda);
                                tbRata.Text = rata.ToString();
                                Credit c = new Credit(suma, perioada, procentDobanda, rata);
                                listaCredite.Add(c);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            errorProvider1.Clear();
                        }
                    }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbPerioada.Text = vScrollBar1.Value.ToString();
        }

        private void tbPerioada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vScrollBar1.Value = Convert.ToInt32(tbPerioada.Text);
            }
            catch
            {
                vScrollBar1.Value = 1;
            }
        }

        private void procentDobandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                procentDobanda = 0.12f;
            else
                procentDobanda = 0.15f;
            MessageBox.Show("Dobanda este " + procentDobanda);
        }

        private void gradIndatorareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("Selectati starea civila!");
            else
            {
                if (radioButton1.Checked == true)
                    gradIndatorare = 0.5f;
                else
                    if (radioButton2.Checked == true)
                        gradIndatorare = 0.7f;
                MessageBox.Show("Grad indatorare este " + gradIndatorare);
            }
        }
    }
}
