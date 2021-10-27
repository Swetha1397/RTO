using DataLayer.Licence;
using DataModel_Layer.Licence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.Licence;

namespace BusinessLayer.Licence
{
    public class LicenceOperation
    {
        public int SaveLicence(LicenceViewModel licenceViewModel)
        {
            LicenceDataModel licenceDataModel = new LicenceDataModel();
            licenceDataModel.LLRNo = licenceViewModel.LLRNo;
            LicenceDataOperation licenceDataOperation = new LicenceDataOperation();
            int Verify=licenceDataOperation.SaveLicenceDetails(licenceDataModel);
            return Verify;

        }
    }
}
