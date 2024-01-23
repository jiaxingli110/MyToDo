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
            ToDoDtos = new ObservableCollection<ToDoDto>();
            memoDtos = new ObservableCollection<MemoDto>(); 
            CreateTaskBars();
            CreateTestData();
        }
        private ObservableCollection<TaskBar> taskBars;
        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value; RaisePropertyChanged();}
        }
        private ObservableCollection<ToDoDto> toDoDtos;
        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged();}
        }
        private ObservableCollection<MemoDto> memoDtos;
        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value; RaisePropertyChanged();}
        }
        void CreateTaskBars()
        {
             TaskBars.Add(new TaskBar() { Icon="ClockFast", Title="汇总",Content="9",Color="#FF0CA0FF", Target=""});
             TaskBars.Add(new TaskBar() { Icon="ClockCheckOutline", Title="汇总",Content="39",Color="#FF1ECA3A", Target=""});
             TaskBars.Add(new TaskBar() { Icon="ChartLineVariant", Title="汇总",Content="19",Color="#FF02C6DC", Target=""});
             TaskBars.Add(new TaskBar() { Icon="PlaylistStar", Title="汇总",Content="29",Color="#FFFFA000", Target=""});
        }
        void CreateTestData()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            MemoDtos = new ObservableCollection<MemoDto>();
            for (int i = 0; i < 10; i++)
            {
                ToDoDtos.Add(new ToDoDto() { Title ="待办"+i ,Content ="正处理..."});
                MemoDtos.Add(new MemoDto() { Title ="备忘"+i , Content ="我的密码"});
            }
        }
    }
}
