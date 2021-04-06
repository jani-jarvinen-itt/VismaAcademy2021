using System;
using System.Collections.Generic;

#nullable disable

namespace DataIntegraatioHarjoitus.Database.AdventureWorks
{
    public partial class SpecialOfferProductInmem
    {
        public SpecialOfferProductInmem()
        {
            SalesOrderDetailInmems = new HashSet<SalesOrderDetailInmem>();
        }

        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductInmem Product { get; set; }
        public virtual SpecialOfferInmem SpecialOffer { get; set; }
        public virtual ICollection<SalesOrderDetailInmem> SalesOrderDetailInmems { get; set; }
    }
}
