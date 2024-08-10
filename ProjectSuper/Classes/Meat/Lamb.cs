using System;

namespace ProjectSuper
{
    [Serializable]
    public class Lamb : Meat
    {
        //  Product:
        //      string name
        //      double price
        //      double amount 
        //      int serialNum
        //  Meat:
        //      string cutType

        public Lamb(string name, double price, string cutType) : base(name, price, cutType)
        {
        }
    }
}