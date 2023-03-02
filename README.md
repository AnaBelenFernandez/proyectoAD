### API GUARDIAS CENTRO
---

### ÍNDICE
1. [INTRODUCCIÓN](#introducción)
2. [CONFIGURACIÓN](#configuración)
3. [CONTROLADOR](#controlador)
4. [MODELO](#modelo)
5. [MÉTODOS](#métodos)

## INTRODUCCIÓN
API para la gestión de guardias, Nos permite establecer la comunicación entre la base de datos y las aplicaciones. 

## CONFIGURACIÓN
En la capa de configuración, se encuentra el Swagger, en la clase SwaggerObject.java , que es desde donde hemos realizado las pruebas, para comprobar las peticiones y el funcionamiento, con este támbien podemos documentar de forma más visual la API.

## CONTROLADOR
Se encuentran los objetos que se ejecutaran al recibir las peticiones, en este caso, serán: AvisoController.java, GuardiaController.java, HorarioController.java, HorarioGuardiaController.java, ProfesorController.java y ProfesorTienePerfilController.java.

## MODELO
En este paquete encontramos las clases, repositorios y enumerados, que dan forma a los datos que esta devuelve. Nos permitira mapear los objetos correctamente, establecer, nulos, nombres de columnas sobras las cuales hacen referencia los campos.

## MÉTODOS

 **Aviso**
 ```sh
  obtenerListaAvisos()
  obtenerAvisosIdProfesor(@RequestParam Integer id)
  crearAviso(@RequestBody AvisosGuardia nuevo)
  actualizarAviso(@RequestBody AvisosGuardia editar, @PathVariable Integer id)
  borrarAviso(@PathVariable Integer id)
  ```
  
 **Guardia**
 ```sh
   obtenerGuardias()
  obtenerGuardiaId(@PathVariable Integer id)
  nuevaGuardia(@RequestBody Guardia nueva)
  actualizarGuardia(@RequestBody Guardia editar, @PathVariable Integer id)
  borrarGuardia(@PathVariable Integer id)
  obtenerGuardiasSinSustitucion()
  setGuardiaEstado(@PathVariable Integer id,@RequestParam Estado estado)
 ```
 
 **Horario**
 ```sh
  getAll()
  getHorarios(@RequestParam(name = "profesor id") Integer profesorId,@RequestParam(name = "diaSemana") Integer diaSemana)
  obtenerHorariosProfesor(@RequestParam Integer id)
  setIdSustitucion(@PathVariable Integer id,@RequestParam Byte genera)
 ```
 
 **Horario guardia**
 ```sh
  obtenerUno(@RequestParam Integer id)
  setRealizadas(@RequestParam Integer profesorId, @RequestParam Integer diaSemana, @RequestParam Integer horario)
 ```
 
 **Profesor**
 ```sh
  obtenerListaProfesores()
  obtenerUno(@PathVariable Integer id)
  login(@RequestParam String user, @RequestParam String pwd)
  nuevoProfesor(@RequestBody Profesor nuevo)
  actualizarProfesor(@RequestBody Profesor editar,@PathVariable Integer id)
  borrarProfesor(@PathVariable Integer id)
  setIdSustitucion(@PathVariable Integer id,@RequestParam Integer idSustitucion)
  ```
  
  **Profesor tiene perfil**
  ```sh 
  obtenerPerfil(@RequestParam Integer id)
  ```
---

```sh
PROYECTO REALIZADO POR:
Jesús Bueno González
Ana Belen Fernández San Miguel
Andrea Murillo González
Laura Tejera Aldazábal
```
