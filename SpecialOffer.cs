using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class SpecialOffer
    {
        private string OfferCode;
        private string OfferDesc;
        private double Discount;

        public string offerCode
        {
            get { return OfferCode; }
            set { OfferCode = value; }
        }
        public string offerDesc
        {
            get { return offerDesc; }
            set { offerDesc = value; }
        }
        public double discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public SpecialOffer(string code, string description, double discount)
        {
            OfferCode = code;
            OfferDesc = description;
            Discount = discount;
        }
        public override string ToString()
        {
            return $"Offer Code: {OfferCode}, Offer Desc: {OfferDesc}, Discount: {Discount}";
        }
    }
}
