//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManger.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupUser
    {
        public long UserID { get; set; }
        public long GroupID { get; set; }
        public long ID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreationDate { get; set; }
        public bool Active { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
