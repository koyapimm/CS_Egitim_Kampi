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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            
            var avgCapacity = db.Location.Average(x => x.Capacity);
            lblAverageCapacity.Text = String.Format("{0:N2}", avgCapacity);

            var avgPrice = db.Location.Average(x => x.Price);
            lblAveragePrice.Text = String.Format("{0:C2}", avgPrice);

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = String.Format("{0:N2}", db.Location.Where(x => x.Country == "Turkiye").Average(y => y.Capacity));

            lblRomeGuideName.Text = db.Location.Where(x => x.City == "Roma").Select(y => y.Guide.GuideName + " " + y.Guide.GuideSurname).FirstOrDefault();

            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == db.Location.Max(y => y.Capacity)).Select(z => z.City).FirstOrDefault();

            //En pahalı turun adı
            lblMaxPriceTour.Text = db.Location.Where(x => x.Price == db.Location.Max(y => y.Price)).Select(z => z.City).FirstOrDefault();

            int aysecinarid = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAyseCinarTourCount.Text = db.Location.Where(x => x.GuideId == aysecinarid).Count().ToString();
        }
    }
}
