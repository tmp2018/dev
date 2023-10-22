namespace DDDApi.Domain.Core.domain
{

    public class UniqueEntityId : Identifier<Guid>
    {
        public UniqueEntityId() : base(Guid.NewGuid())
        {

        }

        public Guid GetUniqueEntityId()
        {
            return this.GetValue();
        }

    }
}