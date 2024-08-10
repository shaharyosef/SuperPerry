using System;

namespace ProjectSuper
{
    [Serializable]
    public class Beef : Meat
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Meat:
        //      string cutType

        public Beef(string name, double price, string cutType) : base(name, price,  cutType)
        {
        }
    }
}