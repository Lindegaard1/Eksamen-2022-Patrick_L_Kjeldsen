using BIZ;
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

namespace GUI.Usercontrols
{
    /// <summary>
    /// Interaction logic for UserControlCustomerEdit.xaml
    /// </summary>
    public partial class UserControlCustomerEdit : UserControl
    {
        ClassBIZ BIZ;
        Grid homeGrid;

        public UserControlCustomerEdit(ClassBIZ inBIZ, Grid inGrid)
        {
            InitializeComponent();
            BIZ = inBIZ;
            homeGrid = inGrid;
        }

        private void buttonSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            // B: If Customer doesn't exist, adds Customer to Database
            if (BIZ.editOrNewCustomer.id == 0)
            {
                BIZ.SaveNewCustomer();
            }
            // If Customer exists, updates Customer data in Database
            else
            {
                BIZ.UpdateCustomer();
            }

            homeGrid.Children.Remove(this);
            BIZ.isEnabled = true;
        }

        private void buttonExitCustomer_Click(object sender, RoutedEventArgs e)
        {
            homeGrid.Children.Remove(this);
            BIZ.isEnabled = true;
        }
    }
}
