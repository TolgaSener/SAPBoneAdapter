using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.Models.Model;
using BaseLibrary.Data.Models.Request;
using BaseLibrary.Data.Models.Response;
using BaseLibrary.Data.WebService.BusinessPartnersService;
using BaseLibrary.Engine.Contracts;
namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class BussinesPatnerController : ApiController
    {
        private readonly IBussinesPatnerEngine _bussinesPatnerEngine;//Muhataplar
        public BussinesPatnerController(IBussinesPatnerEngine bussinesPatnerEngine)
        {
            _bussinesPatnerEngine = bussinesPatnerEngine;
        }
        [HttpPost]
        public Task<BusinessPartner> GetByBusinessPartner(BusinessPartnerParams request)
        {
            return _bussinesPatnerEngine.GetByBusinessPartnerAsync(request);
        }
        [HttpGet]
        public Task<List<CustomerResponse>> GetAllBussinessPartner()
        {
            return _bussinesPatnerEngine.GetAllBusinessPartnerAsync();
        }

        [HttpPost]
        public Task<List<CustomerSearchResponse>> GetCustomerSearch(CustomerSearchRequest request)
        {
            return _bussinesPatnerEngine.GetCustomerSearchAsync(request);
        }
    }
}
