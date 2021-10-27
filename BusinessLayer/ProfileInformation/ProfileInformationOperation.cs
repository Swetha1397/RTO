using DataModel_Layer.ProfileInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.ProfileInformation;

namespace BusinessLayer.ProfileInformation
{
    public class ProfileInformationOperation
    {
        public void RTOProfileInformation(ProfileInformationViewModel profileInformationViewModel)
        {
            ProfileInformationDataModel profileInformationDataModel = new ProfileInformationDataModel();
            profileInformationViewModel.FName = profileInformationDataModel.FName;
            profileInformationViewModel.LName = profileInformationDataModel.LName;
            profileInformationViewModel.DOB = profileInformationDataModel.DOB;
            profileInformationViewModel.AadharNo = profileInformationDataModel.AadharNo;
            profileInformationViewModel.Address = profileInformationDataModel.Address;
        }
    }
}
