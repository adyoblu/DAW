using DAW.Domain.Models.BaseModels;
using System;

namespace DAW.Domain.Models
{
    public class Comanda : BaseEntity
    {
        public DateTime DataComanda { get; set; }
        public DateTime DataSosire { get; set; }
        public bool IsCancelled { get; set; }
        public int Suma { get; set; }
        public virtual Item Item { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Depozit Depozit { get; set; }
    }
}