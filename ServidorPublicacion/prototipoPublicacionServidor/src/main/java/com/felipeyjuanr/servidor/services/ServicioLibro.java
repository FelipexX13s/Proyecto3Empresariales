package com.felipeyjuanr.servidor.services;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import com.felipeyjuanr.servidor.repositories.LibroRepository;
import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

@Service
@RequiredArgsConstructor
public class ServicioLibro implements IServicioLibro {
    @Autowired
    private LibroRepository librosRepo;

    @Override
    public List<Libro> getLibros() {
        return librosRepo.findAll();
    }

    @Override
    public List<Libro> getLibrosAutores(String autor) {
        return librosRepo.findByAutorNombreIgnoreCase(autor);
    }

    @Override
    public List getLibrosTapaDura(boolean tapa) {
        return librosRepo.findByTapaDura(tapa);
    }

    @Override
    @Transactional
    public boolean agregarLibro(String titulo, Autor autor, int cantidadPaginas,
                                LocalDateTime fechaCreacion, double precio, boolean tapaDura) {
        // Verifica si ya existe un libro con el mismo título

        System.out.println("CAL librosRepo: " + librosRepo);

        if (librosRepo.buscarTitulo(titulo).isPresent()) {
            return false;
        }

        // Crea y guarda un nuevo libro usando el repositorio
        Libro nuevoLibro = Libro.builder()
                .titulo(titulo)
                .autor(autor)
                .cantidadPaginas(cantidadPaginas)
                .fechaCreacion(fechaCreacion)
                .precio(precio)
                .tapaDura(tapaDura)
                .build();

        librosRepo.save(nuevoLibro);
        return true;
    }


    @Override
    public Libro buscarLibro(String titulo) {
        return librosRepo.buscarTitulo(titulo).orElse(null);
    }

    @Override
    public Libro buscarAutor(String autor) {
        return librosRepo.findFirstByAutorNombreIgnoreCase(autor).orElse(null);
    }

    @Override
    public Libro buscarPro(String titulo, String autor) {
        return librosRepo.findByTituloIgnoreCaseAndAutorNombreIgnoreCase(titulo, autor).orElse(null);
    }

    @Override
    @Transactional
    public boolean eliminarLibro(String titulo) {
        Optional<Libro> libro = librosRepo.buscarTitulo(titulo);
        if (libro.isPresent()) {
            librosRepo.delete(libro.get());
            return true;
        }
        return false;
    }

    @Override
    @Transactional
    public boolean actualizarLibro(String tituloAntiguo, String titulo, Autor autor,
                                   int cantidadPaginas, LocalDateTime fechaCreacion,
                                   double precio, boolean tapaDura) {
        Optional<Libro> libroExistente = librosRepo.buscarTitulo(tituloAntiguo);
        if (libroExistente.isPresent()) {
            Libro libro = libroExistente.get();
            libro.setTitulo(titulo);
            libro.setAutor(autor);
            libro.setCantidadPaginas(cantidadPaginas);
            libro.setFechaCreacion(fechaCreacion);
            libro.setPrecio(precio);
            libro.setTapaDura(tapaDura);
            librosRepo.save(libro);
            return true;
        }
        return false;
    }
}
