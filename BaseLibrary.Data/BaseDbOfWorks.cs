using BaseLibrary.Data.Contracts;
using BaseLibrary.Data.Contracts.DataBase;
using BaseLibrary.Data.Contracts.StoredProcedure;
using BaseLibrary.Data.Models.Config;
using SAPbobsCOM;
namespace BaseLibrary.Data
{
   public class BaseDbOfWorks: IBaseDbOfWorks
    {
        private static Company Company;
        public Company company
        {
            get { return Company = Company ?? new SAPbobsCOM.Company(); }
            set { Company = value; }
        }
        public IRepository<TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : class
        {
            return new RepositoryBase<TEntity, TKey>();
        }
        public Company GetSapRepository(CompanyResquest request)
        {
            if (company.Connected == false)
            {
                SapRepository sapb1repo = new SapRepository(company);
                Company = sapb1repo.SAPCompanyConnection(request);
            }
            return Company;
        }
       
        public IBaseProcedure GetStoredProcedure()
        {
            return  new BaseProcedure(new CheckOutEntities());
        }
    }
}
