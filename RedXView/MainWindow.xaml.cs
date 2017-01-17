using DataProviders;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;


namespace RedXView
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ProcessLayer Opcs, Logp;
        private DataSet dataS;
        DataTable Ddata;
        Window2 win;
        string[] nom, mError;
        int[] value, codeE;
        int i;


        ProcFactory factory;
        public MainWindow()
        {
            InitializeComponent();
            factory = new ProcFactory();
            this.Opcs = factory.createProcess("RedX");
            this.Logp = factory.createProcess("RedX");
            this.dataS = new DataSet();
            Ddata = new DataTable();
            win = new Window2();
            nom = new string[2];
            mError = new string[2];
            value = new int[2];
            codeE = new int[2];
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            charger();
            chargerlog();
            DataRowView dataRow = (DataRowView)dataGrid.Items[1];
            textBox.Text = dataRow.Row.ItemArray[1].ToString();

          

        }



        private void charger()
        {
            this.dataS.Tables.Clear();            
            try
            {
                this.dataS = this.Opcs.getText("TableText");
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erreur Base de données Introuvable");
                this.Close();
            }
            dataGrid.ItemsSource = dataS.Tables["TableText"].DefaultView;
        }

      

        private void dataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;            
            textBox.Text = dataRow.Row.ItemArray[1].ToString();

        }

       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((value[0] | value[1]) == 1)
            {
                win.setText(textBox.Text);
                win.Show();
            }
           else
            {
                if ((value[0] & value[1]) == 0)
                    MessageBox.Show("                                                                ERREUR!\n" +
                        "Code d'erreur " + codeE[0] + " : " + mError[0]
                        + "\nCode d'erreur" + codeE[1] + " : " + mError[1]
                        + "\nUtiliser le bouton check aprés correction.");
                else if (value[0] == 0)
                MessageBox.Show("                                                      ERREUR!\n"+ 
                    "Code d'erreur " + codeE[0] + " : " + mError[0]
                    + "\nUtiliser le bouton check aprés correction.");
                else if (value[1] == 0)
                    MessageBox.Show("                                                                ERREUR!\n" + 
                        "Code d'erreur " + codeE[1] + " : " + mError[1] 
                        + "\nUtiliser le bouton check aprés correction.");
                
            }
           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            win.Close();
        }

        private void dataGrid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            chargerlog();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void dataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


        }

        private void chargerlog()
        {
            
            i = 0;
            Ddata = Logp.chargerLog("LogTable").Tables["LogTable"];
            foreach (DataRow data in Ddata.Rows)
            {
                nom[i] = data[1].ToString();
                value[i] = (int)data[2];
                codeE[i] = (int)data[3];
                mError[i] = data[4].ToString();
                i++;
            }


            if (value[0] == 1)//CPU
            {
                label_Copy2.Content = "OK";
                label_Copy2.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                label_Copy2.Content = "NO";
                label_Copy2.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (value[1] == 1)//RAM
            {
                label_Copy1.Content = "OK";
                label_Copy1.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                label_Copy1.Content = "NO";
                label_Copy1.Foreground = new SolidColorBrush(Colors.Red);
            }
      

        }
    }
}
