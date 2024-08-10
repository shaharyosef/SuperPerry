using System;

namespace ProjectSuper
{
    [Serializable]
    class Wine : Drink
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Drink:
        //      string flavor
        public Wine(string name, double price, string flavor) : base(name, price, flavor)
        {
        }
    }
}