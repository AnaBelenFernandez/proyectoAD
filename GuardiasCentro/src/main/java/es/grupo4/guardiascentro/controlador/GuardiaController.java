package es.grupo4.guardiascentro.controlador;



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
import org.springframework.web.bind.annotation.RestController;

import es.grupo4.*;


@RestController
public class GuardiaController {

	private final GuardiaRepositorio guardiaRepositorio;

	public GuardiaController(GuardiaRepositorio guardiaRepositorio) {
		this.guardiaRepositorio = guardiaRepositorio;
	}

	@GetMapping("/guardias")
	public List<Guardia> obtenerTodas() {
		return guardiaRepositorio.findAll();
	}

	@GetMapping("/guardias/{id}")
	public Guardia obtenerporId(@PathVariable Integer id) {
		return guardiaRepositorio.findById(id).orElse(null);
	}

	
	@PostMapping("/guardias")
	public ResponseEntity<Guardia> nuevaGuardia(@RequestBody Guardia nueva)
	{
	Guardia guardada = guardiaRepositorio.save(nueva);
	return
	ResponseEntity.status(HttpStatus.CREATED).body(guardada);
	}


	@PutMapping("/guardias/{id}")
	public ResponseEntity<?> editarProfesorGuardia(@RequestBody Guardia editar, @PathVariable Integer id, Profesor profesor) {
		Guardia guardia = guardiaRepositorio.findById(id).orElse(null);
		if (guardia == null)
			return ResponseEntity.notFound().build();
		guardia.setProfesor2(profesor);
		return ResponseEntity.ok(guardiaRepositorio.save(guardia));
	}
	
	@PutMapping("/guardias/{id}")
	public ResponseEntity<?> editarGuardiaRealizada(@RequestBody Guardia editar, @PathVariable Integer id, boolean realizada) {
		Guardia guardia = guardiaRepositorio.findById(id).orElse(null);
		if (guardia == null)
			return ResponseEntity.notFound().build();
		guardia.setEstado("R");
		return ResponseEntity.ok(guardiaRepositorio.save(guardia));
	}
	@DeleteMapping("/guardias/{id}")
	public ResponseEntity<?> borrarGuardia(@PathVariable Integer id)
	{
	guardiaRepositorio.deleteById(id);
	return ResponseEntity.noContent().build();
	}

}