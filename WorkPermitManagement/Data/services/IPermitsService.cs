using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPermitManagement.Models;

namespace WorkPermitManagement.Data.services
{
    public interface IPermitsService
    {
        Task<IEnumerable<WorkPermit>> getAll();
        WorkPermit getByDate(DateTime date);

         WorkPermit getByid(int id ); 

        void Add(WorkPermit workPermit);

        WorkPermit update(int id);

        void delete(int id);
    }
}
