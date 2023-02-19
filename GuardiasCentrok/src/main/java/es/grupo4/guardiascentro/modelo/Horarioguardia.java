package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;

import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;


/**
 * The persistent class for the horarioguardias database table.
 * 
 */
@Entity
@Table(name="horarioguardias")
@NamedQuery(name="Horarioguardia.findAll", query="SELECT h FROM Horarioguardia h")
public class Horarioguardia implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	@Column(name="dia_semana")
	private Integer diaSemana;

	private Integer realizadas;

	//bi-directional many-to-one association to Horariocentro
	@ManyToOne
	@JoinColumn(name="hora_guardia")
	private Horariocentro horariocentro;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="profesor")
	private Profesor profesor;

	public Horarioguardia() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Integer getDiaSemana() {
		return this.diaSemana;
	}

	public void setDiaSemana(Integer diaSemana) {
		this.diaSemana = diaSemana;
	}

	public Integer getRealizadas() {
		return this.realizadas;
	}

	public void setRealizadas(Integer realizadas) {
		this.realizadas = realizadas;
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

}