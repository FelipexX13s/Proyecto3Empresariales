# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIBuscarAutor.ui'
#
# Created by: PyQt5 UI code generator 5.15.9
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(280, 346)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(MainWindow.sizePolicy().hasHeightForWidth())
        MainWindow.setSizePolicy(sizePolicy)
        MainWindow.setMinimumSize(QtCore.QSize(280, 346))
        MainWindow.setMaximumSize(QtCore.QSize(280, 346))
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(10, 0, 181, 41))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(18)
        self.label.setFont(font)
        self.label.setTextFormat(QtCore.Qt.AutoText)
        self.label.setScaledContents(False)
        self.label.setWordWrap(False)
        self.label.setObjectName("label")
        self.label_2 = QtWidgets.QLabel(self.centralwidget)
        self.label_2.setGeometry(QtCore.QRect(10, 130, 71, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_2.setFont(font)
        self.label_2.setObjectName("label_2")
        self.txtNombre = QtWidgets.QLineEdit(self.centralwidget)
        self.txtNombre.setEnabled(False)
        self.txtNombre.setGeometry(QtCore.QRect(90, 140, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.txtNombre.setFont(font)
        self.txtNombre.setObjectName("txtNombre")
        self.label_3 = QtWidgets.QLabel(self.centralwidget)
        self.label_3.setGeometry(QtCore.QRect(10, 200, 111, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_3.setFont(font)
        self.label_3.setObjectName("label_3")
        self.txtNacionalidad = QtWidgets.QLineEdit(self.centralwidget)
        self.txtNacionalidad.setEnabled(False)
        self.txtNacionalidad.setGeometry(QtCore.QRect(130, 210, 141, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.txtNacionalidad.setFont(font)
        self.txtNacionalidad.setAcceptDrops(False)
        self.txtNacionalidad.setObjectName("txtNacionalidad")
        self.label_4 = QtWidgets.QLabel(self.centralwidget)
        self.label_4.setGeometry(QtCore.QRect(10, 170, 71, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_4.setFont(font)
        self.label_4.setObjectName("label_4")
        self.label_5 = QtWidgets.QLabel(self.centralwidget)
        self.label_5.setGeometry(QtCore.QRect(10, 240, 201, 21))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_5.setFont(font)
        self.label_5.setObjectName("label_5")
        self.label_6 = QtWidgets.QLabel(self.centralwidget)
        self.label_6.setGeometry(QtCore.QRect(10, 270, 171, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_6.setFont(font)
        self.label_6.setObjectName("label_6")
        self.dpFecha = QtWidgets.QDateEdit(self.centralwidget)
        self.dpFecha.setEnabled(False)
        self.dpFecha.setGeometry(QtCore.QRect(200, 280, 71, 22))
        self.dpFecha.setObjectName("dpFecha")
        self.sbRegalias = QtWidgets.QSpinBox(self.centralwidget)
        self.sbRegalias.setEnabled(False)
        self.sbRegalias.setGeometry(QtCore.QRect(200, 240, 42, 22))
        self.sbRegalias.setMinimumSize(QtCore.QSize(0, 22))
        self.sbRegalias.setMaximumSize(QtCore.QSize(42, 22))
        self.sbRegalias.setObjectName("sbRegalias")
        self.label_7 = QtWidgets.QLabel(self.centralwidget)
        self.label_7.setGeometry(QtCore.QRect(250, 240, 21, 21))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_7.setFont(font)
        self.label_7.setObjectName("label_7")
        self.label_8 = QtWidgets.QLabel(self.centralwidget)
        self.label_8.setGeometry(QtCore.QRect(10, 90, 211, 41))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(18)
        self.label_8.setFont(font)
        self.label_8.setTextFormat(QtCore.Qt.AutoText)
        self.label_8.setScaledContents(False)
        self.label_8.setWordWrap(False)
        self.label_8.setObjectName("label_8")
        self.lineEdit = QtWidgets.QLineEdit(self.centralwidget)
        self.lineEdit.setGeometry(QtCore.QRect(10, 70, 181, 20))
        self.lineEdit.setObjectName("lineEdit")
        self.btnBuscar = QtWidgets.QPushButton(self.centralwidget)
        self.btnBuscar.setGeometry(QtCore.QRect(200, 70, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnBuscar.setFont(font)
        self.btnBuscar.setObjectName("btnBuscar")
        self.label_9 = QtWidgets.QLabel(self.centralwidget)
        self.label_9.setGeometry(QtCore.QRect(10, 40, 131, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_9.setFont(font)
        self.label_9.setObjectName("label_9")
        self.sbEdad = QtWidgets.QSpinBox(self.centralwidget)
        self.sbEdad.setEnabled(False)
        self.sbEdad.setGeometry(QtCore.QRect(90, 170, 41, 22))
        self.sbEdad.setMinimumSize(QtCore.QSize(0, 22))
        self.sbEdad.setMaximumSize(QtCore.QSize(50, 22))
        self.sbEdad.setObjectName("sbEdad")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 280, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

        self.btnBuscar.clicked.connect(buscar)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Buscar autor"))
        self.label.setText(_translate("MainWindow", "Buscar Autor"))
        self.label_2.setText(_translate("MainWindow", "Nombre"))
        self.label_3.setText(_translate("MainWindow", "Nacionalidad"))
        self.label_4.setText(_translate("MainWindow", "Edad"))
        self.label_5.setText(_translate("MainWindow", "Porcentaje de regalias"))
        self.label_6.setText(_translate("MainWindow", "Fecha de nacimiento"))
        self.label_7.setText(_translate("MainWindow", "%"))
        self.label_8.setText(_translate("MainWindow", "Autor encontrado"))
        self.btnBuscar.setText(_translate("MainWindow", "Buscar"))
        self.label_9.setText(_translate("MainWindow", "Autor a buscar"))

    def buscar():
        data = servicioAutor.buscar_autor(self.lineEdit.getText)

        nombre=data['nombre']
        edad=data['edad'],
        nacionalidad=data['nacionalidad']
        regalias=data['regalias']
        fecha = datetime.strptime(data['fecha_nacimiento'], "%Y-%m-%d")

        self.txtNombre.setText(nombre)
        self.sbEdad.setValue(edad)
        self.txtNacionalidad.setText(nacionalidad)
        self.sbRegalias.setValue(regalias)
        self.dpFecha.setDate(datetime.strptime(fecha, "%Y-%m-%d").date()) 


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())
