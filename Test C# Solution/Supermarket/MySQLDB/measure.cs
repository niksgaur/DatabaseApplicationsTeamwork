//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySQLDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class measure
    {
        public measure()
        {
            this.products = new HashSet<product>();
        }
    
        public int measureId { get; set; }
        public string measureName { get; set; }
    
        public virtual ICollection<product> products { get; set; }
    }
}
