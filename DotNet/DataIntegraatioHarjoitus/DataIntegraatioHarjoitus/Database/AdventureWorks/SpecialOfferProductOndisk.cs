using System;
using System.Collections.Generic;

#nullable disable

namespace DataIntegraatioHarjoitus.Database.AdventureWorks
{
    public partial class SpecialOfferProductOndisk
    {
        public SpecialOfferProductOndisk()
        {
            SalesOrderDetailOndisks = new HashSet<SalesOrderDetailOndisk>();
        }

        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductOndisk Product { get; set; }
        public virtual SpecialOfferOndisk SpecialOffer { get; set; }
        public virtual ICollection<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; set; }
    }
}
