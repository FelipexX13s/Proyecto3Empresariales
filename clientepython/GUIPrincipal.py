#GUIPrincipal.py

# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIPrincipal.ui'
#
# Created by: PyQt5 UI code generator 5.15.9
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.

import sys

from GUIRegistrarAutor import Ui_MainWindow as guiRegistrarAutor
from GUIRegistrarLibro import Ui_MainWindow as guiRegistrarLibro

from GUIBuscarAutor import Ui_MainWindow as guiBuscarAutor
from GUIBuscarLibro import Ui_MainWindow as guiBuscarLibro

from GUIActualizarAutor import Ui_MainWindow as guiActualizarAutor
from GUIActualizarLibro import Ui_MainWindow as guiActualizarLibro

from GUIEliminarAutor import Ui_MainWindow as guiEliminarAutor
from GUIEliminarLibro import Ui_MainWindow as guiEliminarLibro

from GUIListarAutores import Ui_MainWindow as guiListarAutores
from GUIListarLibros import Ui_MainWindow as guiListarLibros

from PyQt5 import QtCore, QtGui, QtWidgets


# Cambiar la clase para heredar de QMainWindow directamente
# Esto es necesario para que `closeEvent` funcione correctamente.
class Ui_GUIPrincipal(QtWidgets.QMainWindow):  # Modificación: hereda de QMainWindow
    def setupUi(self, GUIPrincipal):
        GUIPrincipal.setObjectName("GUIPrincipal")
        GUIPrincipal.resize(256, 299)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUIPrincipal.sizePolicy().hasHeightForWidth())
        GUIPrincipal.setSizePolicy(sizePolicy)
        GUIPrincipal.setMinimumSize(QtCore.QSize(256, 299))
        GUIPrincipal.setMaximumSize(QtCore.QSize(256, 299))
        self.centralwidget = QtWidgets.QWidget(GUIPrincipal)
        self.centralwidget.setObjectName("centralwidget")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(0, -40, 281, 331))
        self.label.setText("")
        self.label.setPixmap(QtGui.QPixmap("C:/Users/Juan/Downloads/imagenes sin contexto/logoPublicacion.png"))
        self.label.setObjectName("label")
        GUIPrincipal.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(GUIPrincipal)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 256, 21))
        self.menubar.setObjectName("menubar")
        self.menuInicio = QtWidgets.QMenu(self.menubar)
        self.menuInicio.setObjectName("menuInicio")
        self.menuLibro = QtWidgets.QMenu(self.menubar)
        self.menuLibro.setObjectName("menuLibro")
        self.menuAutor = QtWidgets.QMenu(self.menubar)
        self.menuAutor.setObjectName("menuAutor")
        self.menuAyuda = QtWidgets.QMenu(self.menubar)
        self.menuAyuda.setObjectName("menuAyuda")
        GUIPrincipal.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(GUIPrincipal)
        self.statusbar.setObjectName("statusbar")
        GUIPrincipal.setStatusBar(self.statusbar)
        self.actionAcerca_de = QtWidgets.QAction(GUIPrincipal)
        self.actionAcerca_de.setObjectName("actionAcerca_de")
        self.actionSalir = QtWidgets.QAction(GUIPrincipal)
        self.actionSalir.setObjectName("actionSalir")
        self.actionRegistrar_libro = QtWidgets.QAction(GUIPrincipal)
        self.actionRegistrar_libro.setObjectName("actionRegistrar_libro")
        self.actionBuscar_libro = QtWidgets.QAction(GUIPrincipal)
        self.actionBuscar_libro.setObjectName("actionBuscar_libro")
        self.actionActualizar_libro = QtWidgets.QAction(GUIPrincipal)
        self.actionActualizar_libro.setObjectName("actionActualizar_libro")
        self.actionEliminar_libro = QtWidgets.QAction(GUIPrincipal)
        self.actionEliminar_libro.setObjectName("actionEliminar_libro")
        self.actionListar_libros = QtWidgets.QAction(GUIPrincipal)
        self.actionListar_libros.setObjectName("actionListar_libros")
        self.actionRegistrar_autor = QtWidgets.QAction(GUIPrincipal)
        self.actionRegistrar_autor.setObjectName("actionRegistrar_autor")
        self.actionBuscar_libro_2 = QtWidgets.QAction(GUIPrincipal)
        self.actionBuscar_libro_2.setObjectName("actionBuscar_libro_2")
        self.actionActualizar_autor = QtWidgets.QAction(GUIPrincipal)
        self.actionActualizar_autor.setObjectName("actionActualizar_autor")
        self.actionEliminar_autor = QtWidgets.QAction(GUIPrincipal)
        self.actionEliminar_autor.setObjectName("actionEliminar_autor")
        self.actionListar_autores = QtWidgets.QAction(GUIPrincipal)
        self.actionListar_autores.setObjectName("actionListar_autores")
        self.menuInicio.addAction(self.actionSalir)
        self.menuLibro.addAction(self.actionRegistrar_libro)
        self.menuLibro.addSeparator()
        self.menuLibro.addAction(self.actionBuscar_libro)
        self.menuLibro.addSeparator()
        self.menuLibro.addAction(self.actionActualizar_libro)
        self.menuLibro.addSeparator()
        self.menuLibro.addAction(self.actionEliminar_libro)
        self.menuLibro.addSeparator()
        self.menuLibro.addAction(self.actionListar_libros)
        self.menuAutor.addAction(self.actionRegistrar_autor)
        self.menuAutor.addSeparator()
        self.menuAutor.addAction(self.actionBuscar_libro_2)
        self.menuAutor.addSeparator()
        self.menuAutor.addAction(self.actionActualizar_autor)
        self.menuAutor.addSeparator()
        self.menuAutor.addAction(self.actionEliminar_autor)
        self.menuAutor.addSeparator()
        self.menuAutor.addAction(self.actionListar_autores)
        self.menuAyuda.addAction(self.actionAcerca_de)
        self.menubar.addAction(self.menuInicio.menuAction())
        self.menubar.addAction(self.menuLibro.menuAction())
        self.menubar.addAction(self.menuAutor.menuAction())
        self.menubar.addAction(self.menuAyuda.menuAction())

        self.retranslateUi(GUIPrincipal)
        QtCore.QMetaObject.connectSlotsByName(GUIPrincipal)

        self.actionRegistrar_autor.triggered.connect(self.registrarAutor)
        self.actionRegistrar_libro.triggered.connect(self.registrarLibro)

        self.actionBuscar_libro_2.triggered.connect(self.buscarAutor)
        self.actionBuscar_libro.triggered.connect(self.buscarLibro)

        self.actionActualizar_autor.triggered.connect(self.actualizarAutor)
        self.actionActualizar_libro.triggered.connect(self.actualizarLibro)

        self.actionEliminar_autor.triggered.connect(self.eliminarAutor)
        self.actionEliminar_libro.triggered.connect(self.eliminarLibro)

        self.actionListar_autores.triggered.connect(self.listarAutores)
        self.actionListar_libros.triggered.connect(self.listarLibros)

        self.child_windows = []  # Para mantener referencia de las ventanas hijas

    def retranslateUi(self, GUIPrincipal):
        _translate = QtCore.QCoreApplication.translate
        GUIPrincipal.setWindowTitle(_translate("GUIPrincipal", "Gestión de libros"))
        self.menuInicio.setTitle(_translate("GUIPrincipal", "Inicio"))
        self.menuLibro.setTitle(_translate("GUIPrincipal", "Libro"))
        self.menuAutor.setTitle(_translate("GUIPrincipal", "Autor"))
        self.menuAyuda.setTitle(_translate("GUIPrincipal", "Ayuda"))
        self.actionAcerca_de.setText(_translate("GUIPrincipal", "Acerca de"))
        self.actionSalir.setText(_translate("GUIPrincipal", "Salir"))
        self.actionRegistrar_libro.setText(_translate("GUIPrincipal", "Registrar libro"))
        self.actionBuscar_libro.setText(_translate("GUIPrincipal", "Buscar libro"))
        self.actionActualizar_libro.setText(_translate("GUIPrincipal", "Actualizar libro"))
        self.actionEliminar_libro.setText(_translate("GUIPrincipal", "Eliminar libro"))
        self.actionListar_libros.setText(_translate("GUIPrincipal", "Listar libros"))
        self.actionRegistrar_autor.setText(_translate("GUIPrincipal", "Registrar autor"))
        self.actionBuscar_libro_2.setText(_translate("GUIPrincipal", "Buscar autor"))
        self.actionActualizar_autor.setText(_translate("GUIPrincipal", "Actualizar autor"))
        self.actionEliminar_autor.setText(_translate("GUIPrincipal", "Eliminar autor"))
        self.actionListar_autores.setText(_translate("GUIPrincipal", "Listar autores"))
    
    # Registrar

    def registrarAutor(self):
        registrar_autor_window = QtWidgets.QMainWindow(self)
        ui = guiRegistrarAutor()
        ui.setupUi(registrar_autor_window)
        registrar_autor_window.show()
        registrar_autor_window.destroyed.connect(lambda: self.remove_child_window(registrar_autor_window))

    def registrarLibro(self):
        registrar_libro_window = QtWidgets.QMainWindow(self)
        ui = guiRegistrarLibro()
        ui.setupUi(registrar_libro_window)
        registrar_libro_window.show()
        registrar_libro_window.destroyed.connect(lambda: self.remove_child_window(registrar_libro_window))

    # Buscar

    def buscarAutor(self):
        buscar_autor_window = QtWidgets.QMainWindow(self)
        ui = guiBuscarAutor()
        ui.setupUi(buscar_autor_window)
        buscar_autor_window.show()
        buscar_autor_window.destroyed.connect(lambda: self.remove_child_window(buscar_autor_window))

    def buscarLibro(self):
        buscar_libro_window = QtWidgets.QMainWindow(self)
        ui = guiBuscarLibro()
        ui.setupUi(buscar_libro_window)
        buscar_libro_window.show()
        buscar_libro_window.destroyed.connect(lambda: self.remove_child_window(buscar_libro_window))

    # Actualizar

    def actualizarAutor(self):
        actualizar_autor_window = QtWidgets.QMainWindow(self)
        ui = guiActualizarAutor()
        ui.setupUi(actualizar_autor_window)
        actualizar_autor_window.show()
        actualizar_autor_window.destroyed.connect(lambda: self.remove_child_window(actualizar_autor_window))

    def actualizarLibro(self):
        actualizar_libro_window = QtWidgets.QMainWindow(self)
        ui = guiActualizarLibro()
        ui.setupUi(actualizar_libro_window)
        actualizar_libro_window.show()
        actualizar_libro_window.destroyed.connect(lambda: self.remove_child_window(actualizar_libro_window))

    # Eliminar

    def eliminarLibro(self):
        eliminar_libro_window = QtWidgets.QMainWindow(self)
        ui = guiEliminarLibro()
        ui.setupUi(eliminar_libro_window)
        eliminar_libro_window.show()
        eliminar_libro_window.destroyed.connect(lambda: self.remove_child_window(eliminar_libro_window))

    def eliminarAutor(self):
        eliminar_autor_window = QtWidgets.QMainWindow(self)
        ui = guiEliminarAutor()
        ui.setupUi(eliminar_autor_window)
        eliminar_autor_window.show()
        eliminar_autor_window.destroyed.connect(lambda: self.remove_child_window(eliminar_autor_window))

    # Listar

    def listarLibros(self):
        listar_libros_window = QtWidgets.QMainWindow(self)
        ui = guiListarLibros()
        ui.setupUi(listar_libros_window)
        listar_libros_window.show()
        listar_libros_window.destroyed.connect(lambda: self.remove_child_window(listar_libros_window))

    def listarAutores(self):
        listar_autores_window = QtWidgets.QMainWindow(self)
        ui = guiListarAutores()
        ui.setupUi(listar_autores_window)
        listar_autores_window.show()
        listar_autores_window.destroyed.connect(lambda: self.remove_child_window(listar_autores_window))

    def remove_child_window(self, window):
        if window in self.child_windows:
            self.child_windows.remove(window)

    def closeEvent(self, event):
        # Close all child windows
        for window in list(self.child_windows):
            window.close()
    
        event.accept()