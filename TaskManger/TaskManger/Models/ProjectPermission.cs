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
    
    public partial class ProjectPermission
    {
        public int ID { get; set; }
        public Nullable<long> GroupRoleID { get; set; }
        public string Permission { get; set; }
        public long ProjectID { get; set; }
    
        public virtual GroupRole GroupRole { get; set; }
        public virtual Project Project { get; set; }
    }
}
