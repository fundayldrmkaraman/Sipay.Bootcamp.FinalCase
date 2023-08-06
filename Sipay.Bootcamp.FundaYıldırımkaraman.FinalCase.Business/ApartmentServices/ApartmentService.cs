using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.GenericRepository;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.ApartmentServices
{
    public class ApartmentService:IApartmentService
    {
        private readonly IGenericRepository<Apartment> _apartmentRepository;

        public ApartmentService(IGenericRepository<Apartment> apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public List<Apartment> GetAllApartments()
        {
            return _apartmentRepository.GetAll();
        }

        public Apartment GetApartmentById(int id)
        {
            return _apartmentRepository.GetById(id);
        }

        public void AddApartment(Apartment apartment)
        {
            _apartmentRepository.Add(apartment);
        }

        public void UpdateApartment(int id, Apartment updatedApartment)
        {
            var apartment = _apartmentRepository.GetById(id);
            if (apartment != null)
            {
                apartment.Block = updatedApartment.Block;
                apartment.IsOccupied = updatedApartment.IsOccupied;
                apartment.Floor = updatedApartment.Floor;
                apartment.Type = updatedApartment.Type;
                apartment.Number = updatedApartment.Number;
                apartment.OwnerOrTenant = updatedApartment.OwnerOrTenant;

                _apartmentRepository.Update(apartment);
            }
        }

        public void DeleteApartment(int id)
        {
            _apartmentRepository.Delete(id);
        }
    }
}
