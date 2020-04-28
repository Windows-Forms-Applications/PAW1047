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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("Text pus in Clipboard!");
            Student s = new Student(22, "Gigel", 9.8f);
            Clipboard.SetDataObject(s);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            //g.DrawString(Clipboard.GetText(), this.Font, new SolidBrush(Color.Black), 10, 10);

            IDataObject o = Clipboard.GetDataObject();

            if(o.GetDataPresent(typeof(string)))
            {
                string text = o.GetData(typeof(string)).ToString();
                g.DrawString(text, this.Font, new SolidBrush(Color.Black), 10, 10);
            }
            else
                if (o.GetDataPresent(typeof(Bitmap)))
                {
                    Bitmap img = (Bitmap)o.GetData(typeof(Bitmap));
                    g.DrawImage(img, 0, 0);
                }
             else
                    if (o.GetDataPresent(typeof(Student)))
                    {
                        Student s1 = (Student)o.GetData(typeof(Student));
                        g.DrawString(s1.ToString(), this.Font, new SolidBrush(Color.Black), 10, 10);
                    }
        }
    }
}
