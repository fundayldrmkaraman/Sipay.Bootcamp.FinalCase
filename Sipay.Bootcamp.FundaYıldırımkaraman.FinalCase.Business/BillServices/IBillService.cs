using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.BillServices
{
    public interface IBillService
    {
        void AddBill(Bill bill);
        void UpdateBill(int id, Bill bill);
        void DeleteBill(int id);
        Bill GetBillById(int id);
        List<Bill> GetAllBills();
    }
}
