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

	//bi-directional many-to-one association to AvisosGuardia
	@ManyToOne
	@JoinColumn(name="aviso")
	private AvisosGuardia avisosGuardia;

	//bi-directional many-to-one association to Horario
	@ManyToOne
	@JoinColumn(name="horario")
	private Horario horarioBean;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="prof_falta")
	private Profesor profesor1;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="prof_hace_guardia")
	private Profesor profesor2;

	public Guardia() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
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

	public String getEstado() {
		return this.estado;
	}

	public void setEstado(String estado) {
		this.estado = estado;
	}

	public Date getFecha() {
		return this.fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public String getGrupo() {
		return this.grupo;
	}

	public void setGrupo(String grupo) {
		this.grupo = grupo;
	}

	public Integer getHora() {
		return this.hora;
	}

	public void setHora(Integer hora) {
		this.hora = hora;
	}

	public String getObservaciones() {
		return this.observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public AvisosGuardia getAvisosGuardia() {
		return this.avisosGuardia;
	}

	public void setAvisosGuardia(AvisosGuardia avisosGuardia) {
		this.avisosGuardia = avisosGuardia;
	}

	public Horario getHorarioBean() {
		return this.horarioBean;
	}

	public void setHorarioBean(Horario horarioBean) {
		this.horarioBean = horarioBean;
	}

	public Profesor getProfesor1() {
		return this.profesor1;
	}

	public void setProfesor1(Profesor profesor1) {
		this.profesor1 = profesor1;
	}

	public Profesor getProfesor2() {
		return this.profesor2;
	}

	public void setProfesor2(Profesor profesor2) {
		this.profesor2 = profesor2;
	}

}