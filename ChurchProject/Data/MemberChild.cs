//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChurchProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberChild
    {
        public int MemberChildId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public int MemberId { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
