package com.felipeyjuanr.servidor.services;

import com.felipeyjuanr.servidor.model.Autor;
import com.felipeyjuanr.servidor.repositories.AutorRepository;
import com.felipeyjuanr.servidor.repositories.LibroRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;

@Service
@RequiredArgsConstructor
public class ServicioAutor implements IServicioAutor{

    @Autowired
    private AutorRepository autorRepo;

    @Override
    public List getAutores() {
        return List.of();
    }

    @Override
    public List getAutoresEdad(int edad) {
        return List.of();
    }

    @Override
    public List getAutoresNacionalidad(String nacionalidad) {
        return List.of();
    }

    @Override
    public boolean agregarAutor(String nombre, int edad, String nacionalidad, double regalias, LocalDateTime fechaNacimiento) {
        return false;
    }

    @Override
    public Autor buscarAutor(String nombre) {
        return null;
    }

    @Override
    public boolean eliminarLibro(String nombre) {
        return false;
    }

    @Override
    public boolean actualizarLibro(String nombreAntiguo, String nombre, int edad, String nacionalidad, double regalias, LocalDateTime fechaNacimiento) {
        return false;
    }
}
