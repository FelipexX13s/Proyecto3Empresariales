# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIActualizarLibro.ui'
#
# Created by: PyQt5 UI code generator 5.15.9
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(314, 422)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(MainWindow.sizePolicy().hasHeightForWidth())
        MainWindow.setSizePolicy(sizePolicy)
        MainWindow.setMinimumSize(QtCore.QSize(314, 422))
        MainWindow.setMaximumSize(QtCore.QSize(314, 422))
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(10, 90, 211, 41))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(18)
        self.label.setFont(font)
        self.label.setTextFormat(QtCore.Qt.AutoText)
        self.label.setScaledContents(False)
        self.label.setWordWrap(False)
        self.label.setObjectName("label")
        self.label_2 = QtWidgets.QLabel(self.centralwidget)
        self.label_2.setGeometry(QtCore.QRect(10, 130, 51, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_2.setFont(font)
        self.label_2.setObjectName("label_2")
        self.lblTitulo = QtWidgets.QLineEdit(self.centralwidget)
        self.lblTitulo.setGeometry(QtCore.QRect(120, 140, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.lblTitulo.setFont(font)
        self.lblTitulo.setObjectName("lblTitulo")
        self.cbxAutores = QtWidgets.QComboBox(self.centralwidget)
        self.cbxAutores.setGeometry(QtCore.QRect(120, 170, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.cbxAutores.setFont(font)
        self.cbxAutores.setObjectName("cbxAutores")
        self.label_3 = QtWidgets.QLabel(self.centralwidget)
        self.label_3.setGeometry(QtCore.QRect(10, 160, 71, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_3.setFont(font)
        self.label_3.setObjectName("label_3")
        self.label_4 = QtWidgets.QLabel(self.centralwidget)
        self.label_4.setGeometry(QtCore.QRect(10, 200, 101, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_4.setFont(font)
        self.label_4.setObjectName("label_4")
        self.label_5 = QtWidgets.QLabel(self.centralwidget)
        self.label_5.setGeometry(QtCore.QRect(10, 240, 61, 21))
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
        self.chxTapaDura = QtWidgets.QCheckBox(self.centralwidget)
        self.chxTapaDura.setGeometry(QtCore.QRect(10, 320, 91, 21))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.chxTapaDura.setFont(font)
        self.chxTapaDura.setObjectName("chxTapaDura")
        self.lblPaginas = QtWidgets.QLineEdit(self.centralwidget)
        self.lblPaginas.setGeometry(QtCore.QRect(120, 210, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.lblPaginas.setFont(font)
        self.lblPaginas.setObjectName("lblPaginas")
        self.lblPrecio = QtWidgets.QLineEdit(self.centralwidget)
        self.lblPrecio.setGeometry(QtCore.QRect(120, 240, 181, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.lblPrecio.setFont(font)
        self.lblPrecio.setObjectName("lblPrecio")
        self.dpFecha = QtWidgets.QDateEdit(self.centralwidget)
        self.dpFecha.setGeometry(QtCore.QRect(190, 270, 110, 22))
        self.dpFecha.setObjectName("dpFecha")
        self.btnAgregarLibro = QtWidgets.QPushButton(self.centralwidget)
        self.btnAgregarLibro.setGeometry(QtCore.QRect(230, 350, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnAgregarLibro.setFont(font)
        self.btnAgregarLibro.setObjectName("btnAgregarLibro")
        self.label_7 = QtWidgets.QLabel(self.centralwidget)
        self.label_7.setGeometry(QtCore.QRect(10, 0, 201, 41))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(18)
        self.label_7.setFont(font)
        self.label_7.setTextFormat(QtCore.Qt.AutoText)
        self.label_7.setScaledContents(False)
        self.label_7.setWordWrap(False)
        self.label_7.setObjectName("label_7")
        self.lblTitulo_2 = QtWidgets.QLineEdit(self.centralwidget)
        self.lblTitulo_2.setGeometry(QtCore.QRect(10, 70, 211, 20))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(10)
        self.lblTitulo_2.setFont(font)
        self.lblTitulo_2.setObjectName("lblTitulo_2")
        self.btnBuscar = QtWidgets.QPushButton(self.centralwidget)
        self.btnBuscar.setGeometry(QtCore.QRect(230, 70, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnBuscar.setFont(font)
        self.btnBuscar.setObjectName("btnBuscar")
        self.label_8 = QtWidgets.QLabel(self.centralwidget)
        self.label_8.setGeometry(QtCore.QRect(10, 40, 131, 31))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label_8.setFont(font)
        self.label_8.setObjectName("label_8")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 314, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Actualizar libro"))
        self.label.setText(_translate("MainWindow", "Libro encontrado"))
        self.label_2.setText(_translate("MainWindow", "Titulo"))
        self.label_3.setText(_translate("MainWindow", "Autor"))
        self.label_4.setText(_translate("MainWindow", "No. paginas"))
        self.label_5.setText(_translate("MainWindow", "Precio"))
        self.label_6.setText(_translate("MainWindow", "Fecha de publicación"))
        self.chxTapaDura.setText(_translate("MainWindow", "Tapa dura"))
        self.btnAgregarLibro.setText(_translate("MainWindow", "Agregar"))
        self.label_7.setText(_translate("MainWindow", "Actualizar Libro"))
        self.btnBuscar.setText(_translate("MainWindow", "Buscar"))
        self.label_8.setText(_translate("MainWindow", "Titulo a buscar"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())