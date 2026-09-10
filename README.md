# Sistema de Gestión de Instrumentos Industriales

Aplicación de consola desarrollada en **C#** para registrar, consultar y administrar instrumentos utilizados en entornos industriales.

El proyecto fue creado con fines educativos para practicar y reforzar conceptos de programación, estructuras de datos y Programación Orientada a Objetos.

## Descripción

El sistema permite gestionar diferentes tipos de instrumentos industriales, como:

- Sensores de temperatura.
- Medidores de presión.

Cada instrumento contiene información general y características específicas de acuerdo con su tipo.

El proyecto utiliza una clase base llamada `Instrumento`, clases derivadas y una interfaz para representar instrumentos que pueden ser calibrados.

## Funcionalidades

Actualmente, el sistema permite:

- Registrar sensores de temperatura.
- Registrar medidores de presión.
- Mostrar todos los instrumentos registrados.
- Buscar instrumentos por código.
- Buscar instrumentos por área de instalación.
- Actualizar las horas de uso.
- Cambiar el estado de un instrumento.
- Calibrar instrumentos compatibles.
- Mostrar instrumentos que requieren mantenimiento.
- Consultar estadísticas generales.
- Validar los datos ingresados por el usuario.
- Mostrar información mediante polimorfismo.

## Tipos de instrumentos

### SensorTemperatura

Representa un instrumento utilizado para medir temperatura.

Sus características específicas incluyen:

- Temperatura mínima.
- Temperatura máxima.
- Unidad de temperatura.

### MedidorPresion

Representa un instrumento utilizado para medir presión.

Sus características específicas incluyen:

- Presión mínima.
- Presión máxima.
- Unidad de presión.

## Conceptos de C# utilizados

Durante el desarrollo del proyecto se aplicaron los siguientes conceptos:

- Sintaxis de C#.
- Variables y tipos de datos.
- Entrada y salida de información.
- Conversión de datos.
- Operadores.
- Condicionales.
- Ciclos `while`, `for` y `do-while`.
- Arreglos.
- Métodos.
- Clases y objetos.
- Constructores.
- Encapsulamiento.
- Propiedades.
- Herencia.
- Clases abstractas.
- Métodos `virtual` y `override`.
- Polimorfismo.
- Interfaces.
- Validación de datos.
- Manejo de errores de compilación.
- Depuración.
- Organización del código en diferentes archivos.

## Estructura del proyecto

```text
Sistema_Gestion_Instrumentos/
│
├── programa/
│   ├── Program.cs
│   ├── Funciones.cs
│   ├── Instrumento.cs
│   ├── SensorTemperatura.cs
│   ├── MedidorPresion.cs
│   ├── ICalibrable.cs
│   └── programa.csproj
│
└── README.md
```

## Clase base

La clase `Instrumento` contiene la información general que comparten todos los instrumentos.

Entre sus propiedades se encuentran:

- Código.
- Nombre.
- Área de instalación.
- Fabricante.
- Modelo.
- Horas de uso.
- Estado.
- Fecha de calibración.

También incluye métodos para:

- Mostrar información.
- Actualizar horas de uso.
- Cambiar el estado.
- Determinar si requiere mantenimiento.

## Herencia y polimorfismo

Las clases:

```text
SensorTemperatura
MedidorPresion
```

heredan de:

```text
Instrumento
```

Esto permite reutilizar atributos y métodos comunes, además de agregar características específicas para cada instrumento.

El arreglo principal utiliza el tipo base:

```csharp
Instrumento[] instrumentos;
```

De esta forma, puede almacenar objetos de diferentes clases derivadas y ejecutar sus versiones correspondientes de `MostrarInformacion()`.

## Interfaz ICalibrable

La interfaz `ICalibrable` define las operaciones que debe implementar un instrumento que pueda ser calibrado.

```csharp
public interface ICalibrable
{
    void Calibrar();
    void MostrarInformacionCalibracion();
}
```

Esto permite identificar mediante polimorfismo qué instrumentos tienen capacidad de calibración.

## Mantenimiento

El sistema utiliza las horas de uso para determinar si un instrumento requiere mantenimiento.

La regla actual es:

```text
Si las horas de uso son mayores o iguales a 500,
el instrumento requiere mantenimiento.
```

## Estadísticas

El sistema puede mostrar información general como:

- Total de instrumentos registrados.
- Total de horas de uso.
- Promedio de horas de uso.
- Instrumentos activos.
- Instrumentos inactivos.
- Instrumentos en mantenimiento.
- Instrumentos fuera de servicio.
- Total de sensores de temperatura.
- Total de medidores de presión.
- Instrumentos que requieren mantenimiento.
- Instrumentos calibrables.

## Validaciones

El programa valida diferentes datos ingresados por el usuario, por ejemplo:

- Códigos numéricos válidos.
- Nombres no vacíos.
- Áreas de instalación no vacías.
- Fabricantes y modelos no vacíos.
- Horas de uso no negativas.
- Rangos mínimos y máximos correctos.
- Estados válidos.
- Unidades de medición no vacías.

También se utilizan expresiones como:

```csharp
Console.ReadLine() ?? "";
```

para evitar problemas cuando la entrada del usuario pueda ser `null`.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Plataforma:** .NET
- **Tipo de aplicación:** Consola
- **IDE:** Visual Studio Code
- **Control de versiones:** Git y GitHub

## Ejecución del proyecto

1. Clonar el repositorio:

```bash
git clone URL_DEL_REPOSITORIO
```

2. Entrar a la carpeta del proyecto:

```bash
cd Sistema_Gestion_Instrumentos
```

3. Ejecutar la aplicación:

```bash
dotnet run
```

## Objetivo del proyecto

El objetivo principal es reforzar los conocimientos de C# mediante el desarrollo progresivo de una aplicación relacionada con un entorno industrial.

También busca practicar la organización del código, la reutilización mediante herencia, el polimorfismo, el uso de interfaces y la solución de errores durante el desarrollo.

## Próximas mejoras

- Agregar eliminación de instrumentos.
- Implementar actualización de datos generales.
- Evitar códigos duplicados.
- Guardar información en archivos.
- Cargar registros automáticamente al iniciar.
- Agregar filtros por estado.
- Implementar reportes de mantenimiento.
- Mejorar el menú de navegación.
- Separar mejor la lógica de negocio y la interfaz.
- Agregar pruebas.
- Migrar posteriormente a una aplicación con interfaz gráfica o web.

## Autor

**Francisco Castillo**

Proyecto desarrollado como parte de mi aprendizaje y práctica continua en programación con C#.

## Estado del proyecto

🟡 En desarrollo

El proyecto continúa creciendo mediante nuevas funcionalidades, correcciones y mejoras de diseño.