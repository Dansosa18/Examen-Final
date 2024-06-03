Proyecto Final: ELaboracion de una aplicacion de Windows Forms (.NET Framework)utilizando C# y MySQL que permita realizar
operaciones CRUD (Create, Read, Update, Delete) sobre una tabla de base de datos. 

En la cual se implementan siertas acciones mediante bottones, texbox, y muchas herramientas de formularios

en base las operaciones CRUD que son :
| Create (Crear) | Agregar nuevas mascotas a la base de datos, incluyendo información como nombre, raza, nombre del dueño, etc

| Read (Leer) | Consultar la lista de mascotas alojadas en la guardería

| Uptade (Actualizar) | Modificar la información de las mascotas

| Delete (Eliminar) | Eliminar mascotas de la base de datos.

todo implementado sobre una tabla de una base de datos de una "GUARDERIA DE MASCOTAS"


`#0969DA`**PARA LA CREACION DE LA TABLA EN CUALQUIER BASE DE DATOS (DE PREFERENCIA UNA NUEVA)**

CREATE TABLE mascotas (
  id_mascota INT PRIMARY KEY AUTO_INCREMENT,
  
  tipo_mascota VARCHAR(255) NOT NULL,
  
  raza VARCHAR(255) NOT NULL,
  
  nombre VARCHAR(255) NOT NULL,
  
  sexo ENUM('M', 'F') NOT NULL,
  
  fecha_nacimiento datetime NOT NULL,

  color VARCHAR(255),
  
  nombredueno varchar(255) not null,
  
   telefono VARCHAR(20) NOT NULL

);
