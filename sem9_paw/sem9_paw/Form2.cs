using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem9_paw
{
    public partial class Form2 : Form
    {
        int y = 10;

        Student[] vectStud = { new Student(21, "Gigel", 10),
                                 new Student(22, "Dorel", 8),
                                 new Student(23, "Marcel", 9)};

        string[] nume = new string[3];

        public Form2()
        {
            InitializeComponent();

            for (int i = 0; i < vectStud.Length; i++)
                listBox1.Items.Add(vectStud[i].ToString());

            for (int i = 0; i < vectStud.Length; i++)
                nume[i] = vectStud[i].nume;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if(((e.KeyState & 8)==8) && (e.AllowedEffect & DragDropEffects.Copy)==DragDropEffects.Copy)
                 e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (y > panel1.Height)
            {
                MessageBox.Show("Cosul e plin!");
                panel1.Invalidate();
                y = 10;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listBox1.Items.Count>0)
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            foreach (Student s in vectStud)
                if (text == s.nume)
                    listBox1.Items.Add(s.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.DataSource = nume;
            listBox1.DataSource = nume;

            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            for (int i = 0; i < nume.Length; i++)
                dt.Rows.Add(nume[i]);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Nume";

            dataGridView1.DataSource = dt;
        }


    }
}
