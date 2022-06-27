using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IModel
    {
        void ShowIn(string message);
        void SaveIn(string message, string mess2, string dop, int bCount, string brackets);
        string OperationT();
        void DeleteList();

        void SqrtCalculation(string message);
        void DegreeCalculation(string message);
        void Calculation(string message);

        double PermanemtRes();
        void BSqrtCalculation(string message);
        void BDegreeCalculation(string message);
        void BCalculation(string message);
    }
}
