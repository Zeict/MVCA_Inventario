Es un sistema ASP.NET MVC que cuenta con los siguientes modulos:
- Menu
  - Inicio
  - Inventario de Productos
    - Agregar Productos
    - Consultar Productos
    - Eliminar Productos
## Instalación

Se requiere Visual Studio(Asp.NET (.Net Framework)/C#) y MSSQL Express Version 13.0
- Restaurar base de datos en MSSQL `inventarioJuguetes.bak`
- Abrir solucion de Visual Studio `MVCA_Inventario.sln`
- Buscar archivo `Web.Config` donde se editara la siguiente cadena de conexión a base de datos.
```bash
<add name="Connection" connectionString="Data Source= ;Initial Catalog=inventarioJuguetes;Integrated Security=True; User ID=sa;Password=123" providerName="System.Data.SqlClient"/>
```
## Uso
### Menú principal
- Al acceder nos muestra una pagina de inicio donde nos da la bienvenida, un navbar a la izquierda que tiene como opciones Inicio, Inventario también podemos ocultar este menú y cuenta con una opcion para ir al modulo de inventario de productos.

### Inventario de productos
- Esta vista cuenta con un boton en la parte superior derecha la cual nos permitira agregar nuevos productos, al entrar en esta opcion se nos mostrara un modal que nos mostrara un formulario con los detalles necesarios del producto para añadirlos a nuestra base de datos.
- Una vez que se agregan nuevos productos a la base de datos, este nos mostrara automáticamente los productos registrados en la tabla.
- Nuestra tabla mostrara todos los productos que ya hayan sido registrados anteriormente, tambien dentro de la tabla tenemos la opcion de editar o eliminar los productos que se encuentran registrados.
