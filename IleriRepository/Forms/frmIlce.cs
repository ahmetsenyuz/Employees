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
    public partial class frmIlce : Form
    {
        public frmIlce()
        {
            InitializeComponent();
        }
        CountyRepository counRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        County selCoun;
        private void frmIlce_Load(object sender, EventArgs e)
        {
            Doldur();
            cbDoldur();
        }

        private void cbDoldur()
        {
            comboBox1 = cityRep.GetCombobox(comboBox1);
        }

        private void Doldur()
        {
            dataGridView1.DataSource = counRep.GetOption();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selCoun = counRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text = selCoun.Name;
            comboBox1.SelectedValue = selCoun.CityId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            County newCoun = new County();
            newCoun.Name = textBox1.Text;
            newCoun.CityId = (int)comboBox1.SelectedValue;
            counRep.Add(newCoun);
            counRep.Update();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            counRep.Delete(selCoun);
            counRep.Update();
            Doldur();
        }

        private void btnDuzen_Click(object sender, EventArgs e)
        {
            selCoun.CityId = (int)comboBox1.SelectedValue;
            selCoun.Name = textBox1.Text;
            counRep.Update();
            Doldur();
        }
    }
}
