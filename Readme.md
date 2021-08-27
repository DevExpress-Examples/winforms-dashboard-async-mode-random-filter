<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/211867400/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828313)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# Dashboard for WinForms - How to get filter values and set Master Filter asynchronously

This example demonstrates how to work in asynchronous mode to get filter values, set the master filter and perform an asynchronous task when the dashboard is loaded for the first time.

![screenshot](/images/screenshot.png)

Click **Random Filter** to get available filters and apply a random filter asynchronously.

## API
* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.GetAvailableFilterValuesAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetAvailableFilterValuesAsync(System.String)) method. Gets available master filter values for the specified dashboard item asynchronously. 
* [DashboardViewer.SetMasterFilterAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.SetMasterFilterAsync.overloads) method. Selects elements in the specified master filter item asynchronously. 
* [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.

## Documentation 

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)
* [Master Filtering](https://docs.devexpress.com/Dashboard/116912)

## More Examples

- [Dashboard Viewer: How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
- [Dashboard Viewer: How to Create a Slide Show with Asynchronous Maximize and Restore Methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
- [Dashboard Viewer: How to Get Dashboard Item Data Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-get-item-data)
