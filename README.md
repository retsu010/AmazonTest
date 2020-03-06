Documentación
1.	Herramientas
1.1.	Tecnologías y Herramientas

Las tecnologías y herramientas para utilizar para esta solución son las siguientes:
•	Microsoft Visual Studio 2018
•	Framework: Selenium.
•	Lenguaje: C#.
•	Tipos de pruebas: UI.

2.	TestCases
Las pruebas serán basadas en compras y las diferentes vertientes que podríamos experimentar como usuario dentro de Amazon. Estas estarán compuestas de 3 ‘TestCases’.

2.1.	Proceso de compra de un artículo especifico y de artículos sugeridos
Descripción -	El usuario compra un articulo
Casos de uso relacionados	C001. - Compra de un artículo especifico y de artículos sugeridos
Condiciones previas -	N/A
Flujo de eventos	
1.	El usuario accede al portal web de Amazon.
2.	El usuario procede con la búsqueda del artículo de interés.
3.	Agrega el artículo al carrito.
4.	Identifica si hay algún otro artículo en la sugerencia de Amazon.
4.1.	Si el artículo existe procede a agregarlo al carrito.
5.	El usuario acede al carrito.
6.	Procede a realizar el Checkout.

Postcondiciones -	Los artículos deben estar agregados en el carrito de compras y estar listos para para ser pagados

Comentarios	

  En cada uno de esto escenarios fue necesario:
  
•	Identificar el tipo de mapeo necesario para cada web element.

•	Creación de varios métodos que pudieran ser reutilizados en un futuro.

•	Identificar las mejores prácticas adaptando con el framework utilizado

2.2.	Proceso de compra de ofertas
Descripción -	El usuario consulta la página de ofertas y compra un articulo
Casos de uso - relacionados	C002. Proceso de Compras de ofertas
Condiciones previas -	N/A

Flujo de eventos	
1.	El usuario accede al portal web de Amazon.
2.	Navega a las ofertas del día de Amazon.
3.	Seleccionar una oferta.
4.	Validar el tipo de oferta y seleccionar el artículo.
5.	Agrega el artículo de oferta al carrito.
6.	Procede al checkout.

Postcondiciones -	El usuario debe ser capaz de navegar por la página de ofertas y seleccionar y comprar un artículo. Este debe ser agregado al carrito de compras y estar listo para su pago.

Comentarios	

En cada uno de esto escenarios fue necesario:

•	Acceder al portal web de Amazon.

•	Identificar el tipo de mapeo necesario para cada web element.

•	Creación de varios métodos que pudieran ser reutilizados en un futuro.

•	Identificar las mejores prácticas adaptando con el framework utilizado

2.3.	Proceso de compra de ‘Gift Cards’
Descripción -	El usuario compra las diferentes opciones de gift card
Casos de uso relacionados -	C003. Proceso de compras de ‘Gift Cards’
Condiciones previas-N/A

Flujo de eventos	
1.	El usuario accede al portal web de Amazon.
2.	Navega a la paginas de Tarjeta de regalo de Amazon
3.	Seleccionar el tipo de Tarjeta de regalo que desea comprar (eGift, Print at home y Mail)
4.	Dependiendo de la selección llenar capos requeridos y agregar al carrito
5.	Repetir pasos 2-3 para cada tipo de Tarjeta de regalo
Postcondiciones -	El usuario podrá visualizar los tipos de Tarjeta de regalo y podrá comprar de cada tipo de Tarjeta de regalo que la pagina ofrece.

Comentarios	

En cada uno de esto escenarios fue necesario:

•	Identificar el tipo de mapeo necesario para cada web element.

•	Creación de varios métodos que pudieran ser reutilizados en un futuro.

•	Identificar las mejores prácticas adaptando con el framework utilizado

