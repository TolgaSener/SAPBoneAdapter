using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.BranchesService;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class BranchesController : ApiController
    {
        private readonly IBranchesEngine _branchesEngine;

        public BranchesController(IBranchesEngine branchesEngine)
        {
            _branchesEngine = branchesEngine;
        }

        [HttpPost]
        public Task<BranchParams> AddBranch(Branch branch)
        {
            return _branchesEngine.AddBranchAsync(branch);
        }

        [HttpPost]
        public Task DeleteBranch(BranchParams branchParams)
        {
            return _branchesEngine.DeleteBranchAsync(branchParams);
        }

        [HttpPost]
        public Task<Branch> GetByBranch(BranchParams branchParams)
        {
            return _branchesEngine.GetByBranchAsync(branchParams);
        }

        [HttpGet]
        public Task<BranchesParamsBranchParams[]> GetBranchList()
        {
            return _branchesEngine.GetByBranchListAsync();
        }

        [HttpPost]
        public Task UpdateBranch(Branch branch)
        {
            return _branchesEngine.UpdateBranchAsync(branch);
        }
    }
}
