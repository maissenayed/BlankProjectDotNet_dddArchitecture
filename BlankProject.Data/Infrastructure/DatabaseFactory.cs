namespace BlankProject.Data.Infrastructure
{
    public class DatabaseFactory :Disposable, IDatabaseFactory
    {
        private MyContext myContext;
        public DatabaseFactory()
        {
            myContext = new MyContext();
        }
        public MyContext MyContext
        {
            get { return myContext; }

        }

        protected override void DisposeCore()
        {
            if(MyContext!=null)
                MyContext.Dispose();
        }
    }

  
}
