using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Requests
{
    public class GeneralDepozitRequest
    {
        public string Denumire { get; set; }
        public int Locatie { get; set; }
        public string Phone { get; set; }
    }
}
