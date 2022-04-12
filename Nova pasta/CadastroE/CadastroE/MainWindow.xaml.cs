using System;
using System.Collections.Generic;
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

namespace CadastroE
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Password.ToString();

            if (usuario == "d" && senha == "123")
            {
                JnPagIni p = new JnPagIni();
                p.ShowDialog();
            }

            else MessageBox.Show("SEU E-MAIL OU SENHA ESTA INCORRETO", "ALGO ESTA ERRADO", MessageBoxButton.OK);

            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            JnCadastro pA = new JnCadastro();
            pA.ShowDialog();
        }
    }
}
