using BaseLibrary.Data.Models.Config;
using SAPbobsCOM;
namespace BaseLibrary.Data.Contracts
{
    public interface ISapRepository
    {
      Company SAPCompanyConnection(CompanyResquest resquest);
    }
}
