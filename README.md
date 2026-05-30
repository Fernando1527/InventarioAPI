# Sistema de Inventario

## Descripción

Sistema web de inventario desarrollado utilizando ASP.NET Core MVC, ASP.NET Core Web API, Entity Framework Core y SQL Server. La aplicación permite la administración de categorías y productos mediante una arquitectura basada en servicios REST.

## Tecnologías Utilizadas

* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Swagger
* IIS
* Bootstrap

## Estructura del Proyecto

### InventarioAPI

Proyecto encargado de exponer los servicios REST y gestionar el acceso a la base de datos.

### InventarioWeb

Proyecto encargado de la interfaz gráfica y el consumo de los servicios REST.

## Funcionalidades

* Consulta de categorías.
* Consulta de productos.
* Interfaz gráfica para administración de inventario.
* Consumo de servicios REST.
* Integración con SQL Server.
* Publicación en IIS.

## Base de Datos

La aplicación utiliza una base de datos denominada **InventarioDB**, compuesta por las tablas:

* Categorias
* Productos

## Ejecución

1. Configurar la cadena de conexión a SQL Server.
2. Ejecutar el proyecto InventarioAPI.
3. Ejecutar el proyecto InventarioWeb.
4. Acceder a la aplicación mediante el navegador.

## Autor

Proyecto académico desarrollado para la asignatura Desarrollo de Aplicaciones con Software Propietario.
