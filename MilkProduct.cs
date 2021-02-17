using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchNamespace;


class MilkProduct : Product
{
    public MilkProduct(string _name, float _price,string _date, string _expiration_date) :base(_name, _price,_date)
    {
        expiration_date = _expiration_date;
    }

    public override string GetOutPut() 
    {
        output = base.GetOutPut();
        output += " Срок годности: " + expiration_date + " Дней";
        return output;
    }
}