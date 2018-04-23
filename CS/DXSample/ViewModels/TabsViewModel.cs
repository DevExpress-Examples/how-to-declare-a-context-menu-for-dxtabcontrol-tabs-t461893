using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DXSample.Services;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    [POCOViewModel]
    public class TabsViewModel {

        public TabsViewModel() {
            Tabs = new ObservableCollection<TabViewModel>();
            for (int i = 0; i < 10; i++)
                Tabs.Add(ViewModelSource.Create(() => new TabViewModel() { Content = string.Format("Content_{0}", i), Header = string.Format("Header_{0}", i) }));
        }

        protected ITabControlService TabControlService { get { return this.GetService<ITabControlService>(); } }

        public void HideItem(object item) {
            TabControlService.Hide(item);
        }
        public void ShowAllItems() {
            foreach (var item in Tabs)
                TabControlService.Show(item);
        }

        public virtual ObservableCollection<TabViewModel> Tabs { get; set; }
    }

    [POCOViewModel]
    public class TabViewModel {
        public virtual string Content { get; set; }
        public virtual string Header { get; set; }
    }
}