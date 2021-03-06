using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotvvmWeb.Views.Docs.Controls.builtin.TextBox.sample2
{
    public class ViewModel : DotvvmViewModelBase
    {
        public string Text { get; set; } = "Simple Text";

        public string Password { get; set; } = "1234";

        public string Message { get; set; } = "Message with \n multiple lines.";
    }
}
