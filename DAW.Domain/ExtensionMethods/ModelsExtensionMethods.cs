using DAW.Domain.Models;
using DAW.Domain.Requests;

namespace DAW.Domain.ExtensionMethods
{
    public static class ModelsExtensionMethods
    {
        public static Customer ToDTO(this GeneralCustomerRequest request)
        {
            return new Customer
            {
                Address = request.Address,
                BirthDate = request.BirthDate,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName
            };
        }

        public static Customer ToDTO(this GeneralCustomerRequest request, int id)
        {
            return new Customer
            {
                Address = request.Address,
                BirthDate = request.BirthDate,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Id = id
            };
        }

        public static Comanda ToDTO(this GeneralComandaRequest request)
        {
            return new Comanda
            {
                DataComanda = request.DataComanda,
                DataSosire = request.DataSosire,
                IsCancelled = request.IsCancelled,
                Suma = request.Suma
            };
        }

        public static Comanda ToDTO(this GeneralComandaRequest request, int id)
        {
            return new Comanda
            {
                DataComanda = request.DataComanda,
                DataSosire = request.DataSosire,
                IsCancelled = request.IsCancelled,
                Suma = request.Suma,
                Id = id
            };
        }

        public static Depozit ToDTO(this GeneralDepozitRequest request)
        {
            return new Depozit
            {
                Denumire = request.Denumire,
                Locatie = request.Locatie,
                Phone = request.Phone
            };
        }
        public static Depozit ToDTO(this GeneralDepozitRequest request, int id)
        {
            return new Depozit
            {
                Denumire = request.Denumire,
                Locatie = request.Locatie,
                Phone = request.Phone,
                Id = id
            };
        }
    }
}