# SiviComponents

## ✨ Biblioteca de Componentes para .NET

SiviComponents es una librería de componentes reutilizables para aplicaciones .NET, diseñada para mejorar la productividad y la mantenibilidad del código. Esta biblioteca incluye validaciones robustas utilizando **FluentValidation**, proporcionando una forma eficiente y declarativa de manejar reglas de validación.

---

## 🛠️ Instalación

Actualmente, SiviComponents no está disponible como un paquete NuGet. Para usarlo en tu proyecto:

1. Clona este repositorio o descarga el código fuente.
2. Agrega el proyecto **SiviComponents** a tu solución en Visual Studio.
3. Agrega una referencia al proyecto **SiviComponents** desde tu aplicación.

```sh
# Clonar el repositorio
git clone https://github.com/Hosivi/SiviComponents.git
```

---

## 🔧 Uso Básico

### 1. Definir una Clase con Validación
SiviComponents utiliza **FluentValidation** para validar modelos de datos de manera declarativa.

```csharp
using FluentValidation;

public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {
        RuleFor(x => x.IdentityDoc).NotEmpty().WithMessage("Ustede debe ingresas su número de documento");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Debe ingresar una contraseña");
    }

    public ValidationResult? GetValidationResult(Employee em)
    {
        var validationResult = Validate(em);
        return validationResult;
    }                                                             
}

```

---

## 🌐 Integración con .NET Dependency Injection
Para registrar SiviComponents y sus validaciones en **ASP.NET Core**:

```csharp
builder.Services.AddSiviComponents();
builder.Services.AddSVValidationService(ServiceLifetime.Transient, types.ToArray());
```

---

## 👀 Características
- Colección de componentes reutilizables para .NET.
- Validaciones basadas en **FluentValidation**.
- Compatible con **.NET 7  y superior**.
- Fácil integración con **Dependency Injection**.
- Formularios dinámicos.
- Implementación propia y básica de componentes de Formualrios, Grids. 

---

## 🚀 Propósito del Proyecto
Este proyecto fue desarrollado con el objetivo de:
- **Simplificar la validación de datos en aplicaciones .NET**.
- **Proporcionar componentes reutilizables y bien estructurados**.
- **Demostrar conocimientos en FluentValidation y arquitectura de software**.

---

## ⭐ Contribuciones
Este es un proyecto personal, pero si tienes sugerencias, puedes abrir un **pull request** o crear un **issue** con tus ideas.

---

## 👋 Contacto
Cualquier duda o sugerencia, puedes contactarme a través de **[GitHub Issues](https://github.com/Hosivi/SiviComponents/issues)** o en mi perfil de **GitHub**.

---

### © 2025 - SiviComponents - Licencia MIT

