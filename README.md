# RentaCar Express – Sistema de Alquiler de Vehículos

 1. Nombre y matrícula

- **Estudiante:** Christhopher Peguero Nolasco
- **Matrícula:**2026-1511
- **Proyecto:** Examen práctico – Programación Básica
- **Lenguaje:** C#
- **Entorno:** Visual Studio
- **Tecnología:** Windows Forms

 2. Descripción del programa

RentaCar Express es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Su objetivo es registrar alquileres de vehículos y calcular automáticamente el monto total que debe pagar un cliente.

El programa permite registrar diferentes vehículos, establecer la cantidad de días de alquiler, seleccionar el tipo de seguro, agregar GPS y elegir el tipo de entrega.

También permite aplicar descuentos a clientes corporativos y calcular el ITBIS correspondiente.

3. Datos de entrada

Los datos que recibe el programa son:

- Nombre del cliente.
- Fecha de salida.
- Nombre del vehículo.
- Tarifa diaria del vehículo.
- Cantidad de días de alquiler.
- Tipo de seguro (básico o completo).
- GPS (opcional).
- Cliente corporativo (sí o no).
- Tipo de entrega (sucursal o domicilio).

4. Proceso

El programa realiza los siguientes procedimientos:

1. Recibe los datos del cliente y del vehículo.
2. Obtiene la tarifa diaria introducida por el usuario.
3. Agrega RD$1000 por día si el cliente selecciona seguro completo.
4. Agrega RD$100 por día si selecciona GPS.
5. Multiplica la tarifa diaria por la cantidad de días.
6. Acumula el subtotal de todos los vehículos alquilados.
7. Aplica un descuento del 15 % si el cliente es corporativo.
8. Agrega RD$2000si la entrega es a domicilio.
9. Calcula el ITBIS del 18 % sobre la base imponible.
10. Muestra el total final que debe pagar el cliente.

 5. Salida

El programa presenta los siguientes resultados:

- Lista de vehículos alquilados.
- Tarifa diaria de cada vehículo.
- Total por cada línea de alquiler.
- Subtotal.
- Descuento corporativo.
- Cargo por entrega a domicilio.
- ITBIS (18 %).
- Total general a pagar.
## 6. Capturas de pantalla

### Pantalla principal del sistema

En esta imagen se muestra la interfaz principal de RentaCar Express, donde se registran los datos del cliente y del vehículo, se selecciona el seguro y el tipo de entrega.

![Pantalla principal](imagenes/pantalla-principal.png)

### Resumen del alquiler

En esta imagen se muestra el resultado del cálculo del alquiler, incluyendo el subtotal, descuento corporativo, costo de domicilio, ITBIS y total a pagar.

![Resumen del alquiler](imagenes/resumen-alquiler.png)