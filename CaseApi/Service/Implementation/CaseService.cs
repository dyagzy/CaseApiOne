using CaseApi.Data;
using CaseApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Service.Implementation
{
    public class CaseService : ICaseServcie
    {
        private readonly ApplicationDbContext _context;

        public CaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Case kase)
        {
           await  _context.Cases.AddAsync(kase);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var kase = GetById(id);
            _context.Remove(kase);
           await _context.SaveChangesAsync();
        }

        public IEnumerable<Case> GetAll() => _context.Cases.OrderBy(k => k.Title);


        public Case GetById(int kaseId) => _context.Cases.FirstOrDefault(k => k.Id == kaseId);

        public Case GetById(Case kaseId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Case kase)
        {
            _context.Update(kase);
           await  _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var kase  = GetById(id);
            _context.Update(kase);
           await  _context.SaveChangesAsync();
        }
    }
}
