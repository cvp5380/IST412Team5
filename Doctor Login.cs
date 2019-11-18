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
using Microsoft.VisualBasic;

namespace IST412_Team5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String doctorUsername;
        private String doctorPassword;
        private String registion = "Xy78";

        private String doctorFullName = "Yinghua Huang";
        private String doctorPhone = "2649985522";
        private String doctorEmail = "doctor@gmail.com";
        private String doctorAddress = "2324 unknow street philadelphia PA, 19149";

        public MainWindow()
        {
            InitializeComponent();
        }


        public void setUsername(String doctorUsername)
        {
            this.doctorUsername = doctorUsername;
        }


        public void setPassword(String doctorPassword)
        {
            this.doctorPassword = doctorPassword;
        }


        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text.Equals(doctorUsername) && password.Text.Equals(doctorPassword)){
                MessageBox.Show("Welcome Doctor");
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Enter your Doctor number", "Doctor Verify", "Default", 0, 0);

            if( input.Equals(registion))
            {
                MessageBox.Show(doctorFullName + Environment.NewLine + doctorEmail + Environment.NewLine + doctorPhone + Environment.NewLine + doctorAddress, "Your Information");
                String askUsername = Interaction.InputBox("Enter your Username", "Username Enter", "", 0, 0);
                setUsername(askUsername);
                if (!askUsername.Equals(""))
                {
                    String askPassword = Interaction.InputBox("Enter your Password", "Password Enter", "", 0, 0);
                    setPassword(askPassword);

                }
                
            }
        }
    }
}
