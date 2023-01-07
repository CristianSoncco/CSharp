# Cristian Soncco
## Inyectando las dependencias.

.NET tiene un contenedor de dependencias, al registrar el servicio y la interface que representa la abstraccion de ese servicio,
dicho contenedor de dependencias nos devuelve la misma instancia todas las veces que la solicitemos.
El contenedor de dependencias sirve para evitar la creacion de multiples conexiones, repositorios, servicos,etc. Permite
que las instancias sean cada una un singleton. Es decir, que el mismo espacio de memoria(instancia)se devuelva, 
mediante el reuso del mismo objeto cada vez que nos haga falta en una implementacion de esa abstraccion.
El logro es desacoplar nuestras capas, de manera que todas las dependencias sean inyectadas. Usemos abstracción en lugar 
de implementaciones concretas.

[crisonbo]

- [crisonbo] - https://www.linkedin.com/in/cristian-soncco/