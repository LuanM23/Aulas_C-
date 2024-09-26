//Aula 25/09

//List<string> nomes = new List<string>();

//nomes.Add("Asdrubal");
//nomes.Add("Jack");
//nomes.Add("Rose");

//foreach (var nome in nomes)
//{
//    Console.WriteLine(nome);
//}


//using ConsoleApp3;

//List<Pessoa> pessoas = new List<Pessoa>();

//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Jack";
//pessoa1.Idade = 22;
//pessoa1.Email = "jack@teste.com";

//pessoas.Add(pessoa1);

//// ou

//pessoas.Add(new Pessoa { Nome = "Rose", Idade = 23, Email = "rose@teste.com" });

//Console.WriteLine(pessoas.Count); // o que vai imprimir? 

//foreach (var pessoa in pessoas)
//{
//    Console.WriteLine("Nome: " + pessoa.Nome);
//    Console.WriteLine("Idade: " + pessoa.Idade);
//    Console.WriteLine("Email:" + pessoa.Email);
//}


using ConsoleApp3;

//List<Produto> produtos = new List<Produto>();

//produtos.Add(new Produto { Nome = "Mouse", Valor = 80 , Categoria = "Informática" });
//produtos.Add(new Produto { Nome = "PC", Valor = 6000, Categoria = "Informática" });
//produtos.Add(new Produto { Nome = "Pistola", Valor = 500, Categoria = "Arma" });

//foreach (var produto in produtos)
//{
//    //Console.WriteLine("Nome: " + produto.Nome);
//    //Console.WriteLine("Valor: " + produto.Valor);
//    //Console.WriteLine("Categoria:" + produto.Categoria);
//    //Console.WriteLine("-------");
//    if (produto.Valor >1000)
//    {
//        Console.WriteLine(produto.Nome);
//    }
//}

//Produto maior1000 = (from prod in produtos where prod.Valor > 1000 select prod ).FirstOrDefault();
//Console.WriteLine(maior1000.Nome);

List<ToDo> todolist = new List<ToDo>();

todolist.Add(new ToDo { Descricao = "Comer", Concluida = false });
todolist.Add(new ToDo { Descricao = "Arrumar cama", Concluida = false });
todolist.Add(new ToDo { Descricao = "Ir pra aula", Concluida = true });

foreach (var tod in todolist)
{
    if (tod.Concluida == true)
    {
        var status = tod.Concluida == true ? "OK": "NOK"; // ternário tem que estar em váriavel

        Console.WriteLine("Descrição: " + tod.Descricao);
        Console.WriteLine("Concluída: " + status);
        Console.WriteLine("-------");
    }
}