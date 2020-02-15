using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Requests
{
    public class GeneralComandaRequest
    {
        public DateTime DataComanda { get; set; }
        public DateTime DataSosire { get; set; }
        public bool IsCancelled { get; set; }
        public int Suma { get; set; }
    }
}
