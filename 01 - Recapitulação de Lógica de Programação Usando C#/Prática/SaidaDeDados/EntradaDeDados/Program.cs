//Console.WriteLine("Digite uma frase");
//string frase = Console.ReadLine(); //faz a leitura do que foi digitado no teclado
//Console.WriteLine("Em seguida digite 3 palavras");
//string x = Console.ReadLine();
//string y = Console.ReadLine();
//string z = Console.ReadLine();

//Console.WriteLine("\nVocê digitou: {0}", frase);
//Console.WriteLine("Também digitou as frases {0}, {1}, {2}", x, y, z);

////COMANDO SPLIT armazenando em vetores
//Console.WriteLine("\nDigite 3 palavras com espaços entre si");
//string[] vet = Console.ReadLine().Split(' '); //vai separar em vetores 
//string pt1 = vet[0];
//string pt2 = vet[1];
//string pt3 = vet[2];
//Console.WriteLine("você digitou {0}, {1} e {2}", pt1, pt2, pt3);

//////PARTE 2
using System.Globalization;

Console.WriteLine("Digite um número");
int n1 = int.Parse(Console.ReadLine()); //CONVERTER STRING PARA INT
Console.WriteLine("Digite 1 caractere");
char ch = char.Parse(Console.ReadLine());
Console.WriteLine("Digite um número flutuante");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Você digitou: {0}", n1);
Console.WriteLine("Você digitou: {0}", ch);
Console.WriteLine("Você digitou: {0}", n2);
//Console.WriteLine("Você digitou: {0}", n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("\nDigite o nome, sexo, idade e altura da pessoa");
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse((string)vet[3], CultureInfo.InvariantCulture);

Console.WriteLine("{0} é do sexo {1}, possui {2} anos e mede {3}", nome, sexo, idade, altura);