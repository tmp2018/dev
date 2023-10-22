
using DDDApi.Core.domain;
namespace DDDApi.Infra.Core.Infra
{

    public interface IBaseRepository<TEntity> where TEntity : BaseSchema
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        IList<TEntity> Select();

        TEntity Select(int id);
    }

}