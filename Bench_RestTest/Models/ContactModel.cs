using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bench_RestTest.Models
{
    public class ContactModel
    {
        public DateTime Date { get; set; }
        public string Ledger { get; set; }
        public string Amount { get; set; }
        public string Company { get; set; }
    }
}