using System;
using System.Collections.Generic;

#nullable disable

namespace DataIntegraatioHarjoitus.Database.AdventureWorks
{
    public partial class AwbuildVersion
    {
        public byte SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; }
        public DateTime VersionDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
