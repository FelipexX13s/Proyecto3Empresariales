package com.felipeyjuanr.servidor.services;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;

import java.time.LocalDateTime;
import java.util.List;


public interface IServicioLibro {
    public List getLibros();

    public List  getLibrosAutores(String autor);

    public List  getLibrosTapaDura(boolean tapa);

    public boolean agregarLibro(String titulo, Autor autor, int cantidadPaginas, LocalDateTime fechaCreacion, double precio, boolean tapaDura);

    public Libro buscarLibro(String titulo);

    public Libro buscarAutor(String autor);

    public Libro buscarPro(String titulo,String autor);

    public boolean eliminarLibro(String titulo);

    public boolean actualizarLibro(String tituloAntiguo, String titulo, Autor autor, int cantidadPaginas, LocalDateTime fechaCreacion, double precio, boolean tapaDura);
}
