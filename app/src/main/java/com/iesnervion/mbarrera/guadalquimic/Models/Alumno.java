package com.iesnervion.mbarrera.guadalquimic.Models;


import com.google.gson.annotations.SerializedName;

/**
 * Created by mbarrera on 1/02/17.
 */

public class Alumno {

    @SerializedName("Id")
    private int id;
    @SerializedName("Nombre")
    private String nombre;
    @SerializedName("Apellidos")
    private String apellidos;
    @SerializedName("Alias")
    private String alias;
    @SerializedName("Correo")
    private String correo;
    @SerializedName("Contraseña")
    private String contraseña;
    @SerializedName("Curso")
    private String curso;

    public Alumno() {
    }

    public Alumno(int id, String nombre, String apellidos, String correo, String alias, String contraseña, String curso) {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.correo = correo;
        this.alias = alias;
        this.contraseña = contraseña;
        this.curso = curso;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }

    public String getContraseña() {
        return contraseña;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getAlias() {
        return alias;
    }

    public void setAlias(String alias) {
        this.alias = alias;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}
