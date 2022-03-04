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
    public partial class frmEgitmen : Form
    {
        public frmEgitmen()
        {
            InitializeComponent();
        }
        LecRepository lecRep = new LecRepository();
        CityRepository cityRep = new CityRepository();
        CountyRepository counRep = new CountyRepository();
        EduRepository eduRep = new EduRepository();
        Lecturer selLec;
        private void frmEgitmen_Load(object sender, EventArgs e)
        {
            Doldur();
            cbDoldur();
            cbDoldur(1);
        }

        private void cbDoldur(int v)
        {
            counRep.GetCombobox(comboBox2, v);
        }

        private void cbDoldur()
        {
            comboBox1 = cityRep.GetCombobox(comboBox1);
            eduRep.GetCombobox(cbEgitim);
        }

        private void Doldur()
        {
            dataGridView1.DataSource = lecRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selLec = lecRep.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            txtHead.Text = selLec.GetTitle() + " " + "(" + selLec.GetAge() + ")";
            txtId.Text = selLec.Id.ToString();
            txtAd.Text = selLec.Name;
            txtSoyad.Text = selLec.Surname;
            txtMaas.Text = selLec.Salary.ToString();
            txtMah.Text = selLec.Avenue;
            txtSokak.Text = selLec.Street;
            txtNo.Text = selLec.HouseNumber;
            txtBrans.Text = selLec.Branch;
            txtUnvan.Text = selLec.AcademicTitle;
            dateTimePicker1.Value = selLec.DateofBirth;
            comboBox1.SelectedValue = selLec.County.CityId;
            comboBox2.SelectedValue = selLec.CountyId;
            cbEgitim.SelectedValue = selLec.EducationId;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbDoldur(Convert.ToInt32(comboBox1.SelectedValue));
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Lecturer neLec = new Lecturer();
            neLec.Name = txtAd.Text;
            neLec.Surname = txtSoyad.Text;
            neLec.Salary = Convert.ToDecimal(txtMaas.Text);
            neLec.Avenue = txtMah.Text;
            neLec.Street = txtSokak.Text;
            neLec.HouseNumber = txtNo.Text;
            neLec.AcademicTitle = txtUnvan.Text;
            neLec.Branch = txtBrans.Text;
            neLec.DateofBirth = dateTimePicker1.Value;
            neLec.CountyId = (int)comboBox2.SelectedValue;
            neLec.EducationId = (int)cbEgitim.SelectedValue;
            lecRep.Add(neLec);
            lecRep.Update();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lecRep.Delete(selLec);
            lecRep.Update();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            selLec.Name = txtAd.Text;
            selLec.Surname = txtSoyad.Text;
            selLec.Salary = Convert.ToDecimal(txtMaas.Text);
            selLec.Avenue = txtMah.Text;
            selLec.Street = txtSokak.Text;
            selLec.HouseNumber = txtNo.Text;
            selLec.AcademicTitle = txtUnvan.Text;
            selLec.Branch = txtBrans.Text;
            selLec.DateofBirth = dateTimePicker1.Value;
            selLec.CountyId = (int)comboBox2.SelectedValue;
            selLec.EducationId = (int)cbEgitim.SelectedValue;
            lecRep.Update();
            Doldur();
        }
    }
}
