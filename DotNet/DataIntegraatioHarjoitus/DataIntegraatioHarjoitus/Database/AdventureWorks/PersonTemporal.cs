﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataIntegraatioHarjoitus.Database.AdventureWorks
{
    public partial class PersonTemporal
    {
        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
    }
}
