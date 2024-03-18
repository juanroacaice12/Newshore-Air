# Newshore Air - Sistema de búsqueda de rutas de vuelo

## Descripción
Newshore Air es una aplicación web que permite a los usuarios buscar rutas de vuelo entre diferentes ciudades y ver los precios correspondientes en diferentes monedas. El sistema utiliza una API externa para obtener los datos de vuelo y proporciona una interfaz amigable para que los usuarios realicen búsquedas. Se ha implementado un manejo de excepciones para los casos en que la API externa no pueda proporcionar los datos de vuelo.

## Características
- Búsqueda de rutas de vuelo por origen y destino.
- Selección de moneda para ver los precios de vuelo.
- Visualización de los resultados de búsqueda con detalles de vuelo y precios.

## Instalación y configuración
1. Clona este repositorio en tu máquina local usando el comando:
https://github.com/tu_usuario/Newshore-Air.git

2. Abre el proyecto en tu editor de código favorito.

3. Instala las dependencias del proyecto utilizando el gestor de paquetes de tu elección. Por ejemplo, si estás utilizando npm:


4. Ejecuta la aplicación localmente utilizando el comando:

5. Abre tu navegador web y navega a `http://localhost:3000` para acceder a la aplicación.

## Tecnologías utilizadas
- ASP.NET Core MVC para el backend, utilizando C#.
- HTML, CSS y JavaScript para el frontend.
- HttpClient para realizar solicitudes HTTP a la API externa.
- Newtonsoft.Json para deserializar datos JSON.
- Bootstrap para estilos adicionales y diseño responsivo.

## Estructura del proyecto
El proyecto está organizado de la siguiente manera:
- **/Controllers**: Contiene los controladores de ASP.NET Core MVC escritos en C#.
- **/Models**: Contiene las clases de modelo para las entidades de vuelo y transporte.
- **/Services**: Contiene la lógica de negocio y el servicio para interactuar con la API externa.
- **/Frontend**: Contiene los archivos estáticos como CSS, HTML y JavaScript.

## Manejo de excepciones
Se ha implementado un manejo de excepciones para casos en que la API externa no pueda proporcionar los datos de vuelo. En tales situaciones, se mostrará un mensaje de error adecuado al usuario, indicando "Error al obtener la ruta de vuelo. Por favor, intenta de nuevo más tarde".

## Cumplimiento de los temas a evaluar
- Arquitectura de la solución
- Programación orientada a objetos
- Consumo REST API
- Control de versiones
- Manejo de estilos en cascada CSS

## Rama principal del repositorio
Todo el código de este proyecto se encuentra en la rama master. Hubo un problema con GitHub y el código no quedó en la rama main.

## Autor
Juan Roa

## Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE.md para más detalles.

