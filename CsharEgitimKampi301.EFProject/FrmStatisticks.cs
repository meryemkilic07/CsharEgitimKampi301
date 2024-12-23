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
    public partial class FrmStatisticks : Form
    {
        public FrmStatisticks()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities1 db=new EgitimKampiEFTravelDbEntities1();

        private void FrmStatisticks_Load(object sender, EventArgs e)
        {
            FrmStatisticks_Load(sender, e, lblRomeGuideName);
        }

        private void FrmStatisticks_Load(object sender, EventArgs e, Label lblRomeGuideName)
        {
            lblLocationCount.Text=db.Location.Count().ToString();
            lblSumCapacity.Text=db.Location.Sum(x=>x.Capacity).ToString();
            lblGuideCount.Text   =db.Guide.Count().ToString();
            lblAvgCapacity.Text=db.Location.Average(x=>x.Capacity).ToString();
            lblAvgLocationPrice.Text=db.Location.Average(x=>x.Price).ToString();
            int LastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == LastCountryId).Select(y => y.Country).FirstOrDefault();
            lblCapadokiaLocationCapacity.Text=db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

            var romeGuideId=db.Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
           
            
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
                
            var maxCapacity=db.Location.Max(x=>x.Capacity);
              lblMaxCapacityLocation.Text =db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
                var maxPrice=db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            var guideIdByNameAysegulCinar=db.Guide.Where(x=>x.GuideName=="Ayşegül"&& x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault().ToString();
              
            
            lblAyşegülCınarLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameAysegulCinar).Count().ToString();
                

                

        }

        private void lblLastCountryName_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
