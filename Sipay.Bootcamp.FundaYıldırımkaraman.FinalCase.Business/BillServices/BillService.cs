using Microsoft.EntityFrameworkCore;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.FinalcaseDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.BillServices
{
    public class BillService:IBillService
    {
        private readonly FinalcaseDbContext _context;

        public BillService(FinalcaseDbContext context)
        {
            _context = context;
        }

        public void AddBill(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }

        public void UpdateBill(Bill bill)
        {
            _context.Bills.Update(bill);
            _context.SaveChanges();
        }

        public void DeleteBill(int id)
        {
            var bill = _context.Bills.Find(id);
            if (bill != null)
            {
                _context.Bills.Remove(bill);
                _context.SaveChanges();
            }
        }

        public Bill GetBillById(int id)
        {
            return _context.Bills.Include(b => b.Apartment).FirstOrDefault(b => b.Id == id);
        }

        public List<Bill> GetAllBills()
        {
            return _context.Bills.Include(b => b.Apartment).ToList();
        }

        public void UpdateBill(int id, Bill bill)
        {
            _context.Bills.Update(bill);
            _context.SaveChanges();
        }
    }
}
