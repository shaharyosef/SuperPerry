using System;

namespace ProjectSuper
{
    [Serializable]
    public abstract class Drink : Product
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Own:
        //      string flavor

        public string _flavor { get; set; }

        public Drink(string name, double price, string flavor): base(name, price)
        {
            this._flavor = flavor;
        }
        public override string getSpecialVariable()
        {
            string sign;
            if (this._flavor == "Very sweet")
                sign = " XD";
            else if (this._flavor == "Spicy")
                sign = " :X";
            else if (this._flavor == "Sweet")
                sign = " :D";
            else if (this._flavor == "Diet")
                sign = " :P";
            else if (this._flavor == "Disgusting")
                sign = " :$";
            else if (this._flavor == "Sweet and little bitter")
                sign = " :)";
            else
                sign = " :O";
            return this._flavor + sign;
        }
    }
}