Console.WriteLine("exemplo com operações");
int a = 10; //sem alterar
Console.WriteLine(a);

a += 2; // recebe a(10) + 2
Console.WriteLine(a);

a -= 2; // recebe a(12) - 2
Console.WriteLine(a);

a *= 3; // recebe a(10) * 3
Console.WriteLine(a);

a /= 2; // recebe a(30) / 2
Console.WriteLine(a);

a %= 3; //recebe a(15) resto da divisão 3
Console.WriteLine(a);

///////////////////////////////////////

//funciona com concatenação cumulativa de strings 
Console.WriteLine("\nexemplo com strings");
string s = "ABC";
Console.WriteLine(s);

s += "DEF";
Console.WriteLine(s);

//incremento e decremento
Console.WriteLine("\nincremento e decremento");
int b = 10;
int c = b++; //variável c recebe 10 e não recebe o incremento, por outro lado a var b foi incrementada
Console.WriteLine(b);
Console.WriteLine(c);
//pra corrigir essa falha do incremento na variável c, temos que fazer da seguinte forma
//c = ++b; assim o incremento ocorrerá antes da atribuição do valor da variável