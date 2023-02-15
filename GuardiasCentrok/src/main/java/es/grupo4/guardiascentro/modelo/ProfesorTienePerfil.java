package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the profesor_tiene_perfil database table.
 * 
 */
@Entity
@Table(name="profesor_tiene_perfil")
@NamedQuery(name="ProfesorTienePerfil.findAll", query="SELECT p FROM ProfesorTienePerfil p")
public class ProfesorTienePerfil implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int id;

	//bi-directional many-to-one association to Perfil
	@ManyToOne
	@JoinColumn(name="perfil")
	private Perfil perfile;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="profesor")
	private Profesor profesor;

	public ProfesorTienePerfil() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Perfil getPerfile() {
		return this.perfile;
	}

	public void setPerfile(Perfil perfile) {
		this.perfile = perfile;
	}

	public Profesor getProfesor() {
		return this.profesor;
	}

	public void setProfesor(Profesor profesor) {
		this.profesor = profesor;
	}

}