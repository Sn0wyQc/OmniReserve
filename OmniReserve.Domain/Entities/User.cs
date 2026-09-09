using System.Dynamic;

namespace OmniReserve.Domain;

public class User
{
    public Guid Id {get; private set; }
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string Email {get; private set; }
    public string PaswordHash {get; private set; }
    public Role Role {get; private set; }
    
    public User(string firstName, string lastName, string email, string paswordHash, Role role)
    {
        if(string.IsNullOrWhiteSpace(firstName))
        throw new ArgumentNullException(nameof(firstName), "El nombre no puede estar vacio.");
        if(string.IsNullOrWhiteSpace(LastName))
        throw new ArgumentNullException(nameof(lastName), "El apellido no puede estar vacio. ");
        if(string.IsNullOrWhiteSpace(email))
        throw new ArgumentNullException(nameof(email), "El correo no puede estar vacio. ");
        if(string.IsNullOrWhiteSpace(paswordHash))
        throw new ArgumentNullException(nameof(paswordHash), "La contraseña no puede estar vacia. ");

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PaswordHash = paswordHash;
        Role = role;
    }
}