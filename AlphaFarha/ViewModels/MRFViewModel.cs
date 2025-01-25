using AlphaFarha.Core.Models;
using AlphaFarha.Entities.Models;

namespace AlphaFarha.UI.ViewModels
{
    public class MRFViewModel
    {
        public DateTime FromDate { get; set; }  
        public DateTime ToDate { get; set; }
        public IEnumerable<Project> Projects { get; set; } = new List<Project>();

        public IEnumerable<MRF> MRFList { get; set; } = new List<MRF>();
        
        public MRF objMRF { get; set; } = new MRF();
    }
}
