using System;
using System.Collections.Generic;

#nullable disable

namespace DataIntegraatioHarjoitus.Database.AdventureWorks
{
    public partial class VEmployeePersonTemporalInfo
    {
        public int BusinessEntityId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
    }
}
