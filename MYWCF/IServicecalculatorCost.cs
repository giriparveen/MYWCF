using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MYWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicecalculatorCost
    {
        [OperationContract]
        string GetTotalCost(ProductData objProductData);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ProductData
    {
        private int _intProductQty;
        private double _dblPerProductCost;
        private string _strProductName;

        [DataMember]
        public int ProductQuantity
        {
            get { return _intProductQty; }
            set { _intProductQty = value; }
        }
        [DataMember]
        public double PerProductCost
        {
            get { return _dblPerProductCost; }
            set { _dblPerProductCost=value; }
        }
        [DataMember]
        public string ProductName
        {
            get { return _strProductName; }
            set { _strProductName = value; }
        }



    }
}
