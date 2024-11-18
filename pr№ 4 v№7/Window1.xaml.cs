using pr__4_v_7.todolist1;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace pr__4_v_7
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private BindingList<todoModel> _TodoDataList;
        private BindingList<todoModel> _TodoDateList;

        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _TodoDateList = new BindingList<todoModel>()
            {
                new todoModel(){Text = "сходить на пары"},
                new todoModel(){Text = "сходить в магаз"},
                new todoModel(){Text = "поспать", IsDone = true }
                
            }; 

            
            dgToolList.ItemsSource = _TodoDateList;
        }

        private void Dodavlenie_Click(object sender, RoutedEventArgs e)
        {
            string text = zadaha.Text;
            MessageBox.Show("вы добавили задачу " + zadaha );
        

        }
    }

   
}
