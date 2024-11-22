package com.felipeyjuanr.servidor.model;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import jakarta.persistence.*;
import jakarta.validation.constraints.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;
import java.time.LocalDateTime;
import java.util.ArrayList;


/**
 * @author Juan y Felipe R
 */
@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
@Entity
@Table(name = "libros")
public class Libro
{
    //Atributos
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY) // Auto-incremental
    private int id;

    @NotBlank(message = "El título es obligatorio")
    @Size(max = 255, message = "El título no puede tener más de 255 caracteres")
    private String titulo;

    @ManyToOne(fetch = FetchType.LAZY, optional = true)
    @JoinColumn(name = "autor_id", nullable = true)
    private Autor autor;

    @Min(value = 1, message = "La cantidad de páginas debe ser al menos 1")
    private int cantidadPaginas;

    @PastOrPresent(message = "La fecha de creación no puede ser en el futuro")
    private LocalDateTime fechaCreacion;

    @DecimalMin(value = "0.0", inclusive = false, message = "El precio debe ser mayor que 0")
    private double precio;

    private boolean tapaDura;
}

