package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;


import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.databind.JsonDeserializer;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;

import java.util.List;


/**
 * The persistent class for the horario database table.
 * 
 */
@Entity
@Table(name="horario")
@NamedQuery(name="Horario.findAll", query="SELECT h FROM Horario h")
public class Horario implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private Integer id;

	private String aula;

	@Column(name="dia_semana")
	private Integer diaSemana;

	@Column(name="genera_guardia")
	private Byte generaGuardia;

	private String grupo;

	private String materia;

	//bi-directional many-to-one association to AvisosGuardia
	@OneToMany(mappedBy="horarioBean")
	@JsonIgnore
	private List<AvisosGuardia> avisosGuardias;

	//bi-directional many-to-one association to Guardia
	@OneToMany(mappedBy="horarioBean")
	@JsonIgnore
	private List<Guardia> guardias;

	//bi-directional many-to-one association to Horariocentro
	@ManyToOne
	@JoinColumn(name="hora")
	private Horariocentro horariocentro;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="profesor")
	private Profesor profesor;

	public Horario() {
	}

	public Horario(int asInt) {
		// TODO Auto-generated constructor stub
		this.id=asInt;
	}

	public Integer getId() {
		return this.id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getAula() {
		return this.aula;
	}

	public void setAula(String aula) {
		this.aula = aula;
	}

	public Integer getDiaSemana() {
		return this.diaSemana;
	}

	public void setDiaSemana(Integer diaSemana) {
		this.diaSemana = diaSemana;
	}

	public Byte getGeneraGuardia() {
		return generaGuardia;
	}

	public void setGeneraGuardia(Byte generaGuardia) {
		this.generaGuardia = generaGuardia;
	}

	public String getGrupo() {
		return this.grupo;
	}

	public void setGrupo(String grupo) {
		this.grupo = grupo;
	}

	public String getMateria() {
		return this.materia;
	}

	public void setMateria(String materia) {
		this.materia = materia;
	}

	public List<AvisosGuardia> getAvisosGuardias() {
		return this.avisosGuardias;
	}

	public void setAvisosGuardias(List<AvisosGuardia> avisosGuardias) {
		this.avisosGuardias = avisosGuardias;
	}

	public AvisosGuardia addAvisosGuardia(AvisosGuardia avisosGuardia) {
		getAvisosGuardias().add(avisosGuardia);
		avisosGuardia.setHorarioBean(this);

		return avisosGuardia;
	}

	public AvisosGuardia removeAvisosGuardia(AvisosGuardia avisosGuardia) {
		getAvisosGuardias().remove(avisosGuardia);
		avisosGuardia.setHorarioBean(null);

		return avisosGuardia;
	}

	public List<Guardia> getGuardias() {
		return this.guardias;
	}

	public void setGuardias(List<Guardia> guardias) {
		this.guardias = guardias;
	}

	public Guardia addGuardia(Guardia guardia) {
		getGuardias().add(guardia);
		guardia.setHorarioBean(this);

		return guardia;
	}

	public Guardia removeGuardia(Guardia guardia) {
		getGuardias().remove(guardia);
		guardia.setHorarioBean(null);

		return guardia;
	}

	public Horariocentro getHorariocentro() {
		return this.horariocentro;
	}

	public void setHorariocentro(Horariocentro horariocentro) {
		this.horariocentro = horariocentro;
	}

	public Profesor getProfesor() {
		return this.profesor;
	}

	public void setProfesor(Profesor profesor) {
		this.profesor = profesor;
	}

	@Override
	public String toString() {
		return "Horario [id=" + id + ", aula=" + aula + ", diaSemana=" + diaSemana + ", generaGuardia=" + generaGuardia
				+ ", grupo=" + grupo + ", materia=" + materia + ", horariocentro=" + horariocentro.getId() + ", profesor=" + profesor.getId() + "]";
	}

}