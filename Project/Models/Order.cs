//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int id { get; set; }
        public string Amount { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Card_Id { get; set; }
        public Nullable<int> Product_id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}