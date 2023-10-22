using DDDApi.Core.domain;

namespace DDDApi.Domain;

public class User : Entity{

      public int NIF { get; set; }
      public string Name { get; set; }  
      public string Email { get; set; }  
      public string Password { get; set; }

}