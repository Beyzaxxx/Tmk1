//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int id { get; set; }
        public string head { get; set; }
        public string description { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string deleteDate { get; set; }
        public string photo { get; set; }
        public Nullable<bool> checkControl { get; set; }
        public Nullable<int> adminId { get; set; }
    
        public virtual Admin Admin { get; set; }
    }
}
