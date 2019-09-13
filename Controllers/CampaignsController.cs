using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BaseLibrary.Data.WebService.CampaignsService;
using BaseLibrary.Engine.Contracts;

namespace BaseLibrary.Hosting.Api.Controllers
{
    [Authorize]
    public class CampaignsController : ApiController
    {
        private readonly ICampaignsEngine _queryEngine;

        public CampaignsController(ICampaignsEngine queryEngine)
        {
            _queryEngine = queryEngine;
        }

        [HttpPost]
        public Task<Campaign> GetCampaigns(CampaignParams request)
        {
            return _queryEngine.GetCampaignsAsync(request);
        }

        [HttpPost]
        public Task<CampaignsParamsCampaignParams[]> GetCampaignsList(CampaignParams query)
        {
            return _queryEngine.GetCampaignsListAsync(query);
        }

        [HttpPost]
        public Task<bool> DeleteCampaign(CampaignParams query)
        {
            return _queryEngine.DeleteCampaing(query);
        }
    }
}
