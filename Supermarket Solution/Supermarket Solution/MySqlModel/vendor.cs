//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySqlModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class vendor
    {
        public vendor()
        {
            this.products = new HashSet<product>();
            this.vendor_expenses = new HashSet<vendor_expenses>();
        }
    
        public int vendorId { get; set; }
        public string vendorName { get; set; }
    
        public virtual ICollection<product> products { get; set; }
        public virtual ICollection<vendor_expenses> vendor_expenses { get; set; }
    }
}
