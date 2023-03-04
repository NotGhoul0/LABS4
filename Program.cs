// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ejercicio 1: Operaciones aritmeticas");

Console.WriteLine("Ingrese un numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int suma = n1 + n2;
Console.WriteLine(n1 + "+" + n2 + "=" + suma);

int resta = n1 - n2;
Console.WriteLine(n1 + "-" + n2 + "=" + resta);

int multiplicacion = n1 * n2;
Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion);

int div = n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + div);

int mod = n1 % n2;
Console.WriteLine(n1 + "%" + n2 + "=" + mod);

//para convertir un int a double y que salga con punto decimal
double division = (double) n1 / n2;
Console.WriteLine(n1 + "/" + n2 + "=" + division);
//ejercicio 2: operaciones booleanas//

Console.WriteLine("Ejercicio no.2: operaciones booleanas");
if (n1 > n2)
{
    Console.WriteLine("el primer numero es mayor al segundo ");
}
   else if(n1 < n2)
{
    Console.WriteLine("el segundo numero es mayor al primero ");
}
else if (n1 == n2){
    Console.WriteLine("ambos numeros son iguales");
}



Console.WriteLine("Ejercicio no.3:ejercicio 3: Jerarquía de operaciones");

Console.WriteLine("Ingrese un numero: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero: ");
int c = Convert.ToInt32(Console.ReadLine());

double i = a + b * c;

Console.WriteLine("La suma del primer numero por el tercero es: " + i );

double sumab = a + b;
double ii = b * sumab;
Console.WriteLine("la multiplicacion de b por a mas b es igual: " + ii);

double multdiv = b * c;
double iii = a / multdiv;
Console.WriteLine("el primer numero partido el segundo por el tercero es igual: " + iii);

double tresxa = 3 * a;
double dosxb = 2 * b;
double cxc = c * c;
double bporb = b * b;
double mcuatrobc = 4 * a * c;
double dosxa = 2 * a;

double sumtrxmasdosxb = tresxa + dosxb;

double iv = sumtrxmasdosxb / cxc;
Console.WriteLine("la multiplicacion de tres por el primer numero mas dos por el primer numero, partido c al cuadrado es: " + iv);

double cuadraticaraiz = bporb - dosxa;
double raiz = Math.Sqrt(cuadraticaraiz);

double cuadraticasindivmas = -b + raiz;
double cuadratica = cuadraticasindivmas / dosxa;

Console.WriteLine("cuadratica, x2" + cuadratica);

double cuadraticasindivmenos = -b - raiz;
double cuadraticamenos = cuadraticasindivmenos / dosxa;

Console.WriteLine("cuadratica, x1" + cuadraticamenos);



 























