# Taller de Lenguajes I - Trabajo Practico 6
**Nombre y apellido:** Reyes Cruz Miqueas Nicolas | **Fecha de la ultima Actualizacion:** 29/05

---
## Respuestas del punto 4:
- ¿String es una tipo por valor o un tipo por referencia?
    Es un tipo de valor por referencia.

- ¿Qué secuencias de escape tiene el tipo string?
    Que es una secuencia de escape? Es una combinación de caracteres que no se representa a sí misma cuando se procesa, sino que se traduce en un carácter especial o activa un comportamiento específico en el compilador. Es decir, se refiere a los valores como "\n" en C++.
    
| Secuencia de escape	| Nombre de carácter | Codificación Unicode |
| --- | --- | --- |
| \' | Comilla simple | 0x0027 |
| \" | Comilla doble | 0x0022 |
| \\ | Barra invertida | 0x005C |
| \0 | Nulo | 0x0000 |
| \a | Alerta | 0x0007 |
| \b | Retroceso | 0x0008 |
| \e | Escapar | 0x001B |
| \f | Avance de página |0x000C |
| \n | Nueva línea | 0x000A |
| \r | Retorno de carro | 0x000D |
| \t | Tabulación horizontal | 0x0009 |
| \v | Tabulación vertical | 0x000B |
| \u | Secuencia de escape Unicode (UTF-16) | \uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç") |
| \U | Secuencia de escape Unicode (UTF-32) | \U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽") |
| \x | Secuencia de escape Unicode similar a "\u" excepto con longitud variable | \xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 or \x0E7 or \xE7 = "ç") |

- ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
    Lo que sucede, al utilizar @ y $ antes de una cadena de texto, es que interpolamos las cadenas (no importa el orden en el que sean puestos).

     - El símbolo $ (Interpolación): Permite incrustar variables o expresiones de C# directamente dentro del texto utilizando llaves { }, evitando tener que concatenar con el operador +.
     - El símbolo @ (Verbatim): Le dice al compilador que interprete el texto exactamente como está escrito. Esto significa que se desactivan las secuencias de escape tradicionales (como \n o \t) y se permiten los saltos de línea reales dentro del código fuente.

    ```C#
        var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
        Console.WriteLine($@"{jh.firstName} {jh.lastName}
            was an African American poet born in {jh.born}.");
        Console.WriteLine(@$"He was first published in {jh.published}
        at the age of {jh.published - jh.born}.");

        // Output:
        // Jupiter Hammon
        //     was an African American poet born in 1711.
        // He was first published in 1761
        // at the age of 50.
    ```
    