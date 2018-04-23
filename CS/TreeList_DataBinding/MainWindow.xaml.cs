using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace TreeList_DataBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
    
        public MainWindow() {

            InitializeComponent();
            treeListView1.ExpandAllNodes();

        
        }

        private void treeListView1_CustomSummary(object sender, DevExpress.Xpf.Grid.TreeList.TreeListCustomSummaryEventArgs e)
        {
            if (e.IsNodeSummary && e.SummaryItem.FieldName == "Statistics") {
                if (e.SummaryProcess == CustomSummaryProcess.Calculate) {
                    e.TotalValue = Convert.ToDouble(e.TotalValue) + (double)e.FieldValue;
                }
            }
        }    
    }

    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<Employee> SourceList
        {
            get { return GetProperty(() => SourceList); }
            set { SetProperty(() => SourceList, value); }
        }

        public ViewModel()
        {
            SourceList = Stuff.GetStuff();
        }
    }
}
