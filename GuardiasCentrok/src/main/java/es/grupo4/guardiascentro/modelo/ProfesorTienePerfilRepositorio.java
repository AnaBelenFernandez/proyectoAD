package es.grupo4.guardiascentro.modelo;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface ProfesorTienePerfilRepositorio extends JpaRepository<ProfesorTienePerfil,Integer>{

}
