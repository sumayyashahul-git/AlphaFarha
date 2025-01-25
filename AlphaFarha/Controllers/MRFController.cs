using AlphaFarha.Core.Interfaces;
using AlphaFarha.Core.Models;
using AlphaFarha.Core.Services;
using AlphaFarha.Entities.Models;
using AlphaFarha.InfraStructure.Repositories;
using AlphaFarha.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlphaFarha.UI.Controllers
{
    public class MRFController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly MRFServices  _mrfService;  

        public MRFController(MRFServices mrfService, IProjectRepository projectRepository)
        {
            _mrfService = mrfService;
            _projectRepository = projectRepository;
        }
        public async Task<IActionResult> Index()
        {
            var model = new MRFViewModel
            {
                FromDate = DateTime.Now.AddDays(-7),
                ToDate = DateTime.Now,
                Projects = await _projectRepository.GetAllProjectAsync() ?? new List<Project>(),
                MRFList = await _mrfService.GetAllMRFs() ?? new List<MRF>() 
            };

            return  View(model);
        }
        public async Task<IActionResult> Add()
        {
            var model = new MRFViewModel
            {
                FromDate = DateTime.Now.AddDays(-7),
                ToDate = DateTime.Now,
                Projects = await _projectRepository.GetAllProjectAsync()??new List<Project>(),
            };
            return View(model);
        }
        [HttpPost]
        public  IActionResult Add(MRFViewModel mRFViewModel)
        {
            if (!ModelState.IsValid)
            {
                // If the model state is invalid, return the view with the validation errors
                return View(mRFViewModel);
            }

            // Map the ViewModel to the Entity Model (MRF)
            MRF mrf = mRFViewModel.objMRF;

            _mrfService.AddMaterialRequest(mrf);

            // Redirect to a success page or list view
            return RedirectToAction("Index");
        }

    }
}
