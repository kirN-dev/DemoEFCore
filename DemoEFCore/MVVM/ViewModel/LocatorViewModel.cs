﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCore.MVVM.ViewModel
{
    class LocatorViewModel
    {
        public MainViewModel MainViewModel => App.Services.GetRequiredService<MainViewModel>();
    }
}
