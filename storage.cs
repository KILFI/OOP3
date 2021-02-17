using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchNamespace;


namespace StorageNamespace
{
    class Storage
    {
        static List<Merch> product_storage = new List<Merch>();
        static List<Merch> toy_storage = new List<Merch>();
        static List<Merch> milk_product_storage = new List<Merch>();

        public List<Merch> Get_Product()
        {
            return product_storage;
        }

        public List<Merch> Get_Toy()
        {
            return toy_storage;
        }

        public List<Merch> Get_Milk_Product()
        {
            return milk_product_storage;
        }
    }
}

