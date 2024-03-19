namespace LHPet.Models;

public class Fornecedor
{
    public int Id { get; set; }
    public int Nome { get; set; }
    public int Cnpj { get; set; }
    public int Email { get; set; }

    public Fornecedor (int id , string nome , string cnpj ,
string email)
    {
        this.Id = id;
        this.Nome = Nome;
        this.Cnpj = Cnpj;
        this.Email = Email;
        
    }
}