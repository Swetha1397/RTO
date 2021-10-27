using BusinessLayer.LLR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.LLR;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class LLRRegistrationFInal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LLRViewModel lLRViewModel = new LLRViewModel();
            lLRViewModel.VehicleCategory = ddlVehicleCategory.Text;
            lLRViewModel.AadharNo = Convert.ToInt32( Session["LLRAadharNo"].ToString());
            LLROperation lLROperation = new LLROperation();
            string rtoNo = Session["RTONO"].ToString();
            
            lLRViewModel.LLRNo = lLROperation.GetRegNo(rtoNo);
            lLROperation.SaveLLR(lLRViewModel);

        }
    }
}