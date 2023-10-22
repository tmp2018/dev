using DDDApi.Infra.Core.Infra;

namespace DDDAPI.Infra.schemas{


public class UserSchema : BaseSchema {

        public int NIF {get; set;}
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
