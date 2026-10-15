# Práctica 1: Pruebas Unitarias en .NET 6.0 (Solución AR)

Proyecto desarrollado para la evaluación de aseguramiento de calidad (QA), desarrollo en .NET 6.0 y control de versiones con Azure DevOps.

---

## 🏛️ Estructura del Proyecto

La solución general **AR.sln** contiene 4 proyectos modulares:

```text
AR.sln
│
├── AR.Temperatura/                       # Class Library (.NET 6.0)
│   └── TemperatureConverter.cs           # Métodos: CelsiusToFahrenheit, FahrenheitToCelsius
│
├── AR.Temperatura.UnitTestMSTest/        # Proyecto de Pruebas MSTest
│   └── TemperatureConverterTests.cs      # Pruebas con [TestClass] y [TestMethod] (Patrón AAA)
│
├── AR.StringManipulator/                 # Class Library (.NET 6.0)
│   └── StringManipulator.cs              # Métodos: ReverseString, RemoveSpaces
│
└── AR.StringManipulator.UnitTestAppxUnit/# Proyecto de Pruebas xUnit
    └── StringManipulatorTests.cs         # Pruebas con [Fact] (Patrón AAA)
```

---

## 🧪 Casos de Prueba Implementados

### Ejercicio 1: Convertidor de Temperatura (MSTest)
* **0°C a Fahrenheit**: Verifica que `0.0°C` retorne `32.0°F` (±0.001).
* **100°C a Fahrenheit**: Verifica el punto de ebullición `100.0°C` a `212.0°F`.
* **32°F a Celsius**: Verifica el punto de congelación `32.0°F` a `0.0°C`.
* **212°F a Celsius**: Verifica `212.0°F` a `100.0°C`.
* **-40°C a -40°F**: Verifica el punto de coincidencia térmica en ambas direcciones.
* **Cero Absoluto**: Verifica `-273.15°C` a `-459.67°F`.

### Ejercicio 2: Manipulación de Cadenas (xUnit)
* **Inversión Estándar**: Inversión de `"Hola"` a `"aloH"`.
* **Palíndromo**: Verificación de `"radar"` a `"radar"`.
* **Caracteres Especiales y UTF-8**: Inversión de `"¡Hola, Señor!"` a `"!roñeS ,aloH¡"`.
* **Limpieza de Espacios en Frases**: `"Hola Mundo Desde CSharp"` a `"HolaMundoDesdeCSharp"`.
* **Múltiples Espacios Consecutivos**: `"  A   R   P r u e b a s  "` a `"ARPruebas"`.
* **Idempotencia Sin Espacios**: `"SinEspacios"` retorna `"SinEspacios"`.
* **Null Safety / Resiliencia**: Cadenas nulas o vacías retornan cadena vacía de forma segura.

---

## 🚀 Comandos de Ejecución Local (.NET CLI)

```powershell
# Restaurar dependencias
dotnet restore AR.sln

# Compilar solución
dotnet build AR.sln

# Ejecutar todas las pruebas unitarias
dotnet test AR.sln --logger "console;verbosity=detailed"
```

---

## ☁️ Integración con Azure DevOps
* **Repositorio:** `https://dev.azure.com/isaiascencio450697/AR-Pruebas`
* **Pipeline:** Configurado mediante `azure-pipelines.yml` con recolección de Code Coverage.
* **Trazabilidad:** Commits vinculados a Work Items, PBIs, Tareas y Casos de Prueba en Azure Boards.
