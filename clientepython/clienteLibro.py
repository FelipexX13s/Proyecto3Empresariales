from GUIPrincipal import Ui_GUIPrincipal
from PyQt5 import QtWidgets
import sys

if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_GUIPrincipal()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())
