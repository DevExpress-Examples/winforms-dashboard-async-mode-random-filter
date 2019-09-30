Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace RandomFilterExample
	Partial Public Class ViewerForm1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.Initialized, AddressOf OnDashboardViewerInitialized

		End Sub
		Private Async Overloads Sub OnMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles simpleButton1.MouseClick
			Await RandomFilter()
		End Sub
		Private Async Function RandomFilter() As Task
			Dim itemName As String = "choroplethMapDashboardItem1"
			Dim filters As IList(Of AxisPointTuple) = Await dashboardViewer1.GetAvailableFilterValuesAsync(itemName)
			Dim r As New Random()
			Dim index As Integer = r.Next(0, filters.Count - 1)
			Await dashboardViewer1.SetMasterFilterAsync(itemName, filters(index))
		End Function

		Private Async Sub OnDashboardViewerInitialized(ByVal sender As Object, ByVal e As EventArgs)
			Await RandomFilter()
		End Sub
	End Class
End Namespace
