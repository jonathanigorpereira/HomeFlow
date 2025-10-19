namespace HomeFlowApi.Core.Entitie;

public class User(
    string name,
    string cpf,
    string phone,
    DateOnly birthDate,
    string email,
    string password)
    : BaseEntity()
{
    public string Name { get; set; } = name;
    public string Cpf { get; set; } = cpf;
    public string Phone { get; set; } = phone;
    public DateOnly BirthDate { get; init; } = birthDate;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}