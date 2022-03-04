using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Concrete;

namespace IleriRepository.Forms
{
    public partial class frmEgitim : Form
    {
        public frmEgitim()
        {
            InitializeComponent();
        }
        EduRepository eduRep = new EduRepository();
        Education selEdu;
        private void frmEgitim_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = eduRep.GetOption();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selEdu = eduRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text = selEdu.Name;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Education newEdu = new Education();
            newEdu.Name = textBox1.Text;
            eduRep.Add(newEdu);
            eduRep.Update();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            eduRep.Delete(selEdu);
            eduRep.Update();
            Doldur();
        }

        private void btnDuzen_Click(object sender, EventArgs e)
        {
            selEdu.Name = textBox1.Text;
            eduRep.Update();
            Doldur();
        }
    }
}
