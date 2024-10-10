using StackProject;
namespace Terminal;
internal class PostfixCalculator
{
    public string[] input = ["4", "2", "6", "*", "+", "8", "-", "2"];
    public MyStack<double> mystack = new();
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
                        answer = left + right;
                        break;
                    case "-":
                        answer = left - right;
                        break;
                    case "*":
                        answer = left * right;
                        break;
                    case "/":
                        answer = left / right;
                        break;
                    default:
                        break;
                }
                mystack.Push(answer);
            }
        }
    }
}
