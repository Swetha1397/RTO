using DataModel_Layer.ProfileInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ProfileInformation
{
    public class ProfileInformationDataOperation
    {
        public void SaveProfile(ProfileInformationDataModel profileInformationDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertProfileInformation", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@FName", SqlDbType.VarChar);
            parameter1.Value = profileInformationDataModel.FName;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@LName", SqlDbType.VarChar);
            parameter2.Value = profileInformationDataModel.LName;
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@DOB", SqlDbType.Date);
            parameter3.Value = profileInformationDataModel.DOB;
            command.Parameters.Add(parameter3);
            SqlParameter parameter4 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter4.Value = profileInformationDataModel.AadharNo;
            command.Parameters.Add(parameter4);
            SqlParameter parameter5 = new SqlParameter("@Address", SqlDbType.VarChar);
            parameter5.Value = profileInformationDataModel.Address;
            command.Parameters.Add(parameter5);



            command.ExecuteNonQuery();
            sqlConnection.Close();
           
        }
    }
}
