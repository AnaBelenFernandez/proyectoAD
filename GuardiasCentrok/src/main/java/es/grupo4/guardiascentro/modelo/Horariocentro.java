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
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	private Time horafin;

	private Time horainicio;

	private String turno;

	public Horariocentro() {
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

}