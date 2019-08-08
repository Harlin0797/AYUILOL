using Ay.Framework.WPF.Controls;
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
using Ay.Framework.WPF;

namespace LOLSkinGetter
{
    /// <summary>
    /// _ViewStart.xaml 的交互逻辑
    /// </summary>
    public partial class _ViewStart : AyWindow
    {
        public _ViewStart()
        {
            InitializeComponent();
            Loaded += _ViewStart_Loaded;
        }

        private void _ViewStart_Loaded(object sender, RoutedEventArgs e)
        {
            AyExtension.SetAyWindowMouseLeftButtonMove(this,ddfd);
        }
    }
}
