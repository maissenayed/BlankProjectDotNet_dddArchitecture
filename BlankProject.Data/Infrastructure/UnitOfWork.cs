namespace BlankProject.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        private DatabaseFactory dbfactory;
        private MyContext ctx;

        public MyContext Ctx
        {
            get { return ctx; }
        }
        public UnitOfWork( DatabaseFactory dbfactory)
        {
            this.dbfactory = dbfactory;
            ctx = dbfactory.MyContext;
        }
        public RepositoryBase<T> GetRepository<T>() where T : class
        {
            return new RepositoryBase<T>(dbfactory);
        }

        public void Commit()
        {
            Ctx.SaveChanges();
        }

        public void Dispose()
        {
            if (Ctx != null)
            {
                Ctx.Dispose();
            }
        }
    }
}
