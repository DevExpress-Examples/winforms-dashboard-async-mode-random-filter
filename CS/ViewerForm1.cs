using DevExpress.DashboardCommon.ViewerData;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFilterExample
{
    public partial class ViewerForm1 : XtraForm {
        public ViewerForm1() {
            InitializeComponent();
            dashboardViewer1.Initialized += OnDashboardViewerInitialized;

        }
        async void OnMouseClick(object sender, MouseEventArgs e) {
            await RandomFilter();
        }
        async Task RandomFilter() {
            string itemName = "choroplethMapDashboardItem1";
            IList<AxisPointTuple> filters = await dashboardViewer1.GetAvailableFilterValuesAsync(itemName);
            Random r = new Random();
            int index = r.Next(0, filters.Count - 1);
            await dashboardViewer1.SetMasterFilterAsync(itemName, filters[index]);
        }

        async void OnDashboardViewerInitialized(object sender, EventArgs e) {
            await RandomFilter();
        }
    }
}
