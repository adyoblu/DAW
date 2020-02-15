using DAW.Domain.Models.BaseModels;
using System.Collections.Generic;

namespace DAW.Domain.Models
{
    public class Depozit : BasePerson
    {
        public int Locatie { get; set; }
        public string Denumire { get; set; }
    }
}
