public class Empresa
{
    private List<Funcionario>  Funcionarios;

    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }
    public void AdcionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }
    public void ListarFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome do fucionario: {funcionario.Nome}");
            Console.WriteLine($"O salario do funcionario: {funcionario.CalcularSalario()}");
        }
    }
}