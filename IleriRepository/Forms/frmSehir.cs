using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Forms
{
    public partial class frmSehir : Form
    {
        public frmSehir()
        {
            InitializeComponent();
        }
        CityRepository cityRep = new CityRepository();
        City selCity;
        private void frmSehir_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = cityRep.GetOption();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selCity = cityRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text = selCity.Name;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            City newCity = new City();
            newCity.Name = textBox1.Text;
            cityRep.Add(newCity);
            cityRep.Update();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cityRep.Delete(selCity);
            cityRep.Update();
            Doldur();
        }

        private void btnDuzen_Click(object sender, EventArgs e)
        {
            selCity.Name = textBox1.Text;
            cityRep.Update();
            Doldur();
        }
    }
}
