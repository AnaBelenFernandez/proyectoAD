package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;
import java.util.Date;
import java.util.List;


/**
 * The persistent class for the avisos_guardia database table.
 * 
 */
@Entity
@Table(name="avisos_guardia")
@NamedQuery(name="AvisosGuardia.findAll", query="SELECT a FROM AvisosGuardia a")
public class AvisosGuardia implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="id_aviso")
	private int idAviso;

	private byte anulado;

	private byte confirmado;

	@Temporal(TemporalType.DATE)
	@Column(name="fecha_guardia")
	private Date fechaGuardia;

	@Temporal(TemporalType.TIMESTAMP)
	@Column(name="fecha_hora_aviso")
	private Date fechaHoraAviso;

	private String motivo;

	@Lob
	private String observaciones;

	//bi-directional many-to-one association to Horario
	@ManyToOne
	@JoinColumn(name="horario")
	private Horario horarioBean;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="profesor")
	private Profesor profesor;

	//bi-directional many-to-one association to Guardia
	@OneToMany(mappedBy="avisosGuardia")
	private List<Guardia> guardias;

	public AvisosGuardia() {
	}

	public int getIdAviso() {
		return this.idAviso;
	}

	public void setIdAviso(int idAviso) {
		this.idAviso = idAviso;
	}

	public byte getAnulado() {
		return this.anulado;
	}

	public void setAnulado(byte anulado) {
		this.anulado = anulado;
	}

	public byte getConfirmado() {
		return this.confirmado;
	}

	public void setConfirmado(byte confirmado) {
		this.confirmado = confirmado;
	}

	public Date getFechaGuardia() {
		return this.fechaGuardia;
	}

	public void setFechaGuardia(Date fechaGuardia) {
		this.fechaGuardia = fechaGuardia;
	}

	public Date getFechaHoraAviso() {
		return this.fechaHoraAviso;
	}

	public void setFechaHoraAviso(Date fechaHoraAviso) {
		this.fechaHoraAviso = fechaHoraAviso;
	}

	public String getMotivo() {
		return this.motivo;
	}

	public void setMotivo(String motivo) {
		this.motivo = motivo;
	}

	public String getObservaciones() {
		return this.observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public Horario getHorarioBean() {
		return this.horarioBean;
	}

	public void setHorarioBean(Horario horarioBean) {
		this.horarioBean = horarioBean;
	}

	public Profesor getProfesor() {
		return this.profesor;
	}

	public void setProfesor(Profesor profesor) {
		this.profesor = profesor;
	}

	public List<Guardia> getGuardias() {
		return this.guardias;
	}

	public void setGuardias(List<Guardia> guardias) {
		this.guardias = guardias;
	}

	public Guardia addGuardia(Guardia guardia) {
		getGuardias().add(guardia);
		guardia.setAvisosGuardia(this);

		return guardia;
	}

	public Guardia removeGuardia(Guardia guardia) {
		getGuardias().remove(guardia);
		guardia.setAvisosGuardia(null);

		return guardia;
	}

}