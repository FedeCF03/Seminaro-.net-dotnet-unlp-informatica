
/*4) Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven 
un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es 
cuadrada generar una excepción ArgumentException.


double[] GetDiagonalPrincipal(double[,] matriz)
{
    double[] result;
    if (matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("La matriz no es cuadrada");
    }
    else
    {
        result = new double[matriz.GetLength(0)];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            result[i] = matriz[i, i];
            Console.WriteLine(result[i]);
        }
    }

    return result;
}

double[] getDiagonalSecundaria(double[,] matriz)
{
    double[] result;
    if (matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("La matriz no es cuadrada");
    }
    else
    {
        result = new double[matriz.GetLength(0)];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            result[i] = matriz[i, matriz.GetLength(1) - i - 1];
        }

        return result;
    }
}
GetDiagonalPrincipal(new double[,] { { 1, 25, 312 }, { 4, 5, 6 }, { 4, 4, 4 } });

Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices 
pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño, 
en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de columnas de A debe 
ser igual a la cantidad de filas de B, en caso contrario generar una excepción ArgumentException.

double[,]? Suma(double[,] A, double[,] B)
double[,]? Resta(double[,] A, double[,] B)
double[,] Multiplicacion(double[,] A, double[,] B)


double[,]? Suma(double[,] A, double[,] B)
{
    if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
    {
        return null;
    }
    else
    {
        double[,] result = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                result[i, j] = A[i, j] + B[i, j];
            }
        }
        return result;
    }
}
double[,]? resta(double[,] A, double[,] B)
{
    if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
    {
        return null;
    }
    else
    {
        double[,] result = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                result[i, j] = A[i, j] - B[i, j];
            }
        }
        return result;
    }
}

double[,] Multiplicacion(double[,] A, double[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        throw new ArgumentException("La cantidad de columnas de A debe ser igual a la cantidad de filas de B");
    }
    else
    {
        double[,] result = new double[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                    Console.WriteLine(result[i, j]);
                }

            }


        }

        return result;
    }
}
Multiplicacion(new double[,] { { 1, 25 }, { 4, 5 } }, new double[,] { { 1, 312 }, { 5, 6 } });



Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están 
bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena de 
entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se almacenan en una 
pila hasta encontrar uno de cierre, realizándose entonces la extracción del último paréntesis de apertura 
almacenado. Si durante el proceso se lee un paréntesis de cierre y la pila está vacía, entonces la cadena 
es incorrecta. Al finalizar el análisis, la pila debe quedar vacía para que la cadena leída sea aceptada, de 
lo contrario la misma no es válida


using System;

Boolean checkParentecis(String expresion)

{
    Stack<char> pila = new Stack<char>();
    foreach (char c in expresion)
    {
        if (c == '(')
        {
            pila.Push(c);
        }
        else if (c == ')')
        {
            if (pila.Count == 0)
            {
                return false;
            }
            pila.Pop();
        }
    }
    return true;
}

Console.WriteLine(checkParentecis("((1+2)*3)"));


Utilizar la clase Stack<T> (pila) para implementar un programa 
que pase un número en base 10 a otra base realizando divisiones 
sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos 
sucesivamente por dos hasta encontrar un cociente menor que el 
divisor, luego el resultado se obtiene leyendo de abajo hacia arriba el 
cociente de la última división seguida por todos los restos.


using System;

String? DecimalABinario(int numero)
{
    string result = "";
    Stack<int> pila = new Stack<int>();
    while (numero >= 1)
    {
        pila.Push(numero % 2);
        numero = numero / 2;
    }
    while (pila.Count > 0)
    {
        result += pila.Pop().ToString();
    }
    return result;
}
{

}


Console.WriteLine(DecimalABinario(35));

14) Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto 
aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter 
una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por ejemplo: para 
la siguiente tabla de caracteres:

Si la clave es 5,3,9,7 y el mensaje a cifrar es “HOLA MUNDO”, se cifra de la siguiente manera:
A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que la suma 
fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola con los números 
de la clave encolados y a medida que se desencolen para utilizarlos en el cifrado, se vuelvan a encolar 
para su posterior utilización. Programar un método para cifrar y otro para descifrar
*/

using System;

void claveRepetida(int[] clave, string mensaje)
{
    Queue<int> cola = new Queue<int>();
    int ncola = 0;
    foreach (int c in clave)
    {
        cola.Enqueue(c);
    }
    string result = "";
    foreach (char c in mensaje)
    {

        ncola = cola.Dequeue();
        result += ((char)(c + ncola));
        cola.Enqueue(ncola);
    }
    Console.WriteLine(result);
}

claveRepetida(new int[] { 5, 3, 9, 7 }, "HOLA MUNDO");
