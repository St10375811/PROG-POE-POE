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



namespace PROG_POE_Part3
{
    public partial class MainWindow : Window
    {//MainWindow Class begin
        //Variable to hold manageRecipe Class
        private ManageRecepie manageRecipes;

        // Parameterless constructor required by the XAML loader
        public MainWindow()
        {//MainWindow() begin
            InitializeComponent();
            this.manageRecipes = new ManageRecepie(); // Initialize ManageRecepie instance here
        }//MainWindow() end

        // Optional constructor to pass an existing ManageRecepie instance
        public MainWindow(ManageRecepie manageRecipes)
        {//MainWindow() passing manageRecipe class begin
            InitializeComponent();
            this.manageRecipes = manageRecipes;
        }//MainWindow() passing manageRecipe class end

        //Get Started Button to navigate to the next form
        private void Button_Click(object sender, RoutedEventArgs e)
        {//GetStarted method begin
            //Open the AddRecipe Window
            AddRecipe addRecipeWindow = new AddRecipe(manageRecipes);
            addRecipeWindow.Show();
            //Close this Window
            this.Close();
        }//GetStarted method end
    }//MainWindowClass End
}//namespace ST10251759pROG6221_POE end
