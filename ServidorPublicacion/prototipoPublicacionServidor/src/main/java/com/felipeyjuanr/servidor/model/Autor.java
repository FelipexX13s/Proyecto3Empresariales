package com.felipeyjuanr.servidor.model;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import jakarta.validation.constraints.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/**
 * @author Juan y Felipe R
 */
@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
@Entity
@Table(name = "autores")
public class Autor {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @NotBlank(message = "El nombre es obligatorio")
    @Size(max = 255, message = "El nombre no puede tener más de 255 caracteres")
    @Column(unique = true)
    private String nombre;

    @Min(value = 0, message = "La edad no puede ser negativa")
    @Max(value = 150, message = "La edad no puede ser mayor a 150")
    private int edad;

    @NotBlank(message = "La nacionalidad es obligatoria")
    @Size(max = 100, message = "La nacionalidad no puede tener más de 100 caracteres")
    private String nacionalidad;

    @DecimalMin(value = "0.0", message = "Las regalías no pueden ser negativas")
    private double regalias;

    @PastOrPresent(message = "La fecha de nacimiento no puede ser en el futuro")
    private LocalDateTime fechaNacimiento;


    @OneToMany(mappedBy = "autor", orphanRemoval = false)
    @JsonManagedReference
    private List<Libro> libros = new ArrayList<>();


}