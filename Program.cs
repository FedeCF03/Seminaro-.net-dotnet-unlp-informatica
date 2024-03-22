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




*/
