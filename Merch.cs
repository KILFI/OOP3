using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageNamespace;


namespace MerchNamespace
{
    abstract class Merch
    {
        protected string age { get; set; } = "0";
        protected string expiration_date { get; set; } = "-";
        protected string date { get; set; } = "-";
        protected float price { get; set; } = 0;
        protected string name { get; set; } = "-";
        protected static int number_of_merch = 0;
        protected static string output { get; set; } = "-";
        
        protected Merch(string _name, float _price)
        {
            name = _name;
            price = _price;
            number_of_merch++;
        }

        public static void DeleteObject()
        {
            number_of_merch--;
        }

        public virtual string GetOutPut()
        {
            output = name + " Цена: " + Convert.ToString(price) + " руб."; 
            return output;
        }
    }
}