from datetime import datetime

class Autor:
    def __init__(self, nombre: str, edad: int, nacionalidad: str, 
                 porcentaje_regalias: float, fecha_nacimiento: datetime):
        self.nombre = nombre
        self.edad = edad
        self.nacionalidad = nacionalidad
        self.porcentaje_regalias = porcentaje_regalias
        self.fecha_nacimiento = fecha_nacimiento