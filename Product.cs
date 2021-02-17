using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchNamespace;


class Product : Merch
{
    public Product(string _name, float _price, string _date) : base(_name,_price)
    {
        date = _date;
    }

    public override string GetOutPut()
    {
        output = base.GetOutPut();
        output += " Дата изготовления: " + date + " Количество объектов: " + number_of_merch;
        return output;
    }
}