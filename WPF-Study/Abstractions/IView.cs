using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IView
    {
        string TextBox { get; set; }
        string TextOp { get; set; }
        string Operation { get; set; }
        string UpOperation { get; set; }
        int BracketsCount { get; set; }
        string DopOperation { get; set; }
        string BracketOp { get; set; }

        bool IsZero { get; set; }
        void ClearText();
        void ClearOp();
        void GetResult(string str1);
        event EventHandler OnTextChanged;
        event EventHandler SaveValue;
        event EventHandler Result;
        event EventHandler Clear;
    }
}
