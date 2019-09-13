using SAPbobsCOM;
namespace BaseLibrary.Core.Contracts { 
   public interface IConfigurationHelper
    {
        string SapServer { get; }
        string SapLinsansServer { get; }
        string CompanyDB { get; }
        SAPbobsCOM.BoDataServerTypes DbServerType { get; }
        string DbUserName { get; }
        string DbPassword { get; }
        //string UserName { get; }
        //string UserPassword { get; }
        
            
    }
}
