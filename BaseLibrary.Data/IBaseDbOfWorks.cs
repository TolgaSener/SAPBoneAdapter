using BaseLibrary.Data.Contracts;
using BaseLibrary.Data.Contracts.StoredProcedure;
using BaseLibrary.Data.Models.Config;
using SAPbobsCOM;
namespace BaseLibrary.Data
{
    public interface IBaseDbOfWorks
    {
        IRepository<TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : class;
        IBaseProcedure GetStoredProcedure();
        Company GetSapRepository(CompanyResquest request);

    }
}
