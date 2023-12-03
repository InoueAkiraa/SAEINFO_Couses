float x = 4.5f;
double y = x; //é possível atribuir o valor porque ocorre uma conversão IMPLÍCITA, porque fez de float p double
Console.WriteLine(y);

double a;
float b;
// float b = a;
// aqui não podemos converter de double p float por conta da diferença na capacidade do conteúdo
// temos que realizar o CAST

a = 5.1;
b = (float)a;
Console.WriteLine(b);

//agora conversão de double p int
double c;
c = 5.1;
int d = (int)c; //ela imprime, mas excluirá as casas decimais
Console.WriteLine(d);