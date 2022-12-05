using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GardenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string add(Product product);
        [OperationContract]
        string update(Product product);
        [OperationContract]
        string delete(Product product);
        //[OperationContract]
        //GetAllData getAllProduct();
        [OperationContract]
        List<Product> getAll();
        [OperationContract]
        Product get(int id);
    }
    [DataContract]
    public class Product
    {
        int id;
        string name;
        decimal price;



        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    
}
