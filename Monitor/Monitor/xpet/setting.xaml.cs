using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Monitor
{
	/// <summary>
	/// setting.xaml 的交互逻辑
	/// </summary>
	public partial class setting : UserControl
	{
		public setting()
		{
			this.InitializeComponent();
		}

        private void manage(object sender, System.Windows.RoutedEventArgs e)
        {
            SettingContent.Content = new setting01();
        }

        private void Other(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new other();// 在此处添加事件处理程序实现。
        }

        private void Password(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new Password();// 在此处添加事件处理程序实现。
        }

        private void APR(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new APR();// 在此处添加事件处理程序实现。
        }

        private void RIS(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new RIS();// 在此处添加事件处理程序实现。
        }

        private void Template(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new dose_Template();// 在此处添加事件处理程序实现。
        }

        private void Dose(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new dose_Template();// 在此处添加事件处理程序实现。
        }

        private void Arithmetic(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new ProtocolMain();// 在此处添加事件处理程序实现。
        }

        private void Default(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new arithmetic();// 在此处添加事件处理程序实现。
        }

        private void Database(object sender, System.Windows.RoutedEventArgs e)
        {
        	SettingContent.Content = new Database();// 在此处添加事件处理程序实现。
        }
        
    }
}