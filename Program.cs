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


*/

