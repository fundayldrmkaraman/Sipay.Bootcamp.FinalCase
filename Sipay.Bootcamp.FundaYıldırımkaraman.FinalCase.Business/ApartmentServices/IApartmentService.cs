using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.ApartmentServices
{
    public interface IApartmentService
    {
        List<Apartment> GetAllApartments();
        Apartment GetApartmentById(int id);
        void AddApartment(Apartment apartment);
        void UpdateApartment(int id, Apartment updatedApartment);
        void DeleteApartment(int id);
    }
}
