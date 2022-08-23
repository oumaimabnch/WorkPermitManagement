using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPermitManagement.Models;

namespace WorkPermitManagement.Data.services
{
    public class PermitsService : IPermitsService

    {
        private readonly AppDbContext _context;
        public PermitsService(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<WorkPermit>> getAll()
        {
            var result = await _context.WorkPermits.ToListAsync();
            return result;
   
        }

        public WorkPermit getByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        void IPermitsService.Add(WorkPermit workPermit)
        {

        }

        void IPermitsService.delete(int id)
        {
            throw new NotImplementedException();
        }

        

        WorkPermit IPermitsService.getByid(int id)
        {
            throw new NotImplementedException();
        }

        WorkPermit IPermitsService.update(int id)
        {
            throw new NotImplementedException();
        }
    }


}
