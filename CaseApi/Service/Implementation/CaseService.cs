using CaseApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Service.Implementation
{
    public class CaseService : ICaseServcie
    {
        public CaseService()
        {

        }

        public Task CreateAsync(Case kase)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Case> GetAll()
        {
            throw new NotImplementedException();
        }

        public Case GetById(Case kaseId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Case kase)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
