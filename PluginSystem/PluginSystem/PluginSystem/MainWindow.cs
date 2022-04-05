using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMainInterface;
namespace PluginSystem
{
    public partial class MainWindow : Form, IPluginHost
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool Register(IPlugin plug)
        {
            return true;
        }
    }
}
