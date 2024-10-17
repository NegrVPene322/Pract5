using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract5
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
        Triad triad1 = new Triad();
        Triad triad2 = new Triad();
        Triad triad3 = new Triad();
        int a, b, c;



        private void tb_input_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;

            f1 = int.TryParse(tb_t1.Text, out a);
            f2 = int.TryParse(tb_t2.Text, out b);
            f3 = int.TryParse(tb_t3.Text, out c);
            if (f1 && f2 && f3)
            {
                triad1.Triad1 = a;
                triad2.Triad2 = b;
                triad3.Triad3 = c;
            }
            else MessageBox.Show("Неправильное значение");
        }



        private void bt_1and2_Click(object sender, RoutedEventArgs e)
        {


            bool f1;
            f1 = triad1.SravnTriad(a, b);
            if (f1) tb_2t.Text = "1 и 2 тройки равны"; else tb_2t.Text = "1 и 2 тройки не равны";
        }



        private void bt_2and3_Click(object sender, RoutedEventArgs e)
        {



            bool f1;
            f1 = triad1.SravnTriad(b, c);
            if (f1) tb_2t.Text = "2 и 3 тройки равны"; else tb_2t.Text = "2 и 3 тройки не равны";
        }



        private void bt_1and3_Click(object sender, RoutedEventArgs e)
        {


            bool f1;
            f1 = triad1.SravnTriad(a, c);
            if (f1) tb_2t.Text = "1 и 3 тройки равны"; else tb_2t.Text = "1 и 3 тройки не равны";
        }



        private void bt_all_Click(object sender, RoutedEventArgs e)
        {

            bool f1;
            f1 = triad1.SravnTriad(a, b, c);
            if (f1) tb_3t.Text = "Все тройки равны"; else tb_3t.Text = "Не все тройки равны";
        }
        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void bt_inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка нечетных чисел). Создать необходимые методы и \r\nсвойства. Определить метод сравнения двух триад на равенство. Создать \r\nперегруженный метод сравнения трех триад на равенство. Разработчик студент ИСП-31 Карпушин А.Д", "Информация о программе");
        }

    }
}
