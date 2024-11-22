package com.felipeyjuanr.servidor.repositories;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface AutorRepository extends JpaRepository<Autor, Long> {
    // Buscar autor por nombre (case-insensitive)
    Optional<Autor> findByNombreIgnoreCase(String nombre);

    // Buscar autores por edad
    List<Autor> findByEdad(int edad);

    // Buscar autores por nacionalidad
    List<Autor> findByNacionalidad(String nacionalidad);


}
