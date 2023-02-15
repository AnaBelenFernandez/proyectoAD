package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;
import java.util.Date;


/**
 * The persistent class for the bajas_permisos database table.
 * 
 */
@Entity
@Table(name="bajas_permisos")
@NamedQuery(name="BajasPermiso.findAll", query="SELECT b FROM BajasPermiso b")
public class BajasPermiso implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int idbaja;

	@Temporal(TemporalType.DATE)
	private Date fechafin;

	@Temporal(TemporalType.DATE)
	private Date fechainicio;

	private String tipo;

	//bi-directional many-to-one association to Profesor
	@ManyToOne
	@JoinColumn(name="profesor")
	private Profesor profesor;

	public BajasPermiso() {
	}

	public int getIdbaja() {
		return this.idbaja;
	}

	public void setIdbaja(int idbaja) {
		this.idbaja = idbaja;
	}

	public Date getFechafin() {
		return this.fechafin;
	}

	public void setFechafin(Date fechafin) {
		this.fechafin = fechafin;
	}

	public Date getFechainicio() {
		return this.fechainicio;
	}

	public void setFechainicio(Date fechainicio) {
		this.fechainicio = fechainicio;
	}

	public String getTipo() {
		return this.tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public Profesor getProfesor() {
		return this.profesor;
	}

	public void setProfesor(Profesor profesor) {
		this.profesor = profesor;
	}

}