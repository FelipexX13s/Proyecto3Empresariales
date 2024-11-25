package com.felipeyjuanr.servidor.controller;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import com.felipeyjuanr.servidor.model.LibroDTO;
import com.felipeyjuanr.servidor.services.ServicioAutor;
import com.felipeyjuanr.servidor.services.ServicioLibro;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping(value = "/libros")
@CrossOrigin(origins = "http://127.0.0.1:5500", allowCredentials = "true")
public class ControllerLibro {

    @Autowired
    private ServicioLibro servicioLibro;
    @Autowired
    private ServicioAutor servicioAutor;

    private LibroDTO toDTO(Libro libro) {
        return new LibroDTO(
                libro.getTitulo(),
                libro.getAutor() != null ? libro.getAutor().getNombre() : null,
                libro.getCantidadPaginas(),
                libro.getFechaCreacion(),
                libro.getPrecio(),
                libro.isTapaDura()
        );
    }

    @GetMapping
    public ResponseEntity<List<LibroDTO>> getLibros() {
        List<Libro> libros = servicioLibro.getLibros();
        List<LibroDTO> librosDTO = libros.stream()
                .map(this::toDTO)
                .toList();

        return librosDTO.isEmpty() ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(librosDTO);
    }

    @GetMapping("/autor/{autor}")
    public ResponseEntity<List<LibroDTO>> getLibrosAutor(@PathVariable String autor) {
        List<Libro> libros = servicioLibro.getLibrosAutores(autor);
        List<LibroDTO> librosDTO = libros.stream()
                .map(this::toDTO)
                .toList();

        return librosDTO.isEmpty() ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(librosDTO);
    }

    @GetMapping("/tapa/{tapa}")
    public ResponseEntity<List<LibroDTO>> getLibrosTapaDura(@PathVariable boolean tapa) {
        List<Libro> libros = servicioLibro.getLibrosTapaDura(tapa);
        List<LibroDTO> librosDTO = libros.stream()
                .map(this::toDTO)
                .toList();

        return librosDTO.isEmpty() ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(librosDTO);
    }

    @PostMapping("/agregar")
    public ResponseEntity<String> agregarLibro(@RequestBody Libro libro) {
        if (!libroCorrecto(libro)) {
            return ResponseEntity.badRequest().body("Datos del libro inválidos");
        }

        Autor autorExistente = null;
        if (libro.getAutor() != null) {

            autorExistente = servicioAutor.buscarAutor(libro.getAutor().getNombre());

            if (autorExistente == null) {
                return ResponseEntity.badRequest().body("El autor no existe en la base de datos");
            }
        }

        boolean agregado = servicioLibro.agregarLibro(
                libro.getTitulo(),
                autorExistente,
                libro.getCantidadPaginas(),
                libro.getFechaCreacion(),
                libro.getPrecio(),
                libro.isTapaDura()
        );

        return agregado ?
                ResponseEntity.status(HttpStatus.CREATED).body("Libro agregado exitosamente") :
                ResponseEntity.status(HttpStatus.CONFLICT).body("No se pudo agregar el libro");
    }

    @PutMapping("/actualizar/{tituloAntiguo}")
    public ResponseEntity<String> actualizarLibro(
            @PathVariable String tituloAntiguo,
            @RequestBody Libro libroActualizado) {
        if (tituloAntiguo == null || tituloAntiguo.trim().isEmpty() || !libroCorrecto(libroActualizado)) {
            return ResponseEntity.badRequest().body("Datos inválidos para la actualización");
        }

        Autor autorExistente = null;
        if (libroActualizado.getAutor() != null) {

            autorExistente = servicioAutor.buscarAutor(libroActualizado.getAutor().getNombre());

            if (autorExistente == null) {
                return ResponseEntity.badRequest().body("El autor no existe en la base de datos");
            }
        }

        boolean actualizado = servicioLibro.actualizarLibro(
                tituloAntiguo,
                libroActualizado.getTitulo(),
                autorExistente,
                libroActualizado.getCantidadPaginas(),
                libroActualizado.getFechaCreacion(),
                libroActualizado.getPrecio(),
                libroActualizado.isTapaDura()
        );
        return actualizado ?
                ResponseEntity.ok("Libro actualizado exitosamente") :
                ResponseEntity.notFound().build();
    }

    @GetMapping("/buscarAutor/{autor}")
    public ResponseEntity<LibroDTO> buscarLibroAutor(@PathVariable String autor) {
        if (autor == null || autor.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }

        Libro libro = servicioLibro.buscarAutor(autor);
        if (libro != null) {
            LibroDTO libroDTO = toDTO(libro);
            return ResponseEntity.ok(libroDTO);
        }
        return ResponseEntity.notFound().build();
    }

    @GetMapping("/buscar/{titulo}")
    public ResponseEntity<LibroDTO> buscarLibro(@PathVariable String titulo) {
        if (titulo == null || titulo.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }

        Libro libro = servicioLibro.buscarLibro(titulo);
        if (libro != null) {
            LibroDTO libroDTO = toDTO(libro);
            return ResponseEntity.ok(libroDTO);
        }
        return ResponseEntity.notFound().build();
    }

    @GetMapping("/buscarCompleto")
    public ResponseEntity<LibroDTO> buscarLibroCompleto(@RequestParam String titulo, @RequestParam String autor) {
        if (titulo == null || titulo.trim().isEmpty() ||
                autor == null || autor.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }

        Libro libro = servicioLibro.buscarPro(titulo, autor);
        if (libro != null) {
            LibroDTO libroDTO = toDTO(libro);
            return ResponseEntity.ok(libroDTO);
        }
        return ResponseEntity.notFound().build();
    }


    @DeleteMapping("/borrar/{titulo}")
    public ResponseEntity<String> eliminarLibro(@PathVariable String titulo) {
        if (titulo == null || titulo.trim().isEmpty()) {
            return ResponseEntity.badRequest().body("Título inválido");
        }
        boolean eliminado = servicioLibro.eliminarLibro(titulo);
        return eliminado ?
                ResponseEntity.ok("Libro eliminado exitosamente") :
                ResponseEntity.notFound().build();
    }

    private boolean libroCorrecto(Libro libro) {
        return libro != null &&
                libro.getTitulo() != null && !libro.getTitulo().trim().isEmpty() &&
                libro.getCantidadPaginas() > 0 &&
                libro.getFechaCreacion() != null &&
                libro.getPrecio() >= 0;
    }
}
