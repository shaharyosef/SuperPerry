using System;

namespace ProjectSuper
{
    [Serializable]
    class Fruits : Vegan
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Vegan:
        //      string organic

        public Fruits(string name, double price, string organic) : base(name, price, organic)
        {
        }
    }
}