using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_MVVM.ViewModels
{
    interface IClosableViewModel
    {
        event EventHandler CloseWindowEvent;
    }
}
