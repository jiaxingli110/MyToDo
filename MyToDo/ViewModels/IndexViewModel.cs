using MyToDo.Comman;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class IndexViewModel :BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBars();
        }
        private ObservableCollection<TaskBar> taskBars;
        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value; RaisePropertyChanged();}
        }
        void CreateTaskBars()
        {
             TaskBars.Add(new TaskBar() { Icon="ClockFast", Title="汇总",Content="9",Color="#FF0CA0FF", Target=""});
             TaskBars.Add(new TaskBar() { Icon="ClockCheckOutline", Title="汇总",Content="39",Color="#FF1ECA3A", Target=""});
             TaskBars.Add(new TaskBar() { Icon="ChartLineVariant", Title="汇总",Content="19",Color="#FF02C6DC", Target=""});
             TaskBars.Add(new TaskBar() { Icon="PlaylistStar", Title="汇总",Content="29",Color="#FFFFA000", Target=""});
        }
    }
}
