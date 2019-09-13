using BaseLibrary.Data.Models.Config;
using SAPbobsCOM;
namespace BaseLibrary.Data.Contracts
{
    public class SapRepository : ISapRepository
    {
        private static Company _oCompany;        
        public SapRepository(Company oCompany)
        {
            _oCompany = oCompany;           
        }       
        public Company SAPCompanyConnection(CompanyResquest request)
        {
            //if (_oCompany.Connected == false)
            //{
                _oCompany = new SAPbobsCOM.Company
                {
                    Server = request.SapServer,
                    LicenseServer = request.SapLinsansServer,
                    DbServerType = request.DbServerType,
                    CompanyDB = request.CompanyDB,
                    UserName = request.UserName,
                    Password = request.UserPassword
                };
                var result = _oCompany.Connect();
           
                string a = _oCompany.GetLastErrorDescription();
                if (result != 0)
                {
                    _oCompany.GetLastError(out result, out var lastException);
                }
           // }
            return _oCompany;
        }
    }
}
