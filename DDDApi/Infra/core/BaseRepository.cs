using DDDApi.Infra.Core.Infra;

namespace DDDAPI.Infra.Core.infra
{


    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseSchema
    {
        private readonly SqlServerContext _sqlservercontext;

        public BaseRepository(SqlServerContext context){
            _sqlservercontext = context;
        }

        public void Delete(int id)
        {
            _sqlservercontext.Set<TEntity>().Remove(Select(id));
            _sqlservercontext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _sqlservercontext.Set<TEntity>().Add(obj);
            _sqlservercontext.SaveChanges();
        }

        public IList<TEntity> Select()
        {
             return _sqlservercontext.Set<TEntity>().ToList();

        }

        public TEntity Select(int id)
        {
           return _sqlservercontext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            _sqlservercontext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlservercontext.SaveChanges();
        }
    }

}