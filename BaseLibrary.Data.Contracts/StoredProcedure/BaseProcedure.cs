using BaseLibrary.Data.Contracts.DataBase;

namespace BaseLibrary.Data.Contracts.StoredProcedure
{
    public class BaseProcedure: IBaseProcedure
    {
        private readonly CheckOutEntities _db;

        public BaseProcedure(CheckOutEntities db)
        {
            _db = db;
        }
    }
}
