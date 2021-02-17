using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchNamespace;


class Toy : Merch
{
    public Toy(string _name,float _price, string _date, string _age):base(_name,_price)
    {
        age = _age;
    }

    public override string GetOutPut()
    {
        output = base.GetOutPut();
        output += " Ограничение по возрасту: " + age + " + Количество объектов: " + number_of_merch;
        return output;
    }   
}