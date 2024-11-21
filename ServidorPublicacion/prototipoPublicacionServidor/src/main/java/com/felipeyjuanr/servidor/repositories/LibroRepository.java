package com.felipeyjuanr.servidor.repositories;

import com.felipeyjuanr.servidor.model.Libro;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;
import java.util.Optional;

public interface LibroRepository extends JpaRepository<Libro, Long> {
    @Query("SELECT l FROM Libro l WHERE LOWER(l.titulo) = LOWER(:titulo)")
    Optional<Libro> buscarTitulo(String titulo);

    List<Libro> findByAutorNombreIgnoreCase(String nombre);

    List<Libro> findByTapaDura(boolean tapaDura);

    Optional<Libro> findFirstByAutorNombreIgnoreCase(String nombre);

    Optional<Libro> findByTituloIgnoreCaseAndAutorNombreIgnoreCase(String titulo, String nombre);
}

