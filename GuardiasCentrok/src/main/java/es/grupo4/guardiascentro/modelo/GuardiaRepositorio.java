package es.grupo4.guardiascentro.modelo;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface GuardiaRepositorio extends JpaRepository<Guardia, Integer>{
	
	Optional<Guardia> findById(Integer id);
	
	@Query(value="SELECT g FROM Guardia g WHERE g.profesor2 IS NULL")
	public List<Guardia> getGuardiasSinCubrir();
	
	@Query(value="select g from Guardia g "
			+ " where  (g.hora in (select hg.horariocentro "
			+ " from Horarioguardia hg LEFT JOIN hg.profesor prof where prof.id=:id) "
			+ " and g.diaSemana in (select hg.diaSemana "
			+ " from Horarioguardia hg LEFT JOIN hg.profesor prof where prof.id=:id)) AND"
			+ " g.profesor2 is null")
	public List<Guardia> getPosiblesGuardias(@Param("id") Integer id);
	
	
}
