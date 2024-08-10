using System;

namespace ProjectSuper
{
    [Serializable]
    public abstract class Dairy : Product
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Own:
        //      string fatContent

        public string _fatContent { get; set; }

        public Dairy(string name, double price, string fat) : base(name, price)
        {
            this._fatContent = fat;
        }
        public override string getQuantity()
        {
            return this._amnt.ToString();
        }
        public override string getSpecialVariable()
        {
            return this._fatContent + " % fat";
        }
    }
}
