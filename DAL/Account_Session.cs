//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gradera.Core.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account_Session
    {
        public string Token { get; set; }
        public int AccountId { get; set; }
        public System.DateTime LoginDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
