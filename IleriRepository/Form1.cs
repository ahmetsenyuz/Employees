using IleriRepository.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void şehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehir frm = new frmSehir();
            frm.Show();
        }

        private void ilçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlce frm = new frmIlce();
            frm.Show();
        }

        private void eğitimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEgitim frm = new frmEgitim();
            frm.Show();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalisan frm = new frmCalisan();
            frm.Show();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenci frm = new frmOgrenci();
            frm.Show();
        }

        private void eğitmenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEgitmen frm = new frmEgitmen();
            frm.Show();
        }
    }
}
