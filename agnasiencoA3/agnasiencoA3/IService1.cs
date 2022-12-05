using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace agnasiencoA3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertVegDet(VegetableDetails vegetableDetails);


        [OperationContract]
        List<VegetableDetails> GetVegetables();


        [OperationContract]
        string DeleteVegDet(VegetableDetails vegetableDetails);

        [OperationContract]
        string UpdateVegDet(VegetableDetails vegetableDetails);

    }

    public class VegetableDetails
    {
        int veg_id;
        string name = string.Empty;


        [DataMember]
        public int Veg_ID
        {
            get { return veg_id; }
            set { veg_id = value; }
        }


        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

}
