package es.grupo4.guardiascentro.controlador;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;


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

@GetMapping("/{profesor0_.id}/{diaSemana}/")
public ResponseEntity<?> getHorarios(@RequestParam(name = "profesor id") Integer profesorId,@RequestParam(name = "diaSemana") Integer diaSemana) {
	List<Horario> horarios=horarioRepositorio
			.findAll()
			.stream()
			.filter(x->x.getProfesor().getId()==profesorId && x.getDiaSemana()==diaSemana)
			.toList();
	
	if(horarios.isEmpty()) 
		return ResponseEntity.notFound().build();
	
	return ResponseEntity.ok(horarios); //el to string.	

}

}
