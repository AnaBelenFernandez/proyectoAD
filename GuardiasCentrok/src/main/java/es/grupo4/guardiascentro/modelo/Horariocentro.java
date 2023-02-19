package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;

import java.sql.Time;
import java.util.List;


/**
 * The persistent class for the horariocentro database table.
 * 
 */
@Entity
@Table(name = "horariocentro")
@NamedQuery(name="Horariocentro.findAll", query="SELECT h FROM Horariocentro h")
public class Horariocentro implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private Integer id;

	private Time horafin;

	private Time horainicio;

	private String turno;

	//bi-directional many-to-one association to Horario
	@OneToMany(mappedBy="horariocentro")
	@JsonIgnore
	private List<Horario> horarios;

	//bi-directional many-to-one association to Horarioguardia
	@OneToMany(mappedBy="horariocentro")
	@JsonIgnore
	private List<Horarioguardia> horarioguardias;
	public Horariocentro() {
	}

	public Horariocentro(int asInt) {
		this.id=asInt;
	}

	public Integer getId() {
		return this.id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public Time getHorafin() {
		return this.horafin;
	}

	public void setHorafin(Time horafin) {
		this.horafin = horafin;
	}

	public Time getHorainicio() {
		return this.horainicio;
	}

	public void setHorainicio(Time horainicio) {
		this.horainicio = horainicio;
	}

	public String getTurno() {
		return this.turno;
	}

	public void setTurno(String turno) {
		this.turno = turno;
	}

	public List<Horario> getHorarios() {
		return this.horarios;
	}

	public void setHorarios(List<Horario> horarios) {
		this.horarios = horarios;
	}

	public Horario addHorario(Horario horario) {
		getHorarios().add(horario);
		horario.setHorariocentro(this);

		return horario;
	}

	public Horario removeHorario(Horario horario) {
		getHorarios().remove(horario);
		horario.setHorariocentro(null);

		return horario;
	}

	public List<Horarioguardia> getHorarioguardias() {
		return this.horarioguardias;
	}

	public void setHorarioguardias(List<Horarioguardia> horarioguardias) {
		this.horarioguardias = horarioguardias;
	}

	public Horarioguardia addHorarioguardia(Horarioguardia horarioguardia) {
		getHorarioguardias().add(horarioguardia);
		horarioguardia.setHorariocentro(this);

		return horarioguardia;
	}

	public Horarioguardia removeHorarioguardia(Horarioguardia horarioguardia) {
		getHorarioguardias().remove(horarioguardia);
		horarioguardia.setHorariocentro(null);

		return horarioguardia;
	}

}