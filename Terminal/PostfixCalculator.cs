using System.Security.Principal;

namespace Terminal;
internal class PostfixCalculator
{
    string[] input = ["4", "2", "6", "*", "+", "8", "-", "2"];
    MyStack<double> mystack = new();
    public void Postfix()
    {
        foreach (var token in input)
        {
            if (double.TryParse(token, out double value))
            {
                mystack.Push(value);
            }
            else
            {
                double right = mystack.Pop();
                double left = mystack.Pop();
                double answer = 0;
                switch (token)
                {
                    case "+":
                        answer = right + left;
                        break;
                    case "-":
                        answer = right + left;
                        break;
                    case "*":
                        answer = right + left;
                        break;
                    case "/":
                        answer = right + left;
                        break;
                    default:
                        break;
                }
                mystack.Push(answer);
            }
        }
    }
}
