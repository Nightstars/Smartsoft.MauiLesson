using Smartsoft.MauiLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartsoft.MauiLesson.ViewModels
{
    class MainViewModel
    {
        public MainModel mainModel { get; set; } = new MainModel();

        public Command ButtonCommand { get; set; }

        public MainViewModel() {
            ButtonCommand = new Command(DoButtonCommand);
        }

        private void DoButtonCommand()
        {
            mainModel.Value++;
        }
    }
}
