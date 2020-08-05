using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubExperiment
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               label1.Text = "Welcome to GitHub and Git.\nThis program will show some examples of using the repositories\n" +
                    "and interfacing Git and GitHub with Visual Studio\n" +
                    "Enjoy learning!\n" +
                    "About Branches and More in Github";
               pictureBox1.Show();
               timer1.Stop();
               timer1.Start();
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               label1.Text = "";
               pictureBox1.Hide();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               label1.Text = "";
               pictureBox1.Hide();
          }
     }
}
