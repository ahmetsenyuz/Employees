using IleriRepository.Concrete;
using IleriRepository.Context;
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
    public partial class frmCalisan : Form
    {
        public frmCalisan()
        {
            InitializeComponent();
        }
        EmpRepository empRep = new EmpRepository();
        CityRepository cityRep = new CityRepository();
        EduRepository eduRep = new EduRepository();
        Employees selEmp;
        CountyRepository counRep = new CountyRepository();
        private void frmCalisan_Load(object sender, EventArgs e)
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
            cityRep.GetCombobox(comboBox1);
            eduRep.GetCombobox(cbEgitim);
        }

        private void Doldur()
        {
            dataGridView1.DataSource = empRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selEmp = empRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txtHead.Text = selEmp.GetTitle() + " " + "(" + selEmp.GetAge() + ")";
            txtId.Text = selEmp.Id.ToString();
            txtAd.Text = selEmp.Name;
            txtSoyad.Text = selEmp.Surname;
            txtMaas.Text = selEmp.Salary.ToString();
            txtMah.Text = selEmp.Avenue;
            txtSokak.Text = selEmp.Street;
            txtNo.Text = selEmp.HouseNumber;
            dateTimePicker1.Value = selEmp.DateofBirth;
            comboBox1.SelectedValue = selEmp.County.CityId;
            comboBox2.SelectedValue = selEmp.CountyId;
            cbEgitim.SelectedValue = selEmp.EducationId;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 1;
            try
            {
                a = Convert.ToInt32(comboBox1.SelectedValue);
            }
            catch (Exception)
            {
            }
            cbDoldur(a);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Employees newEmp = new Employees();
            newEmp.Name = txtAd.Text;
            newEmp.Surname = txtSoyad.Text;
            newEmp.Salary = Convert.ToDecimal(txtMaas.Text);
            newEmp.Avenue = txtMah.Text;
            newEmp.Street = txtSokak.Text;
            newEmp.HouseNumber = txtNo.Text;
            newEmp.DateofBirth = dateTimePicker1.Value;
            newEmp.CountyId = (int)comboBox2.SelectedValue;
            newEmp.EducationId = (int)cbEgitim.SelectedValue;
            empRep.Add(newEmp);
            empRep.Update();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            empRep.Delete(selEmp);
            empRep.Update();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            selEmp.Name = txtAd.Text;
            selEmp.Surname = txtSoyad.Text;
            selEmp.Salary = Convert.ToDecimal(txtMaas.Text);
            selEmp.Avenue = txtMah.Text;
            selEmp.Street = txtSokak.Text;
            selEmp.HouseNumber = txtNo.Text;
            selEmp.DateofBirth = dateTimePicker1.Value;
            selEmp.CountyId = (int)comboBox2.SelectedValue;
            selEmp.EducationId = (int)cbEgitim.SelectedValue;
            empRep.Update();
            Doldur();
        }
    }
}
