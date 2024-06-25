<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657758/21.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T506349)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Tree List - How to calculate custom Node Summaries

This example demonstrates how to calculate custom node summaries in the [TreeListView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView). To do this, use the TreeListView’s [CustomSummary](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomSummary) event / [CustomSummaryCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomSummaryCommand) property. The **IsNodeSummary** property allows you to determine whether to calculate node summaries.

![](https://docs.devexpress.com/WPF/images/TreeListView_CustomSummary.png?v=21.2)

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/CustomNodeSummaries_CodeBehind/MainWindow.xaml) ([MainWindow.xaml](./VB/CustomNodeSummaries_CodeBehind/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/CustomNodeSummaries_CodeBehind/MainWindow.xaml.cs#L23-L29) ([MainWindow.xaml.vb](./VB/CustomNodeSummaries_CodeBehind/MainWindow.xaml.vb#L25-L31))

### MVVM Technique

- [MainWindow.xaml](./CS/CustomNodeSummaries_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/CustomNodeSummaries_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/CustomNodeSummaries_MVVM/MainViewModel.cs#L28-L35) ([MainViewModel.vb](./VB/CustomNodeSummaries_MVVM/MainViewModel.vb#L30-L37))

<!-- default file list end -->

## Documentation

- [Node Summary](https://docs.devexpress.com/WPF/118490/controls-and-libraries/data-grid/data-summaries/node-summary)
- [Custom Summary](https://docs.devexpress.com/WPF/6129/controls-and-libraries/data-grid/data-summaries/custom-summary)
- [TreeListView.CustomSummary](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomSummary)
- [TreeListView.CustomSummaryCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomSummaryCommand)

## More Examples

- [How to Display Group Summaries](https://github.com/DevExpress-Examples/how-to-display-group-summaries-e1637)
- [How to Display Total Summaries](https://github.com/DevExpress-Examples/how-to-display-total-summaries-e1636)
- [How to Use Custom Summaries](https://github.com/DevExpress-Examples/how-to-summarize-empty-cells-e948)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-tree-list-calculate-custom-node-summaries&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-tree-list-calculate-custom-node-summaries&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
