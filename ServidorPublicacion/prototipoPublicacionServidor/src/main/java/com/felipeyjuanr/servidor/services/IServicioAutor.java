package com.felipeyjuanr.servidor.services;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;

import java.time.LocalDateTime;
import java.util.List;

public interface IServicioAutor {
    public List getAutores();

    public List  getAutoresEdad(int edad);

    public List  getAutoresNacionalidad(String nacionalidad);

    public boolean agregarAutor(String nombre, int edad, String nacionalidad, double regalias, LocalDateTime fechaNacimiento, List<Libro> libros);

    public Autor buscarAutor(String nombre);

    public boolean eliminarAutor(String nombre);

    public boolean actualizarAutor(String nombreAntiguo, String nombre, int edad, String nacionalidad, double regalias, LocalDateTime fechaNacimiento, List<Libro> libros);
}

