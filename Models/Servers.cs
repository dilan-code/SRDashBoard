using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SrDashboard_SR.Models
{
    public partial class Servers
    {
        public long Id { get; set; }
        public string Servername { get; set; }
        public string Ipadress { get; set; }
        public string ServiceName { get; set; }
        public bool? ServiceStatus { get; set; }
        public byte[] DateTime { get; set; }
        public string ServerFqdn { get; set; }
    }
}
