package es.grupo4.guardiascentro.controlador;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.grupo4.guardiascentro.modelo.AvisosGuardia;
import es.grupo4.guardiascentro.modelo.Horario;
import es.grupo4.guardiascentro.modelo.HorarioRepositorio;

@RestController
@RequestMapping("/api/horarios")
public class HorarioController {
private final HorarioRepositorio horarioRepositorio;

public HorarioController(HorarioRepositorio horarioRepositorio) {
	super();
	this.horarioRepositorio = horarioRepositorio;
}

/**
 * Método que devuelve la lista de todos los horarios
 */
@GetMapping("/devuelveTodos")
public ResponseEntity<?> getAll(){
	List<Horario> horarios=horarioRepositorio.findAll();
	if(horarios.isEmpty())
		return ResponseEntity.notFound().build();
	return ResponseEntity.ok(horarios);
}

/**
 * Método que devuelve un horario por profesor y día de la semana.
 * @param profesorId
 * @param diaSemana
 * @return
 */
@GetMapping("/{profesor0_.id}/{diaSemana}/")
public ResponseEntity<?> getHorarios(@RequestParam(name = "profesor id") Integer profesorId,@RequestParam(name = "diaSemana") Integer diaSemana) {
	List<Horario> horarios=horarioRepositorio
			.findAll()
			.stream()
			.filter(x->x.getProfesor().getId()==profesorId && x.getDiaSemana()==diaSemana)
			.toList();
	
	if(horarios.isEmpty()) 
		return ResponseEntity.notFound().build();
	
	return ResponseEntity.ok(horarios);	

}

/**
 * Método que devuelve todos los horarios del profesor.
 * @param id
 * @return
 */
@GetMapping("/getTodosProfesor/{profesor0_.id}")
public ResponseEntity<?> obtenerHorariosProfesor(@RequestParam Integer id){
	List<Horario> horarios=horarioRepositorio.findAll().stream().filter(h->h.getProfesor().getId()==id).toList();
	if(horarios.isEmpty())
		return ResponseEntity.notFound().build();
	return ResponseEntity.ok(horarios);
}
}
