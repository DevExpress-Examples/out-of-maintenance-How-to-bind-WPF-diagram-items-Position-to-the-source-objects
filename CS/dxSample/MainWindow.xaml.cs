using DevExpress.Xpf.Core;
using System;
using System.Linq;

namespace dxSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void DiagramDataBindingBehavior_CustomLayoutItems(object sender, DevExpress.Xpf.Diagram.DiagramCustomLayoutItemsEventArgs e) {
            e.Handled = true;
        }
    }
}
