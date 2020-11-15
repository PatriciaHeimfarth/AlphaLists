using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ABC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.AppendAllText(saveFileDialog.FileName, A.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, B.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, C.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, D.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, E.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, F.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, G.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, H.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, I.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, J.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, K.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, L.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, M.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, N.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, O.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, P.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, Q.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, R.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, S.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, T.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, U.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, V.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, W.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, X.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, Y.Text);
            File.AppendAllText(saveFileDialog.FileName, "\n\n");
            File.AppendAllText(saveFileDialog.FileName, Z.Text);
        }

        public void Refresh(object sender, RoutedEventArgs e)
        {
            A.Text = "A";
            B.Text = "B";
            C.Text = "C";
            D.Text = "D";
            E.Text = "E";
            F.Text = "F";
            G.Text = "G";
            H.Text = "H";
            I.Text = "I";
            J.Text = "J";
            K.Text = "K";
            L.Text = "L";
            M.Text = "M";
            N.Text = "N";
            O.Text = "O";
            P.Text = "P";
            Q.Text = "Q";
            R.Text = "R";
            S.Text = "S";
            T.Text = "T";
            U.Text = "U";
            V.Text = "V";
            W.Text = "W";
            X.Text = "X";
            Y.Text = "Y";
            Z.Text = "Z";
          
        }
    }
}
