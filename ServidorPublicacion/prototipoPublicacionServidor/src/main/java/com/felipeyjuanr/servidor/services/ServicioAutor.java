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
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
@Service
@RequiredArgsConstructor
public class ServicioAutor implements IServicioAutor {

    @Autowired
    private AutorRepository autorRepo;
    @Autowired
    private LibroRepository libroRepo;

    @Override
    public List<Autor> getAutores() {
        return autorRepo.findAll();
    }

    @Override
    public List<Autor> getAutoresEdad(int edad) {
        return autorRepo.findByEdad(edad);
    }

    @Override
    public List<Autor> getAutoresNacionalidad(String nacionalidad) {
        return autorRepo.findByNacionalidad(nacionalidad);
    }

    @Override
    @Transactional
    public boolean agregarAutor(String nombre, int edad, String nacionalidad, double regalias,
                                LocalDateTime fechaNacimiento, List<Libro> libros) {
        // Verificar si el autor ya existe
        if (autorRepo.findByNombreIgnoreCase(nombre).isPresent()) {
            return false;
        }

        // Crear autor con o sin libros
        Autor nuevoAutor = Autor.builder()
                .nombre(nombre)
                .edad(edad)
                .nacionalidad(nacionalidad)
                .regalias(regalias)
                .fechaNacimiento(fechaNacimiento)
                .libros(new ArrayList<>())
                .build();

        // Si hay libros, establecer la relación bidireccional
        if (libros != null && !libros.isEmpty()) {
            libros.forEach(libro -> {
                // Buscar el libro existente por título
                Optional<Libro> libroExistente = libroRepo.buscarTitulo(libro.getTitulo());
                if (libroExistente.isPresent()) {
                    Libro libroActual = libroExistente.get();
                    libroActual.setAutor(nuevoAutor);
                    nuevoAutor.getLibros().add(libroActual);
                } else {
                    // Si el libro no existe, crear uno nuevo
                    libro.setAutor(nuevoAutor);
                    nuevoAutor.getLibros().add(libro);
                    libroRepo.save(libro);
                }
            });
        }

        autorRepo.save(nuevoAutor);
        return true;
    }



    @Override
    public Autor buscarAutor(String nombre) {
        return autorRepo.findByNombreIgnoreCase(nombre).orElse(null);
    }

    @Override
    @Transactional
    public boolean eliminarAutor(String nombre) {
        Optional<Autor> autorOptional = autorRepo.findByNombreIgnoreCase(nombre);
        if (autorOptional.isPresent()) {
            Autor autor = autorOptional.get();

            // Desvincula los libros del autor (pone autor_id en NULL)
            autor.getLibros().forEach(libro -> libro.setAutor(null));
            libroRepo.saveAll(autor.getLibros());

            // Elimina el autor
            autorRepo.delete(autor);
            return true;
        }
        return false;
    }


    @Override
    @Transactional
    public boolean actualizarAutor(String nombreAntiguo, String nombre, int edad, String nacionalidad,
                                   double regalias, LocalDateTime fechaNacimiento, List<Libro> libros) {
        Optional<Autor> autorExistente = autorRepo.findByNombreIgnoreCase(nombreAntiguo);
        if (autorExistente.isPresent()) {
            Autor autor = autorExistente.get();
            autor.setNombre(nombre);
            autor.setEdad(edad);
            autor.setNacionalidad(nacionalidad);
            autor.setRegalias(regalias);
            autor.setFechaNacimiento(fechaNacimiento);

            // Limpiar la lista actual de libros
            autor.getLibros().forEach(libro -> libro.setAutor(null));
            autor.getLibros().clear();

            // Si hay libros nuevos, establecer la relación bidireccional
            if (libros != null && !libros.isEmpty()) {
                libros.forEach(libro -> {
                    // Buscar el libro existente por título
                    Optional<Libro> libroExistente = libroRepo.buscarTitulo(libro.getTitulo());
                    if (libroExistente.isPresent()) {
                        Libro libroActual = libroExistente.get();
                        libroActual.setAutor(autor);
                        autor.getLibros().add(libroActual);
                    } else {
                        // Si el libro no existe, crear uno nuevo
                        libro.setAutor(autor);
                        autor.getLibros().add(libro);
                        libroRepo.save(libro);
                    }
                });
            }

            autorRepo.save(autor);
            return true;
        }
        return false;
    }

    @Transactional
    public boolean agregarLibroAAutor(String nombreAutor, Libro libro) {
        Optional<Autor> autorOptional = autorRepo.findByNombreIgnoreCase(nombreAutor);
        if (autorOptional.isPresent()) {
            Autor autor = autorOptional.get();
            autor.getLibros().add(libro);
            libro.setAutor(autor);
            autorRepo.save(autor);
            libroRepo.save(libro);
            return true;
        }
        return false;
    }

    public List<Libro> obtenerLibrosDeAutor(String nombreAutor) {
        Optional<Autor> autorOptional = autorRepo.findByNombreIgnoreCase(nombreAutor);
        return autorOptional.map(Autor::getLibros).orElse(new ArrayList<>());
    }
}