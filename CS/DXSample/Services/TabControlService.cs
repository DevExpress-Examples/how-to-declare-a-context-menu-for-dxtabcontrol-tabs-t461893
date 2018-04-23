using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;

namespace DXSample.Services {
    public class TabControlService : ServiceBase, ITabControlService {
        DXTabControl AssociatedTabControl { get { return (DXTabControl)AssociatedObject; } }

        public void Hide(object item) {
            AssociatedTabControl.HideTabItem(item);
        }

        public void Show(object item) {
            AssociatedTabControl.ShowTabItem(item);
        }
    }
}
