using Record_Book_MVVM.Models;
using Record_Book_MVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Record_Book_MVVM.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
           
            //Set DataContext of this View to this Instance
            //it sets the Default Object for Databinding to "mainViewModel"
             this.DataContext = mainViewModel; 
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FiltherMethod ;
        }

        private bool FiltherMethod(object obj)
        {
            var user=obj as User;
            
            return user.Name.Contains(FilterTextBox.Text);
        }
    }
}
