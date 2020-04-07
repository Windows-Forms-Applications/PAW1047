using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace sem8_paw
{
    public partial class Form1 : Form
    {
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    vect[nrElem] = Convert.ToDouble(linie);
                    nrElem++;
                    vb = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                //Graphics g = this.CreateGraphics();
                //Graphics g = Graphics.FromHwnd(this.Handle);
                //Graphics g = Graphics.FromImage(bmp);

                Rectangle rect = new Rectangle(this.ClientRectangle.X + marg, this.ClientRectangle.Y + 4 * marg,
                    this.ClientRectangle.Width - 2 * marg, this.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }
               
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            panel1.Invalidate();
        }

        private void save(Control c, string fisier)
        {
            //Graphics gr = c.CreateGraphics();
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(fisier);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(panel1, "poza.bmp");
            MessageBox.Show("S-a salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                //Graphics g = this.CreateGraphics();
                //Graphics g = Graphics.FromHwnd(this.Handle);
                //Graphics g = Graphics.FromImage(bmp);

                Rectangle rect = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 2 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }

                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                //Graphics g = this.CreateGraphics();
                //Graphics g = Graphics.FromHwnd(this.Handle);
                //Graphics g = Graphics.FromImage(bmp);

                Rectangle rect = new Rectangle(e.PageBounds.X + marg, e.PageBounds.Y + 2*marg,
                    e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 3;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));
                }

                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
