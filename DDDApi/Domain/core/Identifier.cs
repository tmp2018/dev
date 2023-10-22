using Microsoft.AspNetCore.SignalR;


namespace DDDApi.Domain.Core.domain
{
    public class Identifier<T>
    {
        private T value;

        public Identifier(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T new_value)
        {
            this.value = new_value;
        }
    }
}