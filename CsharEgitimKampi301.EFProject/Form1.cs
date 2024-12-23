using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {
           
            var values = db.Guide.ToList();
                dataGridView1.DataSource = values;//datagridteki bilgileri listeleyecek
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text; 
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("rehber başarıyla eklendi");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("başarı bil şekilde silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName= txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("başarıyla güncellendi","uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId ==id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
