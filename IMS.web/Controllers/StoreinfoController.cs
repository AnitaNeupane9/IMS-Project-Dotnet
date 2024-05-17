using IMS.Infrastructure.IRepository;
using IMS.Models.Entity;
using IMS.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IMS.web.Controllers

{
    //authorizepolicy = "ADMIN"
    [Authorize (Roles = "ADMIN")]
    public class StoreinfoController : Controller
    {
        private readonly ICrudService<Storeinfo> _storeCrudService;
        private readonly UserManager<ApplicationUser> _userManager;

        public Storeinfo Storeinfo { get; set; }
        public StoreinfoController(ICrudService<Storeinfo> storeCrudService, UserManager<ApplicationUser> userManager)

        {
            _storeCrudService = storeCrudService;
            _userManager = userManager;
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var storeinfoList = await _storeCrudService.GetAllAsync();
            return View(storeinfoList);
        }
        [HttpGet]
        public async Task<IActionResult> AddEdit(int Id)
        {
            Storeinfo storeinfo = new Storeinfo();
            if (Id > 0)
            {
                storeinfo = await _storeCrudService.GetAsync(Id);
            }
            return View(storeinfo);
        }
        [HttpPost]
        public async Task<IActionResult> AddEdit(Storeinfo storeinfo)
        {
            if (ModelState.IsValid)   //server side validation
            {
                try
                {
                    var userId = _userManager.GetUserId(HttpContext.User);
                    if (storeinfo.Id == 0)
                    {
                        storeinfo.CreatedDate = DateTime.Now;
                        storeinfo.CreatedBy = userId;
                        await _storeCrudService.InsertAsync(storeinfo);

                        TempData["success"] = "Data Added Successfully";
                    }
                    else
                    {
                        var OrgStoreinfo = await _storeCrudService.GetAsync(storeinfo.Id);
                        OrgStoreinfo.StoreName = storeinfo.StoreName;
                        OrgStoreinfo.Address = storeinfo.Address;
                        OrgStoreinfo.PhoneNumber = storeinfo.PhoneNumber;
                        OrgStoreinfo.PanNo = storeinfo.PanNo;
                        OrgStoreinfo.RegistrationNumber = storeinfo.RegistrationNumber;
                        OrgStoreinfo.IsActive = storeinfo.IsActive;
                        OrgStoreinfo.ModifiedDate = DateTime.Now;
                        OrgStoreinfo.ModifiedBy = userId;
                        await _storeCrudService.UpdateAsync(OrgStoreinfo);

                        TempData["success"] = "Data Updated Successfully";
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    TempData["error"] = "Something went wrong, please try again later";
                    //TempData["error"] = ex.Message;
                    return RedirectToAction(nameof(AddEdit));
                }
            }
            TempData["error"] = "Please Input Valid Data";
            return RedirectToAction(nameof(AddEdit));
        }


        public async Task<IActionResult> Remove(int id)
        {
            var storeinfo = await _storeCrudService.GetAsync(id);
            _storeCrudService.Delete(storeinfo);
            TempData["error"] = "Data Deleted Successfully";
            return RedirectToAction(nameof(Index));

        }


    }
}