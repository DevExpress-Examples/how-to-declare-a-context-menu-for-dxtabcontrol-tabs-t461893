using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;

namespace DXSample.Services {
    public interface ITabControlService {
        void Hide(object item);
        void Show(object item);
    }
}
