using DDDApi.Domain.Core.domain;

namespace DDDApi.Core.domain
{


    public abstract class Entity : UniqueEntityId, IEquatable<Entity>
    {

        private Guid id;


        public Entity()
        {

            this.id = this.GetUniqueEntityId();

        }
        public bool Equals(Entity? other)
        {
            throw new NotImplementedException();
        }
    }
}