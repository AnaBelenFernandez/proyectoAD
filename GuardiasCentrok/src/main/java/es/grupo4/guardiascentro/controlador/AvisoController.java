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
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.grupo4.guardiascentro.modelo.AvisosGuardia;
import es.grupo4.guardiascentro.modelo.AvisosGuardiaRepositorio;
import es.grupo4.guardiascentro.modelo.GuardiaRepositorio;
@RestController
@RequestMapping("/api/avisos")
public class AvisoController {
	private final AvisosGuardiaRepositorio avisosRepositorio;

	public AvisoController(AvisosGuardiaRepositorio avisosRepositorio) {
		this.avisosRepositorio = avisosRepositorio;
	}
	
	/**
	 * Método para obtener una lista de avisos
	 * @return
	 */
	@GetMapping("/listarTodos")	
	public ResponseEntity<?> obtenerListaAvisos()
	{
	List<AvisosGuardia> avisos = avisosRepositorio.findAll();
	if(avisos.isEmpty())
	return ResponseEntity.notFound().build();
	return ResponseEntity.ok(avisos);
	}
	
	/**
	 * Método para obtener lista de avisos por Id profesor
	 * @param id
	 * @return
	 */	
	@GetMapping("/getAvisosProfesor/{profesor0_.id}")
	public ResponseEntity<?> obtenerAvisosIdProfesor(@RequestParam Integer id){
		List<AvisosGuardia> avisos=avisosRepositorio.findAll().stream().filter(a->a.getProfesor().getId()==id).toList();
		if(avisos.isEmpty())
			return ResponseEntity.notFound().build();
		return ResponseEntity.ok(avisos);
	}
	
	/**
	 * Método para obtener un aviso por id
	 * @param id
	 * @return
	 */	
	@GetMapping("/obtenerAviso/{id}")
	public ResponseEntity<?> obtenerAvisoId(@PathVariable Integer id)
	{
	AvisosGuardia aviso = avisosRepositorio.findById(id).orElse(null);
	if(aviso==null)
		{return ResponseEntity.notFound().build();}
	return ResponseEntity.ok(aviso);
	}
	
	/**
	 * Método para crear un aviso
	 * @param nuevo
	 * @return
	 */
	@PostMapping("/crearAviso")
	public ResponseEntity<AvisosGuardia> CrearAviso(@RequestBody AvisosGuardia nuevo)
	{
	AvisosGuardia guardado = avisosRepositorio.save(nuevo);
	return
	ResponseEntity.status(HttpStatus.CREATED).body(guardado);
	}
	/**
	 * Método para actualizar un aviso
	 * @param editar
	 * @param id
	 * @return
	 */
	@PutMapping("/actualizarAviso/{id}")
	public ResponseEntity<?> actualizarAviso(@RequestBody AvisosGuardia editar,
	@PathVariable Integer id)
	{
	AvisosGuardia aviso = avisosRepositorio.findById(id).orElse(null);
	if(aviso==null)
	return ResponseEntity.notFound().build();	
	aviso.setAnulado(editar.getAnulado());
	aviso.setConfirmado(editar.getConfirmado());

	aviso.setFechaGuardia(editar.getFechaGuardia());
	aviso.setFechaHoraAviso(editar.getFechaHoraAviso());
	aviso.setHorarioBean(editar.getHorarioBean());
	aviso.setIdAviso(editar.getIdAviso());//no creo que esto sea necesario
	aviso.setMotivo(editar.getMotivo());
	aviso.setObservaciones(editar.getObservaciones());
	aviso.setProfesor(editar.getProfesor());
	aviso.setGuardias(editar.getGuardias());	
	return ResponseEntity.ok(avisosRepositorio.save(aviso));
	}
	/**
	 * Método para borrar un archivo
	 * @param id
	 * @return
	 */
	@DeleteMapping("/borrarAviso/{id}")
	public ResponseEntity<?> borrarAviso(@PathVariable Integer id)
	{
	avisosRepositorio.deleteById(id);
	return ResponseEntity.noContent().build();
	}



}
