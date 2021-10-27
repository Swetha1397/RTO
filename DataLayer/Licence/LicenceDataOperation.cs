using DataModel_Layer.Licence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Licence
{
    public class LicenceDataOperation
    {
        public int SaveLicenceDetails(LicenceDataModel licenceDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("CheckLLR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@LLRNo", SqlDbType.VarChar);
            parameter1.Value = licenceDataModel.LLRNo;
            command.Parameters.Add(parameter1);
            int Verify = 0;

            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {

                Verify = Convert.ToInt32(rdr["Verification"]);

            }

            rdr.Close();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return Verify;

        }
    }
}
