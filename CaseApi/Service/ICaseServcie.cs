using CaseApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Service
{
    public interface ICaseServcie
    {
        IEnumerable<Case> GetAll();
        Case GetById(Case kaseId);
        Task CreateAsync(Case kase);
        Task UpdateAsync(Case kase);
        Task UpdateAsync(int id);
        Task Delete(int id);
    }
}
