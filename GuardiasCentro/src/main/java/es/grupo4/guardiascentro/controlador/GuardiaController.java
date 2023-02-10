package es.grupo4.guardiascentro.controlador;



import es.grupo4.guardiascentro.modelo.AvisosGuardia;
import es.grupo4.guardiascentro.modelo.Guardia;
import es.grupo4.guardiascentro.modelo.GuardiaRepositorio;
import es.grupo4.guardiascentro.modelo.Profesor;
import es.grupo4.guardiascentro.controlador.*;

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

import es.grupo4.*;


@RestController
@RequestMapping("/api")
public class GuardiaController {

	private final GuardiaRepositorio guardiaRepositorio;

	public GuardiaController(GuardiaRepositorio guardiaRepositorio) {
		this.guardiaRepositorio = guardiaRepositorio;
	}

	/**
	 * Método para obtener la lista de guardias de la api
	 * @return
	 */
	
	@GetMapping("/guardias")
	public ResponseEntity<?> obtenerGuardias()
	{
	List<Guardia> guardias = guardiaRepositorio.findAll();
	if(guardias.isEmpty())
		return ResponseEntity.notFound().build();
	return ResponseEntity.ok(guardias);
	}
/**
 * Método para obtener una guardia a partir del id
 * @param id
 * @return
 */

	@GetMapping("/guardias/{id}")
	public ResponseEntity<?> obtenerGuardiaId(@PathVariable Integer id)
	{
	Guardia guardia = guardiaRepositorio.findById(id).orElse(null);
	if(guardia==null)
	return ResponseEntity.notFound().build();
	return ResponseEntity.ok(guardia);
	}
	
	

/**
 * Método para crear una guardia
 * @param nueva
 * @return
 */
	
	@PostMapping("/guardias")
	public ResponseEntity<Guardia> nuevaGuardia(@RequestBody Guardia nueva)
	{
	Guardia guardada = guardiaRepositorio.save(nueva);
	return
	ResponseEntity.status(HttpStatus.CREATED).body(guardada);
	}

/**
 * Método para actualizar Guardia por cualquier campo, hay que pasarle el objeto
 * @param editar
 * @param id
 * @param profesor
 * @return
 */
	@PutMapping("/guardias/{id}")
	public ResponseEntity<?> actualizarGuardia(@RequestBody Guardia editar,
	@PathVariable Integer id)
	{
	Guardia guardia = guardiaRepositorio.findById(id).orElse(null);
	if(guardia==null)
	return ResponseEntity.notFound().build();
	guardia.setAula(editar.getAula());
	guardia.setAvisosGuardia(editar.getAvisosGuardia());
	guardia.setDiaSemana(editar.getDiaSemana());
	guardia.setEstado(editar.getEstado());
	guardia.setFecha(editar.getFecha());
	guardia.setGrupo(editar.getGrupo());
	guardia.setHora(editar.getHora());
	guardia.setHorarioBean(editar.getHorarioBean());
	guardia.setId(editar.getId());//innecesario¿no?
	guardia.setObservaciones(editar.getObservaciones());
	guardia.setProfesor1(editar.getProfesor1());
	guardia.setProfesor2(guardia.getProfesor2());	
	return ResponseEntity.ok(guardiaRepositorio.save(guardia));
	}

	/**
	 * Método para borrar una guardia
	 * @param id
	 * @return
	 */
	@DeleteMapping("/guardias/{id}")
	public ResponseEntity<?> borrarGuardia(@PathVariable Integer id)
	{
	guardiaRepositorio.deleteById(id);
	return ResponseEntity.noContent().build();
	}

}