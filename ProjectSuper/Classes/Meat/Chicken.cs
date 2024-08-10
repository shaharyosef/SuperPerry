using System;

namespace ProjectSuper
{
    [Serializable]
    public class Chicken : Meat
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Meat:
        //      string cutType

        public Chicken(string name, double price, string cutType) : base(name, price, cutType)
        {
        }
    }
}