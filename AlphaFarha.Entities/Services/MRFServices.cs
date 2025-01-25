using AlphaFarha.Core.Interfaces;
using AlphaFarha.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaFarha.Core.Services
{
    public class MRFServices
    {
        private readonly IMRFRepository _mrfRepository;

        public MRFServices(IMRFRepository mrfRepository)
        {
            _mrfRepository = mrfRepository;
        }

        public  Task<IEnumerable<MRF>?> GetAllMRFs()
        {
            return _mrfRepository.GetAllMRFAsync();
        }

        public Task<IEnumerable<MRF>> GetFilteredMaterialRequests(DateTime fromDate, DateTime toDate, string type, string requestedBy, string project,string MrfNo)
        {
            return _mrfRepository.GetFilteredAsync(fromDate, toDate, type, requestedBy, project,MrfNo);
        }

        public void AddMaterialRequest(MRF  mRF)
        {
            _mrfRepository.AddMRFAsync(mRF);
           
        }

        public MRF? GetMaterialRequestById(int id)
        {
            //return _mrfRepository.GetById(id);
            return null;
        }
    }
}
