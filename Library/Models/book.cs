//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public int Ranking { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Nullable<int> Sales { get; set; }
        public string Imprint { get; set; }
        public string Publisher { get; set; }
        public Nullable<int> YearPublished { get; set; }
        public string Genre { get; set; }
        public int Status { get; set; }
        public int Borrower { get; set; }
    }
}
