namespace Puroguramu.Domains.Models;

public class AppUser
{

    private string _matricule;

    private string _lastName;

    private string _firstName;

    private string _email;

    private string _groupName;

    public AppUser(string matricule, string lastName, string firstName, string email, string groupName)
    {
        _matricule = matricule;
        _lastName = lastName;
        _firstName = firstName;
        _email = email;
        _groupName = groupName;
    }

    public string Matricule
    {
        get => _matricule;
        set => _matricule = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string Group
    {
        get => _groupName;
        set => _groupName = value;
    }
}
