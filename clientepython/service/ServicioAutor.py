import requests
from datetime import datetime
from typing import List, Optional

from model.Libro import Libro
from model.Autor import Autor

class ServicioAutor:
    BASE_URL = "http://localhost:8080"
    DOMINIO = "/autores"

    def obtener_autores(self) -> List[Autor]:
        response = requests.get(f"{self.BASE_URL}{self.DOMINIO}")
        return [Autor(**autor) for autor in response.json()]

    def obtener_nombres_autores(self) -> List[str]:
        autores = self.obtener_autores()
        return [autor.nombre for autor in autores]

    def obtener_autores_nacionalidad(self, nacionalidad: str) -> List[Autor]:
        response = requests.get(f"{self.BASE_URL}{self.DOMINIO}/nacionalidad/{nacionalidad}")
        return [Autor(**autor) for autor in response.json()]

    def obtener_autores_edad(self, edad: int) -> List[Autor]:
        response = requests.get(f"{self.BASE_URL}{self.DOMINIO}/edad/{edad}")
        return [Autor(**autor) for autor in response.json()]

    def agregar_autor(self, nombre: str, edad: int, nacionalidad: str, 
                      porcentaje_regalias: float, fecha_nacimiento: datetime) -> bool:
        payload = {
            "nombre": nombre,
            "edad": edad,
            "nacionalidad": nacionalidad,
            "regalias": porcentaje_regalias,
            "fecha": fecha_nacimiento
        }
        response = requests.post(
            f"{self.BASE_URL}{self.DOMINIO}/agregar", 
            json=payload, 
            headers={"Content-Type": "application/json"}
        )
        return response.status_code == 200

    def buscar_autor(self, nombre: str) -> Optional[Autor]:
        response = requests.get(f"{self.BASE_URL}{self.DOMINIO}/{nombre}")
        return Autor(**response.json()) if response.status_code == 200 else None

    def actualizar_autor(self, nombre_antiguo: str, nombre: str, edad: int, 
                         nacionalidad: str, porcentaje_regalias: float, 
                         fecha_nacimiento: datetime) -> bool:
        payload = {
            "nombre": nombre,
            "edad": edad,
            "nacionalidad": nacionalidad,
            "regalias": porcentaje_regalias,
            "fecha": fecha_nacimiento
        }
        response = requests.put(
            f"{self.BASE_URL}/autores/actualizar/{nombre_antiguo}", 
            json=payload, 
            headers={"Content-Type": "application/json"}
        )
        return response.status_code == 200

    def eliminar_autor(self, nombre: str) -> bool:
        response = requests.delete(f"{self.BASE_URL}{self.DOMINIO}/borrar/{nombre}")
        return response.status_code == 200