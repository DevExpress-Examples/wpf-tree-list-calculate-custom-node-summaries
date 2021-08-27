<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657758/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T506349)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Employees.cs](./CS/TreeList_DataBinding/Employees.cs) (VB: [Employees.vb](./VB/TreeList_DataBinding/Employees.vb))
* [MainWindow.xaml](./CS/TreeList_DataBinding/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/TreeList_DataBinding/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/TreeList_DataBinding/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/TreeList_DataBinding/MainWindow.xaml.vb))
<!-- default file list end -->
# How to calculate custom Node Summaries in TreeListView


<p>To calculate custom Node Summaries in TreeListView, you need to handle TreeListView's  <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTreeListView_CustomSummarytopic.aspx">CustomSummary</a> event and check the e.IsNodeSummary property to determine which summary type (node or total) should be calculated.</p>

<br/>


