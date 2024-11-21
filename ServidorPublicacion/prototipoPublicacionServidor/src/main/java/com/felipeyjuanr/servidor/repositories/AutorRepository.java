package com.felipeyjuanr.servidor.repositories;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.model.Libro;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AutorRepository extends JpaRepository<Autor, Long> {

}
