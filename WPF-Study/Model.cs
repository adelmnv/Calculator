using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WPF_Study
{
    class Model : Abstractions.IModel
    {
        public double firstV;
        public double secondV;
        public double res;
        public string curOp;
        public string permanentRes;
        public bool dCheck = false;
        public bool bCheck = false;
        public List<string> arg;
        public List<string> bracketsOperations;
        public List<double> bracketsNumbers;
        public int p;
        public void ShowIn(string message)
        {
            Debug.WriteLine(message);
        }

        public void SaveIn(string message, string mess2, string dop, int bCount, string br)
        {
            if(bCount > 0)
            {
                if (bracketsOperations == null)
                    bracketsOperations = new List<string>();
                if(bracketsNumbers == null)
                    bracketsNumbers = new List<double>();
                Debug.WriteLine(message);
                if (mess2 != "equal"  && mess2 != null && mess2 != "number" && mess2 != "bracket")
                    bracketsOperations.Add(mess2);
                if (dop == "sqrt" && message.Contains("√"))
                    BSqrtCalculation(message);

                else if (dop == "degree")
                    BDegreeCalculation(message);

                else if (message != "")
                    BCalculation(message);
                bCheck = true;
                if (bCount == 2)
                {
                    if (firstV == 0)
                        firstV = PermanemtRes();
                    else if (secondV == 0)
                        secondV = PermanemtRes();
                    else
                        permanentRes = PermanemtRes().ToString();
                    bCheck = false;
                }
            }
            else
            {
                bracketsOperations = null;
                bracketsNumbers = null;
                if (arg == null)
                    arg = new List<string>();
                p = 0;
                Debug.WriteLine(message);
                if (mess2 != "equal" &&  mess2 != "number" )
                {
                    p = 1;
                    arg.Add(mess2);
                    curOp = mess2;
                }
                if (br == "bracket" && (message == null || message == ""))
                    message = permanentRes;
                if (dop == "sqrt" && message.Contains("√"))
                    SqrtCalculation(message);

                else if (dop == "degree")
                    DegreeCalculation(message);

                else if (message != "" && message != null)
                    Calculation(message);
            }
            
        }


        public void BSqrtCalculation(string message)
        {
            double t = double.Parse(message.Trim('√'));
            bracketsNumbers.Add(Math.Sqrt(t));
            dCheck = false;
        }
        public void BDegreeCalculation(string message)
        {
            dCheck = true;
            double t = double.Parse(message);
                bracketsNumbers.Add(Math.Pow(t, 2));
        }
        public void BCalculation(string message)
        {
            if (!dCheck)
                bracketsNumbers.Add(double.Parse(message));
            else
                dCheck = false;
        }

        public double PermanemtRes()
        {
            double r = bracketsNumbers[0];
            int i = 0;
            for(int n = 1; n < bracketsNumbers.Count; n++)
            {
                if (bracketsOperations[i] == "plus")
                    r += bracketsNumbers[n];
                else if(bracketsOperations[i] == "minus")
                    r -= bracketsNumbers[n];
                else if (bracketsOperations[i] == "times")
                    r *= bracketsNumbers[n];
                else if(bracketsOperations[i] == "divide")
                    r /= bracketsNumbers[n];
                i++;
            }
            return r;
        }

        public void Calculation(string message)
        {
            if (!dCheck && !bCheck)
            {
                if (firstV == 0)
                    firstV = double.Parse(message);
                else if (secondV == 0)
                    secondV = double.Parse(message);
                else
                {
                    if (arg.Count >= 2)
                    {
                        if (arg[arg.Count - 2 - p] == "times")
                            firstV = firstV * secondV;
                        else if (arg[arg.Count - 2 - p] == "plus")
                            firstV = firstV + secondV;
                        else if (arg[arg.Count - 2 - p] == "minus")
                            firstV = firstV - secondV;
                        else if (arg[arg.Count - 2 - p] == "divide")
                            firstV = firstV / secondV;
                        secondV = double.Parse(message);
                    }
                    else 
                    {
                        firstV = secondV;
                        secondV = double.Parse(message);
                    }
                }
            }
            else
            {
                dCheck = false;
                bCheck = false;
            }
                
        }

        public void SqrtCalculation(string message)
        {
            double t = double.Parse(message.Trim('√'));
            if (firstV == 0)
                firstV = Math.Sqrt(t);
            else if (secondV == 0)
                secondV = Math.Sqrt(t);
            else
            {
                if (arg.Count >= 2)
                {
                    if (arg[arg.Count - 2 - p] == "times")
                        firstV = firstV * secondV;
                    else if (arg[arg.Count - 2 - p] == "plus")
                        firstV = firstV + secondV;
                    else if (arg[arg.Count - 2 - p] == "minus")
                        firstV = firstV - secondV;
                    else if (arg[arg.Count - 2 - p] == "divide")
                        firstV = firstV / secondV;
                    secondV = Math.Sqrt(t);
                }
                else
                {
                    firstV = secondV;
                    secondV = Math.Sqrt(t);
                }
            }
        }

        public void DegreeCalculation(string message)
        {
            //dCheck = true;
            double t = double.Parse(message);
            if (firstV == 0)
                firstV = Math.Pow(t, 2);
            else if (secondV == 0)
                secondV = Math.Pow(t, 2);
            else
            {
                if (arg.Count >= 2)
                {
                    if (arg[arg.Count - 2 - p] == "times")
                        firstV = firstV * secondV;
                    else if (arg[arg.Count - 2 - p] == "plus")
                        firstV = firstV + secondV;
                    else if (arg[arg.Count - 2 - p] == "minus")
                        firstV = firstV - secondV;
                    else if (arg[arg.Count - 2 - p] == "divide")
                        firstV = firstV / secondV;
                    secondV = Math.Pow(t, 2); 
                }
                else
                {
                    firstV = secondV;
                    secondV = Math.Pow(t, 2);
                }
            }
        }
        public string OperationT()
        {
            if (curOp == "times")
                res = firstV * secondV;
            else if (curOp == "plus")
                res = firstV + secondV;
            else if (curOp == "minus")
                res = firstV - secondV;
            else if (curOp == "divide")
                res = firstV / secondV;
            else
                res = firstV;
            firstV = 0;
            secondV = 0;
            return res.ToString();
        }

        public void DeleteList()
        {
            firstV = 0;
            secondV = 0;
            res = 0;
            arg = null;
            bracketsOperations = null;
            bracketsNumbers = null;
            dCheck = false;
            bCheck = false;
    }
    }
}
