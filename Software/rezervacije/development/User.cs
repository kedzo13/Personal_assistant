//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Funkcionalnost_prijave
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Nullable<int> Restaurant { get; set; }
        public string Type { get; set; }
    
        public virtual Restaurant Restaurant1 { get; set; }
        public virtual User_Type User_Type { get; set; }
    }
}