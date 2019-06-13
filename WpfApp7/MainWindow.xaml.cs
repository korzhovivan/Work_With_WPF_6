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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Button> btns = new List<Button>() {
                new Button(){Background = Brushes.Black},//1
                new Button(){Background = Brushes.Black},//2
                new Button(){Background = Brushes.Black},//3
                new Button(){Background = Brushes.White},//4
                new Button(){Background = Brushes.Black},//5
                new Button(){Background = Brushes.White},//6
                new Button(){Background = Brushes.White},//7
                new Button(){Background = Brushes.Black},//8
                new Button(){Background = Brushes.Black},//9
                new Button(){Background = Brushes.White},//10
                new Button(){Background = Brushes.Black},//11
                new Button(){Background = Brushes.White},//12
                new Button(){Background = Brushes.Black},//13
                new Button(){Background = Brushes.White},//14
                new Button(){Background = Brushes.Black},//15
                new Button(){Background = Brushes.White},//16
                new Button(){Background = Brushes.Black},//17
                new Button(){Background = Brushes.White},//18
                new Button(){Background = Brushes.Black},//19
                new Button(){Background = Brushes.White},//20
                new Button(){Background = Brushes.Black},//21
            };

            for (int i = 0; i < 21; i++)
            {
                
                btns[i].Content = (i+1).ToString();
            }
            DockPanel.SetDock(btns[0], Dock.Left);
            DockPanel.SetDock(btns[1], Dock.Bottom);
            DockPanel.SetDock(btns[2], Dock.Right);
            DockPanel.SetDock(btns[3], Dock.Left);
            DockPanel.SetDock(btns[4], Dock.Top);
            DockPanel.SetDock(btns[5], Dock.Bottom);
            DockPanel.SetDock(btns[6], Dock.Right);
            DockPanel.SetDock(btns[7], Dock.Left);
            DockPanel.SetDock(btns[8], Dock.Bottom);
            DockPanel.SetDock(btns[9], Dock.Top);
            DockPanel.SetDock(btns[10], Dock.Right);
            DockPanel.SetDock(btns[11], Dock.Left);
            DockPanel.SetDock(btns[12], Dock.Top);
            DockPanel.SetDock(btns[13], Dock.Bottom);
            DockPanel.SetDock(btns[14], Dock.Left);
            DockPanel.SetDock(btns[15], Dock.Right);
            DockPanel.SetDock(btns[16], Dock.Bottom);
            DockPanel.SetDock(btns[17], Dock.Top);
            DockPanel.SetDock(btns[18], Dock.Right);
            DockPanel.SetDock(btns[19], Dock.Left);
            DockPanel.SetDock(btns[20], Dock.Top);
            

            for (int i = 0; i < 21; i++)
            {
                dockPanel.Children.Add(btns[i]);
            }
        }
    }
}
