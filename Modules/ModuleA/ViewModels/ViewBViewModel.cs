using ModuleA.Service;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BindableBase, INavigationAware
    {
        ITestService _testService;

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        //public ViewBViewModel(ITestService testService)
        //{
        //    _testService = testService;
        //    Message = "View B from your Prism Module" + Environment.NewLine + _testService.Test();
        //}

        public ViewBViewModel()
        {
                
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
