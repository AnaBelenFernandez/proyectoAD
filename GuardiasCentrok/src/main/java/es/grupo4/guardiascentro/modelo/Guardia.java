package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;

import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;

import java.util.Date;


/**
 * The persistent class for the guardias database table.
 * 
 */
@Entity
@Table(name="guardias")
@NamedQuery(name="Guardia.findAll", query="SELECT g FROM Guardia g")
public class Guardia implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int id;

	private String aula;

	@Column(name="dia_semana")
	private Integer diaSemana;

	private String estado;

	@Temporal(TemporalType.DATE)
	private Date fecha;

	private String grupo;

	private Integer hora;

	@Lob
	private String observaciones;

	@Column(name="aviso")
	private Integer avisosGuardia;

	@Column(name="horario")
	private Integer horario;

	@Column(name="prof_falta")
	private Integer profesorFalta;

	@Column(name="prof_hace_guardia")
	private Integer profesorGuardia;

	public Guardia() {
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getAula() {
		return aula;
	}

	public void setAula(String aula) {
		this.aula = aula;
	}

	public Integer getDiaSemana() {
		return diaSemana;
	}

	public void setDiaSemana(Integer diaSemana) {
		this.diaSemana = diaSemana;
	}

	public String getEstado() {
		return estado;
	}

	public void setEstado(String estado) {
		this.estado = estado;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public String getGrupo() {
		return grupo;
	}

	public void setGrupo(String grupo) {
		this.grupo = grupo;
	}

	public Integer getHora() {
		return hora;
	}

	public void setHora(Integer hora) {
		this.hora = hora;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public Integer getAvisosGuardia() {
		return avisosGuardia;
	}

	public void setAvisosGuardia(Integer avisosGuardia) {
		this.avisosGuardia = avisosGuardia;
	}

	public Integer getHorarioBean() {
		return horario;
	}

	public void setHorarioBean(Integer horarioBean) {
		this.horario = horarioBean;
	}

	public Integer getProfesor1() {
		return profesorFalta;
	}

	public void setProfesor1(Integer profesor1) {
		this.profesorFalta = profesor1;
	}

	public Integer getProfesor2() {
		return profesorGuardia;
	}

	public void setProfesor2(Integer profesor2) {
		this.profesorGuardia = profesor2;
	}

	

}