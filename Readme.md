<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# How to Get FIlter Values and Set Master Filter Asynchronously

This example demonstrates how to use asynchronous mode to get filter values, set master filter and perform an asynchronous task when the dashboard is loaded for the first time.


![screenshot](/images/screenshot.png)

Click **Random Filter** button to get available filters and apply a random filter asynchronously.


API in this example:
* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.GetAvailableFilterValuesAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetAvailableFilterValuesAsync(System.String)) method. Gets available master filter values for the specified dashboard item asynchronously. 
* [DashboardViewer.SetMasterFilterAsync](https:/docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetMasterFilterAsync.overloads) method. Selects elements in the specified master filter item asynchronously. 
* [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.


## Documentation 

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples

- [Dashboard Viewer: How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
- [Dashboard Viewer: How to Create a Slide Show with Asynchronous Maximize and Restore Methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
- [Dashboard Viewer: How to Get Dashboard Item Data Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-get-item-data)
