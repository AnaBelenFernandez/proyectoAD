package es.grupo4.guardiascentro.controlador;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.grupo4.guardiascentro.modelo.HorarioGuardiaRepositorio;
import es.grupo4.guardiascentro.modelo.Horarioguardia;


@RestController
@RequestMapping("/api/horarioGuardia")
public class HorarioGuardiaController {
	@Autowired
	private final HorarioGuardiaRepositorio horarioGuardiaRepositorio;

	public HorarioGuardiaController(HorarioGuardiaRepositorio horarioGuardiaRepositorio) {
		this.horarioGuardiaRepositorio = horarioGuardiaRepositorio;
	}
	
	@GetMapping("/buscar/{profesor1_.id}")
	public ResponseEntity<?> obtenerUno(@RequestParam Integer id)
	{
		List<Horarioguardia> horarios=horarioGuardiaRepositorio.findAll().stream().filter(h->h.getProfesor()==id).toList();
		if(horarios.isEmpty())
			return ResponseEntity.status(HttpStatus.NOT_FOUND).body("No se han encontrado horarios de guardias asociadas al profesor."); 
		return ResponseEntity.ok(horarios);
	}
}
