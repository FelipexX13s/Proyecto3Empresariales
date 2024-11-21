from datetime import datetime

class Libro:
    def __init__(self, titulo: str, autor: str, cantidad_paginas: int, 
                 fecha_creacion: datetime, precio: float, tapa_dura: bool):
        self.titulo = titulo
        self.autor = autor
        self.cantidad_paginas = cantidad_paginas
        self.fecha_creacion = fecha_creacion
        self.precio = precio
        self.tapa_dura = tapa_dura