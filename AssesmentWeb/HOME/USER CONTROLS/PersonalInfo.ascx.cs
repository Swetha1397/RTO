using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.ProfileInformation;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class PersonalInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            ProfileInformationViewModel profileInformationViewModel = new ProfileInformationViewModel();
            profileInformationViewModel.FName = txtFirstName.Text;
            profileInformationViewModel.LName = txtLastName.Text;
            profileInformationViewModel.DOB = Convert.ToDateTime(txtDob.Text);
            profileInformationViewModel.AadharNo = long.Parse(txtAadhar.Text);
            profileInformationViewModel.Address = TextAreaAddress.Value;

        }

        public void GetGeographicDetail()
        {

        }
    }
}