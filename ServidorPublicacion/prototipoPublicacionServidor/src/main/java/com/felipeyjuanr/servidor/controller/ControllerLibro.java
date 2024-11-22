package com.felipeyjuanr.servidor.controller;

import com.felipeyjuanr.servidor.model.Libro;
import com.felipeyjuanr.servidor.services.ServicioLibro;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping(value = "/libros")
public class ControllerLibro {


    //private ServicioLibro servicioLibro = ServicioLibro.getServicioLibro();
    @Autowired
    private ServicioLibro servicioLibro;

    @GetMapping
    public ResponseEntity<List<Libro>> getLibros() {
        List<Libro> libros = servicioLibro.getLibros();
        return (libros.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(libros);
    }

    @GetMapping("/autor/{autor}")
    public ResponseEntity<List<Libro>> getLibrosAutor(@PathVariable String autor) {
        List libros = servicioLibro.getLibrosAutores(autor);
        return (libros.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(libros);
    }

    @GetMapping("/tapa/{tapa}")
    public ResponseEntity<List<Libro>> getLibrosTapaDura(@PathVariable boolean tapa) {
        List libros = servicioLibro.getLibrosTapaDura(tapa);
        return (libros.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(libros);
    }


    @PostMapping("/agregar")
    public ResponseEntity<String> agregarLibro(@RequestBody Libro libro) {
        System.out.println("CAL 1");
        if (!libroCorrecto(libro)) {
            System.out.println("CAL 2");

            return ResponseEntity.badRequest().body("Datos del libro inválidos");
        }
        System.out.println("CAL 3");

        boolean agregado = servicioLibro.agregarLibro(
                libro.getTitulo(),
                libro.getAutor(),
                libro.getCantidadPaginas(),
                libro.getFechaCreacion(),
                libro.getPrecio(),
                libro.isTapaDura()
        );

        System.out.println("CAL 4");

        return agregado ?
                ResponseEntity.status(HttpStatus.CREATED).body("Libro agregado exitosamente") :
                ResponseEntity.status(HttpStatus.CONFLICT).body("No se pudo agregar el libro");
    }

    @GetMapping("/buscarAutor/{autor}")
    public ResponseEntity<Libro> buscarLibroAutor(
            @PathVariable String autor) {
        if (autor == null || autor.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }
        Libro libro = servicioLibro.buscarAutor(autor);
        return libro != null ?
                ResponseEntity.ok(libro) :
                ResponseEntity.notFound().build();
    }

    @GetMapping("/buscar/{titulo}")
    public ResponseEntity<Libro> buscarLibro(
            @PathVariable String titulo) {
        if (titulo == null || titulo.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }
        Libro libro = servicioLibro.buscarLibro(titulo);
        return libro != null ?
                ResponseEntity.ok(libro) :
                ResponseEntity.notFound().build();
    }

    @GetMapping("/buscarCompleto")
    public ResponseEntity<Libro> buscarLibroCompleto(
            @RequestParam String titulo,
            @RequestParam String autor) {

        if (titulo == null || titulo.trim().isEmpty() ||
                autor == null || autor.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }

        Libro libro = servicioLibro.buscarPro(titulo, autor);

        return libro != null ?
                ResponseEntity.ok(libro) :
                ResponseEntity.notFound().build();
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

    @PutMapping("/actualizar/{tituloAntiguo}")
    public ResponseEntity<String> actualizarLibro(
            @PathVariable String tituloAntiguo,
            @RequestBody Libro libroActualizado) {
        if (tituloAntiguo == null || tituloAntiguo.trim().isEmpty() || !libroCorrecto(libroActualizado)) {
            return ResponseEntity.badRequest().body("Datos inválidos para la actualización");
        }
        boolean actualizado = servicioLibro.actualizarLibro(
                tituloAntiguo,
                libroActualizado.getTitulo(),
                libroActualizado.getAutor(),
                libroActualizado.getCantidadPaginas(),
                libroActualizado.getFechaCreacion(),
                libroActualizado.getPrecio(),
                libroActualizado.isTapaDura()
        );
        return actualizado ?
                ResponseEntity.ok("Libro actualizado exitosamente") :
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
