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
using wpfData.ServiceReferenceSnack;

namespace wpfData_Step_4
{
    /// <summary>
    /// Interaction logic for CityUserControl.xaml
    /// </summary>
    public partial class CityUserControl : UserControl
    {
        private ServiceSnackClient serviceSnack;

        public CityUserControl()
        {
            InitializeComponent();

            serviceSnack = new ServiceSnackClient();
            cityListView.ItemsSource = serviceSnack.GetAllCites();
        }
    }
}
