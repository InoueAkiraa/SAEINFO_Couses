﻿using System.Globalization;

//Variáveis
char genero = 'F';
int idade = 32;
double saldo = 10.35784;
String nome = "Maria";

//Quebra de linha em textos
Console.Write("Bom dia!");
Console.WriteLine("Boa tarde!");
Console.WriteLine("Boa noite!");
Console.WriteLine("---------------------------");

//Imprimindo variáveis
Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo);
Console.WriteLine(nome);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F4"));
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("---------------------------");

//Imprimindo com placeholders
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //substitui {} pelas var

//interpolação
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

//Concatenação
Console.WriteLine(nome +"tem " +idade +"anos e tem saldo igual a " +saldo.ToString("F2") +" reais");
Console.WriteLine(nome + "tem " + idade + "anos e tem saldo igual a " + saldo.ToString("F2", 
CultureInfo.InvariantCulture) + " reais");