//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kapoy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class activity
    {
        public int activity_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string activity_title { get; set; }
        public string activity_description { get; set; }
    
        public virtual activity activities1 { get; set; }
        public virtual activity activity1 { get; set; }
        public virtual user user { get; set; }
    }
}
