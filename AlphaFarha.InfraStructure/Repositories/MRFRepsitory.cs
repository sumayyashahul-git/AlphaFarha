using AlphaFarha.Core.Interfaces;
using AlphaFarha.Entities.Models;
using AlphaFarha.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.InfraStructure.Repositories
{
    public class MRFRepsitory : IMRFRepository
    {
        private readonly ApplicationDbContext _context;

        public MRFRepsitory(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddMRFAsync(MRF mrf)
        {
            await _context.AddAsync(mrf);
            await _context.SaveChangesAsync();
            mrf.MRFNo = $"MT-{mrf.Id:D5}";

            _context.Update(mrf);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMRFAsync(MRF mrf)
        {
            _context.Update(mrf);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MRF>> GetFilteredAsync(DateTime fromDate, DateTime toDate, string type, string requestedBy, string project, string mrfNo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MRF>?> GetAllMRFAsync()
        {
            return await _context.MRFs.ToListAsync();
        }

        public Task UpdateMRFAsync(MRF mrf)
        {
            throw new NotImplementedException();
        }
    }
}
