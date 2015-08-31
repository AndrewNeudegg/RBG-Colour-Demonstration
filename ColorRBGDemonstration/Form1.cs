using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DecentColour_Mach2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            Color ccColor = Color.Black;
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                button1.BackColor = colorDialog1.Color;
                ccColor = colorDialog1.Color;
            }

            // Red v. Blue
            graph1.XAxisColor = Color.Red;
            graph1.YAxisColor = Color.Blue;
            graph1.PointColor = ccColor;
            //MessageBox.Show(String.Format("R:{0}, B:{1}", ccColor.R, ccColor.B));
            graph1.PointLocation = new Point(ccColor.R, ccColor.B);


            // Red v. Green
            graph2.XAxisColor = Color.Red;
            graph2.YAxisColor = Color.Green;
            graph2.PointColor = ccColor;
            //MessageBox.Show(String.Format("R:{0}, G:{1}", ccColor.R, ccColor.G));
            graph2.PointLocation = new Point(ccColor.R, ccColor.G);

            // Blue v. Green
            graph3.XAxisColor = Color.Blue;
            graph3.YAxisColor = Color.DarkGreen;
            graph3.PointColor = ccColor;
            //MessageBox.Show(String.Format("B:{0}, G:{1}", ccColor.B, ccColor.G));
            graph3.PointLocation = new Point(ccColor.B, ccColor.G);

            graph1.Invalidate();
            graph2.Invalidate();
            graph3.Invalidate();

            label1.Text = string.Format("RBG: ({0},{1},{2})", ccColor.R, ccColor.B, ccColor.G);
        }

        private void graph3_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/andrewneudegg");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://viz.aset.psu.edu/gho/sem_notes/color_2d/gifs/RGB_cube.gif");
        }
    }
}
