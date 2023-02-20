package es.grupo4.guardiascentro.modelo;

import java.io.Serializable;
import javax.persistence.*;

import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;

import java.util.List;


/**
 * The persistent class for the perfiles database table.
 * 
 */
@Entity
@Table(name="perfiles")
@NamedQuery(name="Perfil.findAll", query="SELECT p FROM Perfil p")
public class Perfil implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int idperfil;

	@Column(name="nom_perfil")
	private String nomPerfil;

	//bi-directional many-to-one association to ProfesorTienePerfil
	@OneToMany(mappedBy="perfile")
	private List<ProfesorTienePerfil> profesorTienePerfils;

	public Perfil() {
	}

	public int getIdperfil() {
		return this.idperfil;
	}

	public void setIdperfil(int idperfil) {
		this.idperfil = idperfil;
	}

	public String getNomPerfil() {
		return this.nomPerfil;
	}

	public void setNomPerfil(String nomPerfil) {
		this.nomPerfil = nomPerfil;
	}

	public List<ProfesorTienePerfil> getProfesorTienePerfils() {
		return this.profesorTienePerfils;
	}

	public void setProfesorTienePerfils(List<ProfesorTienePerfil> profesorTienePerfils) {
		this.profesorTienePerfils = profesorTienePerfils;
	}

	public ProfesorTienePerfil addProfesorTienePerfil(ProfesorTienePerfil profesorTienePerfil) {
		getProfesorTienePerfils().add(profesorTienePerfil);
		profesorTienePerfil.setPerfile(this);

		return profesorTienePerfil;
	}

	public ProfesorTienePerfil removeProfesorTienePerfil(ProfesorTienePerfil profesorTienePerfil) {
		getProfesorTienePerfils().remove(profesorTienePerfil);
		profesorTienePerfil.setPerfile(null);

		return profesorTienePerfil;
	}

}