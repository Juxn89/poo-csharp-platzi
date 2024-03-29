# poo-csharp-platzi
Fundamentos de Programación Orientada a Objetos con C# - Platzi

## Tipos de registros y estructura
RECORD En C#, un **record** es un tipo de referencia inmutable introducido en C# 9.0 que se utiliza para modelar datos simples y valores inmutables. Los **records** son especialmente útiles cuando tienes un conjunto de datos que no cambia después de su creación y deseas garantizar que no se pueda modificar. Algunas de las ventajas y casos de uso comunes de los **records** incluyen:

Inmutabilidad: Los **records** son inmutables de forma predeterminada, lo que significa que sus valores no pueden cambiar después de que se hayan creado. Esto garantiza que los datos permanezcan consistentes y predecibles.

Facilidad de Igualdad: Los **records** facilitan la comparación de igualdad de objetos basándose en sus valores en lugar de sus referencias. Esto es útil al realizar comparaciones de igualdad en lugar de referencia.

Sintaxis Concisa: Los **records** tienen una sintaxis concisa para definir propiedades y métodos. Puedes definir propiedades de solo lectura de manera abreviada.

Desestructuración: Los **records** admiten la desestructuración, lo que significa que puedes descomponer un objeto **record** en sus componentes individuales.

Patrones de Coincidencia: Los **records** funcionan bien con patrones de coincidencia, lo que facilita la escritura de código que responde a diferentes combinaciones de valores de objetos **record**.

Usos Comunes: Los **records** son ideales para modelar tipos de datos simples como puntos, vectores, coordenadas geográficas, datos de sensores y otros valores inmutables.

## Modificadores de acceso
- ```public```: Los miembros públicos son accesibles desde cualquier lugar del programa.
protected: Los miembros protegidos son accesibles desde la clase en la que están definidos, así como desde las clases derivadas de esa clase.
- ```internal```: Los miembros internos son accesibles desde la clase en la que están definidos, así como desde otras clases en el mismo ensamblado.
- ```private```: Los miembros privados solo son accesibles desde la clase en la que están definidos. Los niveles de acceso en C# se utilizan para organizar el código en una jerarquía lógica. Hay tres niveles de acceso en C#:
- ```Público```: El nivel de acceso público es el nivel más alto de acceso. Los miembros públicos son accesibles desde cualquier lugar del programa.
- ```Protegido```: El nivel de acceso protegido es el siguiente nivel más alto de acceso. Los miembros protegidos son accesibles desde la clase en la que están definidos, así como desde las clases derivadas de esa clase.
- ```Privado```: El nivel de acceso privado es el nivel más bajo de acceso. Los miembros privados solo son accesibles desde la clase en la que están definidos. Los modificadores de acceso y los niveles de acceso en C# se utilizan para controlar la visibilidad de los miembros de una clase. Esto ayuda a mejorar la seguridad y la mantenibilidad del código.
