using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEg.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                Fullname = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "Fullname";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var location = db.Location.Find(id);
            db.Location.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Location deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            var location = db.Location.Find(id);
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Location updated successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            var location = db.Location.Find(id);
            txtCity.Text = location.City;
            txtCountry.Text = location.Country;
            txtDayNight.Text = location.DayNight;
            txtPrice.Text = location.Price.ToString();
            nudCapacity.Value = byte.Parse(location.Capacity.ToString());
            cmbGuide.SelectedValue = location.GuideId;
        }
    }
}
