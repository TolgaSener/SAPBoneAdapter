using BaseLibrary.Core.Contracts;
using SAPbobsCOM;
using System.Configuration;
using System.Globalization;
namespace BaseLibrary.Core { 
   public class ConfigurationHelper: IConfigurationHelper
    {
        public string SapServer => ConfigurationManager.AppSettings["sapServer"].ToString(CultureInfo.InvariantCulture);
        public string SapLinsansServer => ConfigurationManager.AppSettings["sapLinsansServer"].ToString(CultureInfo.InvariantCulture);
        public string CompanyDB => ConfigurationManager.AppSettings["companyDB"].ToString(CultureInfo.InvariantCulture);      
        public string DbUserName => ConfigurationManager.AppSettings["dbUserName"].ToString(CultureInfo.InvariantCulture);
        public string DbPassword => ConfigurationManager.AppSettings["dbUserName"].ToString(CultureInfo.InvariantCulture);
        BoDataServerTypes IConfigurationHelper.DbServerType => BoDataServerTypes.dst_MSSQL2014;
    }
}
