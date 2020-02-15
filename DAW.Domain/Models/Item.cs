using DAW.Domain.Models.BaseModels;

namespace DAW.Domain.Models
{
    public class Item : BasePerson
    {
        public string Denumire { get; set; }
        public int Pret { get; set; }
    }
}