//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_City
    {
        public int CITYID { get; set; }
        public string CITYNAME { get; set; }
        public Nullable<int> STATEID { get; set; }
    
        public virtual TBL_State TBL_State { get; set; }
    }
}
