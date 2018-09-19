using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MEDIDAS md = new MEDIDAS();
            md.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.labpsicolinguistica.psicol.unam.mx/Base/index.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.labpsicolinguistica.psicol.unam.mx/Base");
        }

       

        
    }
}
