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

namespace transporteVoto
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

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            byte idade;
            string mensagem;

            //Entrada de dados
            idade = Convert.ToByte(txtIdade.Text);

            //Verificação da idade com base na condição
            if (idade < 16)//Desvio Encadeado
            {
                mensagem = "Você não tem 16 anos, portanto não pode votar e nem embarcar!";
            }
            else if (idade < 18)
            {
                mensagem = "Voto opcional, embarque permitido.";
            }
            else
            {
                mensagem = "Voto obrigatório, embarque permitido!";
            }
            MessageBox.Show(mensagem, "Transporte",
                MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
