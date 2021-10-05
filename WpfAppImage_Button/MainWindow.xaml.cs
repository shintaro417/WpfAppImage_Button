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
using System.Diagnostics;

namespace WpfAppImage_Button
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

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            repeatText.Text = (int.Parse(repeatText.Text) + 1).ToString();
        }
        /// <summary>
        /// リンクをクリック時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">RequestNavigateイベントのデータを提供する。(URIとかが入っている。)</param>
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //絶対URIを起動する
            Process.Start(e.Uri.AbsoluteUri);
            //イベントを処理済みとしてマークする
            e.Handled = true;
        }
    }
}
