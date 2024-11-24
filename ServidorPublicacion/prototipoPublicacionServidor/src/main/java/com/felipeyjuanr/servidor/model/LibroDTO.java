package com.felipeyjuanr.servidor.model;
import java.time.LocalDateTime;

public record LibroDTO(
        String titulo,
        String autor,
        int cantidadPaginas,
        LocalDateTime fechaCreacion,
        double precio,
        boolean tapaDura
) {}