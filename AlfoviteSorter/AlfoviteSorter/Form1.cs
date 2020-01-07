using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfoviteSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            Front Front = new Front(TextIn.Text);
            TextOut.Text = "";
            TextOut.Text += Front.TextOut()+ Environment.NewLine;
        }
    }
}