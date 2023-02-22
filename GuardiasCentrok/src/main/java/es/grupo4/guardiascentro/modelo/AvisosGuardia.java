package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;

import com.fasterxml.jackson.annotation.*;

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

	@Column(name="horario")
	private Integer horario;

	@Column(name="profesor")
	private Integer profesor;

	public AvisosGuardia() {
	}

	public int getIdAviso() {
		return idAviso;
	}

	public void setIdAviso(int idAviso) {
		this.idAviso = idAviso;
	}

	public byte getAnulado() {
		return anulado;
	}

	public void setAnulado(byte anulado) {
		this.anulado = anulado;
	}

	public byte getConfirmado() {
		return confirmado;
	}

	public void setConfirmado(byte confirmado) {
		this.confirmado = confirmado;
	}

	public Date getFechaGuardia() {
		return fechaGuardia;
	}

	public void setFechaGuardia(Date fechaGuardia) {
		this.fechaGuardia = fechaGuardia;
	}

	public Date getFechaHoraAviso() {
		return fechaHoraAviso;
	}

	public void setFechaHoraAviso(Date fechaHoraAviso) {
		this.fechaHoraAviso = fechaHoraAviso;
	}

	public String getMotivo() {
		return motivo;
	}

	public void setMotivo(String motivo) {
		this.motivo = motivo;
	}

	public String getObservaciones() {
		return observaciones;
	}

	public void setObservaciones(String observaciones) {
		this.observaciones = observaciones;
	}

	public Integer getHorarioBean() {
		return horario;
	}

	public void setHorarioBean(Integer horarioBean) {
		this.horario = horarioBean;
	}

	public Integer getProfesor() {
		return profesor;
	}

	public void setProfesor(Integer profesor) {
		this.profesor = profesor;
	}

}