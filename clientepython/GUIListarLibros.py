# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListarLibros.ui'
#
# Created by: PyQt5 UI code generator 5.15.9
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(650, 394)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.tableView = QtWidgets.QTableView(self.centralwidget)
        self.tableView.setGeometry(QtCore.QRect(10, 10, 631, 301))
        self.tableView.setObjectName("tableView")
        self.btnListar = QtWidgets.QPushButton(self.centralwidget)
        self.btnListar.setGeometry(QtCore.QRect(560, 320, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnListar.setFont(font)
        self.btnListar.setObjectName("btnListar")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(240, 320, 51, 16))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(12)
        self.label.setFont(font)
        self.label.setObjectName("label")
        self.btnFiltrarAutor = QtWidgets.QPushButton(self.centralwidget)
        self.btnFiltrarAutor.setGeometry(QtCore.QRect(480, 320, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnFiltrarAutor.setFont(font)
        self.btnFiltrarAutor.setObjectName("btnFiltrarAutor")
        self.chxTapaDura = QtWidgets.QCheckBox(self.centralwidget)
        self.chxTapaDura.setGeometry(QtCore.QRect(20, 320, 91, 17))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.chxTapaDura.setFont(font)
        self.chxTapaDura.setObjectName("chxTapaDura")
        self.txtAutor = QtWidgets.QLineEdit(self.centralwidget)
        self.txtAutor.setGeometry(QtCore.QRect(300, 320, 171, 20))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.txtAutor.setFont(font)
        self.txtAutor.setObjectName("txtAutor")
        self.btnFiltrarTapa = QtWidgets.QPushButton(self.centralwidget)
        self.btnFiltrarTapa.setGeometry(QtCore.QRect(110, 320, 75, 23))
        font = QtGui.QFont()
        font.setFamily("Arial Rounded MT Bold")
        font.setPointSize(10)
        self.btnFiltrarTapa.setFont(font)
        self.btnFiltrarTapa.setObjectName("btnFiltrarTapa")
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 650, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Listar libros"))
        self.btnListar.setText(_translate("MainWindow", "Listar"))
        self.label.setText(_translate("MainWindow", "Autor"))
        self.btnFiltrarAutor.setText(_translate("MainWindow", "Filtrar"))
        self.chxTapaDura.setText(_translate("MainWindow", "Tapa dura"))
        self.btnFiltrarTapa.setText(_translate("MainWindow", "Filtrar"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())
