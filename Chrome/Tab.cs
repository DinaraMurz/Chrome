﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chrome
{
    public abstract class Tab : ITab
    {
        public Tab()
        {
            CloseCommand = new ActionCommand(p => CloseRequested?.Invoke(this, EventArgs.Empty));
        }
        public string Name { get; set; }
        public ICommand CloseCommand { get; }
        public event EventHandler CloseRequested;
    }
}
