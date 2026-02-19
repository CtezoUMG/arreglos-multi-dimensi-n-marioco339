using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---

// Asignamos el primer elemento como el máximo inicial.
// Esto es seguro porque el problema asume que el arreglo tiene al menos 1 elemento (tamaño n).
int valorMaximo = arreglo[0]; 

// Usamos un ciclo 'for' estándar. Es más rápido que 'foreach' o LINQ en .NET 
// porque el compilador optimiza la verificación de límites (bounds checking).
for (int i = 1; i < arreglo.Length; i++)
{
    if (arreglo[i] > valorMaximo)
    {
        valorMaximo = arreglo[i]; // Actualizamos si encontramos un número mayor
    }
}

// Imprimimos estrictamente el resultado, sin texto adicional para no romper el Autograding
Console.WriteLine(valorMaximo);

// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo);
