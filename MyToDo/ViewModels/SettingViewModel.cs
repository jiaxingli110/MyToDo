using MyToDo.Common;
using MyToDo.Extension;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class SettingViewModel : BindableBase
    {
        public SettingViewModel(IRegionManager regionManager)
        {
            MenuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();
            this.regionManager = regionManager;
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
        }
        private readonly IRegionManager regionManager;
        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }
        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }
        private void Navigate(MenuBar bar)
        {
            if (bar == null  || string.IsNullOrEmpty(bar.NameSpace))
                return;

            regionManager.Regions[PrismManager.SettingViewRegionName].RequestNavigate(bar.NameSpace);

        }
        void CreateMenuBar()
        {
             MenuBars.Add(new MenuBar() { Icon="Home",Title="个性化",NameSpace="SkinView"});
             MenuBars.Add(new MenuBar() { Icon="Cog",Title="系统设置",NameSpace="ToDoView"});
             MenuBars.Add(new MenuBar() { Icon="Information",Title="关于更多",NameSpace="AboutView"});
        }
    }
}
