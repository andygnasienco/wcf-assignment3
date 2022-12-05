using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace agnasiencoA3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string DeleteVegDet(VegetableDetails vegetableDetails)
        {
            string Message;
            SqlConnection con = new SqlConnection("Server=DESKTOP-A6AL2TJ\\SQLEXPRESS2;Database=vegdb;User Id=sa;Password=admin123;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vegetable(veg_id, name) values(@veg_id, @name)", con);
            cmd.Parameters.AddWithValue("@veg_id", vegetableDetails.Veg_ID);
            cmd.Parameters.AddWithValue("@name", vegetableDetails.Name);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                Message = vegetableDetails.Name + "Details deleted successfully";
            }
            else
            {
                Message = vegetableDetails.Name = "Details not deleted successfully";
            }
            con.Close();
            return Message;
        }

        public List<VegetableDetails> GetVegetables()
        {
            List<VegetableDetails> vegetables = new List<VegetableDetails>();
            DataSet dataSet = new DataSet();
            SqlConnection con = new SqlConnection("Server=DESKTOP-A6AL2TJ\\SQLEXPRESS2;Database=vegdb;User Id=sa;Password=admin123;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from vegetable", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataSet);
            cmd.ExecuteNonQuery();
            con.Close();

            for (int row = 0; row < dataSet.Tables[0].Rows.Count; row++)
            {
                VegetableDetails vegetable = new VegetableDetails();
                vegetable.Veg_ID = Int32.Parse(dataSet.Tables[0].Rows[row][0].ToString());
                vegetable.Name = dataSet.Tables[0].Rows[row][1].ToString();
                vegetables.Add(vegetable);

            }

            return vegetables;
        }

        public string InsertVegDet(VegetableDetails vegetableDetails)
        {
            string Message;
            SqlConnection con = new SqlConnection("Server=DESKTOP-A6AL2TJ\\SQLEXPRESS2;Database=vegdb;User Id=sa;Password=admin123;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vegetable(veg_id, name) values(@veg_id, @name)", con);
            cmd.Parameters.AddWithValue("@veg_id", vegetableDetails.Veg_ID);
            cmd.Parameters.AddWithValue("@name", vegetableDetails.Name);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                Message = vegetableDetails.Name + "Details inserted successfully";
            }
            else
            {
                Message = vegetableDetails.Name = "Details not inserted successfully";
            }
            con.Close();
            return Message;

        }

        public string UpdateVegDet(VegetableDetails vegetableDetails)
        {
            string Message;
            SqlConnection con = new SqlConnection("Server=DESKTOP-A6AL2TJ\\SQLEXPRESS2;Database=vegdb;User Id=sa;Password=admin123;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vegetable(veg_id, name) values(@veg_id, @name)", con);
            cmd.Parameters.AddWithValue("@veg_id", vegetableDetails.Veg_ID);
            cmd.Parameters.AddWithValue("@name", vegetableDetails.Name);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                Message = vegetableDetails.Name + "Details updated successfully";
            }
            else
            {
                Message = vegetableDetails.Name = "Details not updated successfully";
            }
            con.Close();
            return Message;
        }
    }
}
