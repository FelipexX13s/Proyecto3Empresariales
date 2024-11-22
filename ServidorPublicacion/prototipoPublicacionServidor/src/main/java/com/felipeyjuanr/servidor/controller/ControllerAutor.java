package com.felipeyjuanr.servidor.controller;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import com.felipeyjuanr.servidor.services.ServicioAutor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;
import java.util.List;

@RestController
@RequestMapping(value = "/autores")
public class ControllerAutor {

    @Autowired
    private ServicioAutor servicioAutor;

    @GetMapping
    public ResponseEntity<List<Autor>> getAutores() {
        List<Autor> autores = servicioAutor.getAutores();
        return (autores.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(autores);
    }

    @GetMapping("/edad/{edad}")
    public ResponseEntity<List<Autor>> getAutoresEdad(@PathVariable int edad) {
        List<Autor> autores = servicioAutor.getAutoresEdad(edad);
        return (autores.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(autores);
    }

    @GetMapping("/nacionalidad/{nacionalidad}")
    public ResponseEntity<List<Autor>> getAutoresNacionalidad(@PathVariable String nacionalidad) {
        List<Autor> autores = servicioAutor.getAutoresNacionalidad(nacionalidad);
        return (autores.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(autores);
    }

    @PostMapping("/agregar")
    public ResponseEntity<String> agregarAutor(@RequestBody Autor autor) {
        if (!autorCorrecto(autor)) {
            return ResponseEntity.badRequest().body("Datos del autor inválidos");
        }

        boolean agregado = servicioAutor.agregarAutor(
                autor.getNombre(),
                autor.getEdad(),
                autor.getNacionalidad(),
                autor.getRegalias(),
                autor.getFechaNacimiento(),
                autor.getLibros()
        );

        return agregado ?
                ResponseEntity.status(HttpStatus.CREATED).body("Autor agregado exitosamente") :
                ResponseEntity.status(HttpStatus.CONFLICT).body("No se pudo agregar el autor");
    }

    @GetMapping("/buscar/{nombre}")
    public ResponseEntity<Autor> buscarAutor(@PathVariable String nombre) {
        if (nombre == null || nombre.trim().isEmpty()) {
            return ResponseEntity.badRequest().build();
        }
        Autor autor = servicioAutor.buscarAutor(nombre);
        return autor != null ?
                ResponseEntity.ok(autor) :
                ResponseEntity.notFound().build();
    }

    @DeleteMapping("/borrar/{nombre}")
    public ResponseEntity<String> eliminarAutor(@PathVariable String nombre) {
        if (nombre == null || nombre.trim().isEmpty()) {
            return ResponseEntity.badRequest().body("Nombre inválido");
        }
        boolean eliminado = servicioAutor.eliminarAutor(nombre);
        return eliminado ?
                ResponseEntity.ok("Autor eliminado exitosamente") :
                ResponseEntity.notFound().build();
    }

    @PutMapping("/actualizar/{nombreAntiguo}")
    public ResponseEntity<String> actualizarAutor(
            @PathVariable String nombreAntiguo,
            @RequestBody Autor autorActualizado) {
        if (nombreAntiguo == null || nombreAntiguo.trim().isEmpty() || !autorCorrecto(autorActualizado)) {
            return ResponseEntity.badRequest().body("Datos inválidos para la actualización");
        }
        boolean actualizado = servicioAutor.actualizarAutor(
                nombreAntiguo,
                autorActualizado.getNombre(),
                autorActualizado.getEdad(),
                autorActualizado.getNacionalidad(),
                autorActualizado.getRegalias(),
                autorActualizado.getFechaNacimiento(),
                autorActualizado.getLibros()
        );
        return actualizado ?
                ResponseEntity.ok("Autor actualizado exitosamente") :
                ResponseEntity.notFound().build();
    }

    @PostMapping("/agregarLibro/{nombreAutor}")
    public ResponseEntity<String> agregarLibroAAutor(
            @PathVariable String nombreAutor,
            @RequestBody Libro libro) {
        if (nombreAutor == null || nombreAutor.trim().isEmpty()) {
            return ResponseEntity.badRequest().body("Nombre de autor inválido");
        }
        boolean agregado = servicioAutor.agregarLibroAAutor(nombreAutor, libro);
        return agregado ?
                ResponseEntity.status(HttpStatus.CREATED).body("Libro agregado al autor exitosamente") :
                ResponseEntity.status(HttpStatus.NOT_FOUND).body("No se pudo agregar el libro al autor");
    }

    @GetMapping("/libros/{nombreAutor}")
    public ResponseEntity<List<Libro>> obtenerLibrosDeAutor(@PathVariable String nombreAutor) {
        List<Libro> libros = servicioAutor.obtenerLibrosDeAutor(nombreAutor);
        return (libros.isEmpty()) ?
                ResponseEntity.noContent().build() : ResponseEntity.ok(libros);
    }

    private boolean autorCorrecto(Autor autor) {
        return autor != null &&
                autor.getNombre() != null && !autor.getNombre().trim().isEmpty() &&
                autor.getEdad() > 0 &&
                autor.getNacionalidad() != null && !autor.getNacionalidad().trim().isEmpty() &&
                autor.getFechaNacimiento() != null &&
                autor.getRegalias() >= 0;
    }
}