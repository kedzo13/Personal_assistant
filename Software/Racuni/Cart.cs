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
    
    public partial class Cart
    {
        public int ID { get; set; }
        public int Narudzba { get; set; }
        public string NazivJela { get; set; }
        public int Cijena { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
