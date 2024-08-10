using System;

namespace ProjectSuper
{
    [Serializable]
    class Vegetables : Vegan
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Vegan:
        //      string organic

        public Vegetables(string name, double price, string organic) : base(name, price,organic)
        {
        }
    }
}