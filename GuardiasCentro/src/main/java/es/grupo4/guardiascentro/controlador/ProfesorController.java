package es.grupo4.guardiascentro.controlador;

import java.util.List;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import es.grupo4.guardiascentro.modelo.Guardia;
import es.grupo4.guardiascentro.modelo.Profesor;
import es.grupo4.guardiascentro.modelo.ProfesorRepositorio;


@RestController
@RequestMapping("/api")
public class ProfesorController {
private final ProfesorRepositorio profesorRepositorio;
	
	
	public ProfesorController(ProfesorRepositorio profesorRepositorio) {
	//super();
	this.profesorRepositorio = profesorRepositorio;
 }
/**
 * Método para obtener una lista de profesores de la API
 * @return
 */

	@GetMapping("profesores")
	public ResponseEntity<?> obtenerListaProfesores()
	{
		List<Profesor> profesores = profesorRepositorio.findAll();
		if(profesores.isEmpty())
			return ResponseEntity.notFound().build();
		return ResponseEntity.ok(profesores);
	}
	/**
	 * Método para obtener un profesor por id de la API
	 * @param id
	 * @return
	 */
	
	@GetMapping("profesores/{id}")
	public ResponseEntity<?> obtenerUno(@PathVariable Integer id)
	{
		Profesor profesor=profesorRepositorio.findById(id).orElse(null);
		if(profesor==null)
			return ResponseEntity.notFound().build();
		return ResponseEntity.ok(profesor);
	}
	
	/**
	 * Método para crear un profesor
	 * @param nuevo
	 * @return
	 */
	@PostMapping("/profesores")
	public Profesor nuevoProfesor(@RequestBody Profesor nuevo) {
		return profesorRepositorio.save(nuevo);
	}
	/**
	 * Crear un profesor devolviendo booleano
	 * @param nuevo
	 * @return
	 */
	
	@PostMapping("/profesoresBool")
	public boolean nuevoProfesorBool(@RequestBody Profesor nuevo) {
		Profesor profesor=profesorRepositorio.save(nuevo);
		if(profesor!=null) {
			return true;
		}
		else {
			return false;
		}
		
	}
	
	/**
	 * Método para actualizar un profesor por cualquier campo
	 * @param editar
	 * @param id
	 * @return
	 */
	
	@PutMapping("/profesores/{id}")
	public ResponseEntity<?> actualizarProfesor(@RequestBody Profesor editar,
	@PathVariable Integer id)
	{
	Profesor profesor = profesorRepositorio.findById(id).orElse(null);
	if(profesor==null)
	return ResponseEntity.notFound().build();
	profesor.setActivo(editar.getActivo());
	profesor.setApe1(editar.getApe1());
	profesor.setApe2(editar.getApe2());
	profesor.setBaja(editar.getBaja());
	profesor.setDeptCod(editar.getDeptCod());
	profesor.setDni(editar.getDni());
	profesor.setId(editar.getId());
	profesor.setIdSustituye(editar.getIdSustituye());
	profesor.setNombre(editar.getNombre());
	profesor.setPassword(editar.getPassword());
	profesor.setTfno(editar.getTfno());
	profesor.setUser(editar.getUser());
	return ResponseEntity.ok(profesorRepositorio.save(profesor));
	}
	
/**
 * Método para borrar un profesor
 * @param id
 * @return
 */
	@DeleteMapping("/profesores/{id}")
	public Profesor borrarProfesor(@PathVariable Integer id) {
		if (profesorRepositorio.existsById(id)) {
			Profesor profesor = profesorRepositorio.findById(id).get();
			profesorRepositorio.delete(profesor);
			return profesor;
		} else {
			return null;
		}
	}
	

	

}
