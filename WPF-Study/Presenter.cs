using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study
{
    class Presenter
    {
        private Abstractions.IModel model;
        private Abstractions.IView view;
        public Presenter(Abstractions.IModel model, Abstractions.IView view)
        {
            this.model = model;
            this.view = view;
            this.view.OnTextChanged += Show;
            this.view.SaveValue += Save;
            this.view.Result += GetResult;
            this.view.Clear += Delete;
        }

        void Show(object sender, EventArgs e)
        {
            model.ShowIn(view.TextBox);
        }

        void Save(object sender, EventArgs e)
        {
            model.SaveIn(view.TextBox, view.Operation, view.DopOperation, view.BracketsCount, view.BracketOp);
        }

        void GetResult(object sender, EventArgs e)
        {
            view.ClearText();
            view.GetResult(model.OperationT());
        }

        void Delete(object sender, EventArgs e)
        {
            model.DeleteList();
        }
    }
}
