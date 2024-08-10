using System;

namespace ProjectSuper
{
    [Serializable]
    class IceCream : Dairy
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Dairy
        //      string fat

        public IceCream(string name, double price, string fat) : base(name, price, fat)
        {
        }
    }
}