using DAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;

namespace DAW.Domain.Models
{
    public class Customer : BasePerson
    {
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string DateRegistered { get; set; }
        public virtual ICollection<Comanda> Comenzi { get; set; }
    }
}