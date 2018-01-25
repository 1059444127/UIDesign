using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Monitor.xpet
{
    /// <summary>
    /// xpet.xaml 的交互逻辑
    /// </summary>
    public partial class xpet : Window
    {
        public xpet()
        {
            InitializeComponent();
        }

        private void Login(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new Login();// 在此处添加事件处理程序实现。
        }

        private void Add_Protocol(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new Add_Protocol();// 在此处添加事件处理程序实现。
        }

        private void Protocol(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new protocol();// 在此处添加事件处理程序实现。
        }

        private void Setting(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new setting();// 在此处添加事件处理程序实现。
        }

        private void OpenFile(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new OpenFile();// 在此处添加事件处理程序实现。
        }

        private void message(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new Message();// 在此处添加事件处理程序实现。
        }

        private void Match(object sender, System.Windows.RoutedEventArgs e)
        {
        	PanelContent.Content = new Match();// 在此处添加事件处理程序实现。
        }
    }
}
