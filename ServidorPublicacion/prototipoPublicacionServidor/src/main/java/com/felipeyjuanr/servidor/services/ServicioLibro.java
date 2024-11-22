package com.felipeyjuanr.servidor.services;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import com.felipeyjuanr.servidor.repositories.AutorRepository;
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

    @Autowired
    private AutorRepository autorRepo;

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
        if (librosRepo.buscarTitulo(titulo).isPresent()) {
            return false;
        }

        Libro nuevoLibro = Libro.builder()
                .titulo(titulo)
                .autor(autor)
                .cantidadPaginas(cantidadPaginas)
                .fechaCreacion(fechaCreacion)
                .precio(precio)
                .tapaDura(tapaDura)
                .build();

        // Guardar libro y actualizar lista de libros del autor
        librosRepo.save(nuevoLibro);
        if (autor != null) {
            autor.getLibros().add(nuevoLibro);
            autorRepo.save(autor);
        }
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
        Optional<Libro> libroOptional = librosRepo.buscarTitulo(titulo);
        if (libroOptional.isPresent()) {
            Libro libro = libroOptional.get();

            // Quitar libro de la lista del autor
            if (libro.getAutor() != null) {
                Autor autor = libro.getAutor();
                autor.getLibros().remove(libro);
                autorRepo.save(autor);
            }

            // Eliminar libro
            librosRepo.delete(libro);
            return true;
        }
        return false;
    }

    @Override
    @Transactional
    public boolean actualizarLibro(String tituloAntiguo, String titulo, Autor autorNuevo,
                                   int cantidadPaginas, LocalDateTime fechaCreacion,
                                   double precio, boolean tapaDura) {
        Optional<Libro> libroExistente = librosRepo.buscarTitulo(tituloAntiguo);
        if (libroExistente.isPresent()) {
            Libro libro = libroExistente.get();

            // Quitar libro del autor anterior
            if (libro.getAutor() != null) {
                Autor autorAntiguo = libro.getAutor();
                autorAntiguo.getLibros().remove(libro);
                autorRepo.save(autorAntiguo);
            }

            // Actualizar libro con nuevo autor
            libro.setTitulo(titulo);
            libro.setAutor(autorNuevo);
            libro.setCantidadPaginas(cantidadPaginas);
            libro.setFechaCreacion(fechaCreacion);
            libro.setPrecio(precio);
            libro.setTapaDura(tapaDura);
            librosRepo.save(libro);

            // Agregar libro al nuevo autor
            if (autorNuevo != null) {
                autorNuevo.getLibros().add(libro);
                autorRepo.save(autorNuevo);
            }

            return true;
        }
        return false;
    }

}
