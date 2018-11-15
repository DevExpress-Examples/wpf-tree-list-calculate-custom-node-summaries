<!-- default file list -->
*Files to look at*:

* [Employees.cs](./CS/TreeList_DataBinding/Employees.cs) (VB: [Employees.vb](./VB/TreeList_DataBinding/Employees.vb))
* [MainWindow.xaml](./CS/TreeList_DataBinding/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/TreeList_DataBinding/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/TreeList_DataBinding/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/TreeList_DataBinding/MainWindow.xaml))
<!-- default file list end -->
# How to calculate custom Node Summaries in TreeListView


<p>To calculate custom Node Summaries in TreeListView, you need to handle TreeListView's  <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTreeListView_CustomSummarytopic.aspx">CustomSummary</a> event and check the e.IsNodeSummary property to determine which summary type (node or total) should be calculated.</p>

<br/>


