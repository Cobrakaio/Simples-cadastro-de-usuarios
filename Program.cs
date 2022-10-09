using testeClasse;

List<Pessoa> listaDePessoa = new List<Pessoa>();

while (listaDePessoa.Count() < 5)
{
    listaDePessoa.Add(CriarPessoa());
    Console.WriteLine("Pessoa: " + listaDePessoa.Last().nome + " adicionada na lista");
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey();
    Console.Clear();

}

foreach (Pessoa pessoa in listaDePessoa)
{
    Console.WriteLine($"Nome: {pessoa.nome} || Idade: {pessoa.idade}");
}
Console.ReadLine();

Pessoa CriarPessoa()
{
    Console.WriteLine("Insira o nome do usúario: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Insira a idade do usúario: ");
    int idade = int.Parse(Console.ReadLine());

    Pessoa pessoa = new Pessoa()
    {
        nome = nome,
        idade = idade
    };
    Console.Clear();
    return pessoa;
}