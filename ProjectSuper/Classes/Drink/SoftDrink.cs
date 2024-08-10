using System;

namespace ProjectSuper
{
    [Serializable]
    public class SoftDrink : Drink
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Drink:
        //      string flavor
        public SoftDrink(string name, double price , string flavor) : base(name, price, flavor)
        {
        }
    }
}