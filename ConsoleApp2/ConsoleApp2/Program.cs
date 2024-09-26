using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;

//// Exercício 1
//string text = " Bem-vindo ao curso de C#! ";
//string teste1 = text.Trim();
//string teste2 = teste1.ToUpper();
//string teste3 = teste2.Replace("C#", "Programação");

//// Qual será a saída final?

//Console.WriteLine(teste3);

//// Qual o tamanho da string final?
//int tamanho = teste3.Length;
//Console.WriteLine(tamanho);

//// O texto final começa com a palavra "BEM-VINDO"?

//if (teste3.StartsWith("BEM-VINDO"))
//{
//    Console.WriteLine("Começa");
//}
//else
//{
//    Console.WriteLine("Não começa com BEM-VINDO");
//}

//// Exercício 2
//string text = "Aprender a programar é um desafio gratificante!";
//Console.WriteLine(text.Contains("programar"));
//Console.WriteLine(text.IndexOf("desafio"));
////Console.WriteLine(text.Length);
//string outputParse = text.Substring(34, 12);
//Console.WriteLine(outputParse);

//// A frase contém a palavra programar? Qual a resposta do método Contains()?
//Console.WriteLine(text.Contains("programar")); // True

//// Indíce palavra desafio
//Console.WriteLine(text.IndexOf("desafio")); // 26

//// Palavra extraida usando Substring()
//Console.WriteLine(outputParse);


//// Exercício 3
//string text = "relatório_financeiro2024.pdf";
//Console.WriteLine(text.EndsWith("pdf"));

//// É um PDF?
//Console.WriteLine(text.EndsWith("pdf")); // True

//// Nome do arquivo ápós substituição
//string newname = text.Replace("2024", "2025");
//Console.WriteLine(newname); // relatório_financeiro2025.pdf

//// Qual é a palavra extraída?
//string extracted = text.Substring(text.IndexOf("financeiro"), 10);
//Console.WriteLine(extracted);

TextReader tr = new StreamReader(@"C:\Users\Aula\Desktop\nomes_telefones.txt"); 
String linha = tr.ReadLine();
while (linha != null)
{
    //Console.WriteLine(linha);
    linha = tr.ReadLine();
    string[] lista = new string[]{"(",  ")", "-"};
    string extracted = linha.Substring(linha.IndexOf("("), linha.Length - linha.IndexOf("("));
    foreach (var i in lista)
    {
        string final = extracted = extracted.Replace(i, "");
        Console.WriteLine(final);
    }
    //    string tiraParentese = extracted.Replace("(", "");
    //    Console.WriteLine(tiraParentese);
}
