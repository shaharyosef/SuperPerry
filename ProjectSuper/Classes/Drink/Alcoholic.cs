using System;

namespace ProjectSuper
{
    [Serializable]
    class Alcoholic : Drink
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Drink:
        //      string flavor
        public Alcoholic(string name, double price, string flavor) : base(name, price, flavor)
        {
        }
    }
}