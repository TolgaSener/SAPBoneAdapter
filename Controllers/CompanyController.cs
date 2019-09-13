using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.CompanyService;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyEngine _companyEngine;

        public CompanyController(ICompanyEngine companyEngine)
        {
            _companyEngine = companyEngine;
        }

        [HttpPost]
        public Task<Recordset> Query(RecordsetParams request)
        {
            return _companyEngine.QueryAsync(request);
        }

        [HttpPost]
        public Task<PeriodCategoryParams> CreatePeriod(PeriodCategory request)
        {
            return _companyEngine.CreatePeriodAsync(request);
        }

        [HttpPost]
        public Task<PeriodCategoryParams> CreatePeriodWithFinanceParams(PeriodCategory periodCategory,
            FinancePeriodParams financePeriodParams)
        {
            return _companyEngine.CreatePeriodWithFinanceParamsAsync(periodCategory, financePeriodParams);
        }

        [HttpGet]
        public Task<AdminInfo> GetAdminInfo()
        {
            return _companyEngine.GetAdminInfo();
        }

        [HttpPost]
        public Task<Blob> GetBlob(BlobParams plParams)
        {
            return _companyEngine.GetBlobAsync(plParams);
        }

        [HttpGet]
        public Task<CompanyInfo> GetCompanyInfo()
        {
            return _companyEngine.GetCompanyInfoAsync();
        }


    }
}
