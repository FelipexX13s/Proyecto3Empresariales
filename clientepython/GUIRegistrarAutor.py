#GUIRegistrarAutor.py

# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIRegistrarAutor.ui'
#
# Created by: PyQt5 UI code generator 5.15.9
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QMessageBox
from service.ServicioAutor import ServicioAutor


class Ui_MainWindow(QtWidgets.QMainWindow):

    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(285, 307)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(MainWindow.sizePolicy().hasHeightForWidth())
        MainWindow.setSizePolicy(sizePolicy)
        MainWindow.setMinimumSize(QtCore.QSize(0, 0))
        MainWindow.setMaximumSize(QtCore.QSize(314, 378))
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(10, 10, 181, 41))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(18)
        self.label.setFont(font)
        self.label.setTextFormat(QtCore.Qt.AutoText)
        self.label.setScaledContents(False)
        self.label.setWordWrap(False)
        self.label.setObjectName("label")
        self.label_2 = QtWidgets.QLabel(self.centralwidget)
        self.label_2.setGeometry(QtCore.QRect(10, 50, 71, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_2.setFont(font)
        self.label_2.setObjectName("label_2")
        self.txtNombre = QtWidgets.QLineEdit(self.centralwidget)
        self.txtNombre.setGeometry(QtCore.QRect(90, 60, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.txtNombre.setFont(font)
        self.txtNombre.setObjectName("txtNombre")
        self.label_3 = QtWidgets.QLabel(self.centralwidget)
        self.label_3.setGeometry(QtCore.QRect(10, 110, 111, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_3.setFont(font)
        self.label_3.setObjectName("label_3")
        self.txtNacionalidad = QtWidgets.QLineEdit(self.centralwidget)
        self.txtNacionalidad.setEnabled(True)
        self.txtNacionalidad.setGeometry(QtCore.QRect(130, 120, 141, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.txtNacionalidad.setFont(font)
        self.txtNacionalidad.setAcceptDrops(False)
        self.txtNacionalidad.setObjectName("txtNacionalidad")
        self.label_4 = QtWidgets.QLabel(self.centralwidget)
        self.label_4.setGeometry(QtCore.QRect(10, 80, 101, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_4.setFont(font)
        self.label_4.setObjectName("label_4")
        self.label_5 = QtWidgets.QLabel(self.centralwidget)
        self.label_5.setGeometry(QtCore.QRect(10, 150, 201, 21))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_5.setFont(font)
        self.label_5.setObjectName("label_5")
        self.label_6 = QtWidgets.QLabel(self.centralwidget)
        self.label_6.setGeometry(QtCore.QRect(10, 180, 171, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_6.setFont(font)
        self.label_6.setObjectName("label_6")
        self.dpFecha = QtWidgets.QDateEdit(self.centralwidget)
        self.dpFecha.setGeometry(QtCore.QRect(200, 190, 71, 22))
        self.dpFecha.setObjectName("dpFecha")
        self.btnAgregar = QtWidgets.QPushButton(self.centralwidget)
        self.btnAgregar.setGeometry(QtCore.QRect(200, 230, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnAgregar.setFont(font)
        self.btnAgregar.setObjectName("btnAgregar")
        self.sbRegalias = QtWidgets.QDoubleSpinBox(self.centralwidget)
        self.sbRegalias.setGeometry(QtCore.QRect(200, 150, 42, 22))
        self.sbRegalias.setMinimumSize(QtCore.QSize(0, 22))
        self.sbRegalias.setMaximumSize(QtCore.QSize(42, 22))
        self.sbRegalias.setObjectName("sbRegalias")
        self.sbRegalias.setMaximum(100.0)
        self.label_7 = QtWidgets.QLabel(self.centralwidget)
        self.label_7.setGeometry(QtCore.QRect(250, 150, 21, 21))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_7.setFont(font)
        self.label_7.setObjectName("label_7")
        self.sbEdad = QtWidgets.QSpinBox(self.centralwidget)
        self.sbEdad.setGeometry(QtCore.QRect(90, 90, 41, 22))
        self.sbEdad.setMinimumSize(QtCore.QSize(0, 22))
        self.sbEdad.setMaximumSize(QtCore.QSize(50, 22))
        self.sbEdad.setObjectName("sbEdad")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 285, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.servicioAutor = ServicioAutor()

        self.btnAgregar.clicked.connect(self.agregar_autor)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Registrar autor"))
        self.label.setText(_translate("MainWindow", "Registrar Autor"))
        self.label_2.setText(_translate("MainWindow", "Nombre"))
        self.label_3.setText(_translate("MainWindow", "Nacionalidad"))
        self.label_4.setText(_translate("MainWindow", "Edad"))
        self.label_5.setText(_translate("MainWindow", "Porcentaje de regalias"))
        self.label_6.setText(_translate("MainWindow", "Fecha de nacimiento"))
        self.btnAgregar.setText(_translate("MainWindow", "Agregar"))
        self.label_7.setText(_translate("MainWindow", "%"))
    
    def agregar_autor(self):
        print("jijijija")
        nombre = self.txtNombre.text()
        edad = self.sbEdad.value()
        nacionalidad = self.txtNacionalidad.text()
        porcentaje_regalias = self.sbRegalias.value()
        fecha_nacimiento = self.dpFecha.date().toString("yyyy-MM-dd")

        exito = self.servicioAutor.agregar_autor(
            nombre, 
            edad, 
            nacionalidad, 
            porcentaje_regalias, 
            fecha_nacimiento
        )

        if exito:
            QMessageBox.information(
                None, 
                "Éxito", 
                f"El autor '{nombre}' ha sido registrado correctamente."
            )
        else:
            QMessageBox.critical(
                None, 
                "Error", 
                "Ocurrió un problema al registrar el autor. Inténtalo nuevamente."
            )


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())