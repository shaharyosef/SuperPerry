using System;

namespace ProjectSuper
{
    [Serializable]
    public abstract class Vegan : Product{
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Own:
        //      string organic

        public string _organic;

        public Vegan(string name, double price, string organic) : base(name, price)
        {
            this._organic = organic;
        }
        public override string getQuantity()
        {
            return this._amnt.ToString();
        }
        public override string getSpecialVariable()
        {
            string sign;
            if (this._organic == "Organic")
                sign = " :D";
            else
                sign = " :(";
            return this._organic + sign;
        }
    }
}
