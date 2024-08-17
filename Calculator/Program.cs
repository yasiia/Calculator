namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your expresions:");
                string expression = Console.ReadLine();
                double result = EvaluateExpression(expression);
                Console.WriteLine($"Result: {result}");
            }

            static double EvaluateExpression(string expression)
            {
                double result = 0;
                char[] operators = { '+', '-', '*', '/' };
                string[] tokens = expression.Split(operators);
                char[] ops = new char[tokens.Length - 1];
                int opIndex = 0;

                // Зберігаємо оператори
                for (int i = 0; i < expression.Length; i++)
                {
                    if (operators.Contains(expression[i]))
                    {
                        ops[opIndex++] = expression[i];
                    }
                }


                for (int i = 0; i < ops.Length; i++)
                {
                    double nextValue = Convert.ToDouble(tokens[i + 1]);
                    double prevValue = Convert.ToDouble(tokens[i]);

                    if (ops[i] == '*')
                    {
                        result = prevValue * nextValue;
                    }
                    else if (ops[i] == '/')
                    {
                        result = prevValue / nextValue;
                    }
                    else
                    {
                        result = Convert.ToDouble(tokens[i + 1]);
                    }
                }

                // Обчислюємо додавання і віднімання
                result = Convert.ToDouble(tokens[0]);
                for (int i = 0; i < ops.Length; i++)
                {
                    double nextValue = Convert.ToDouble(tokens[i + 1]);

                    if (ops[i] == '+')
                    {
                        result += nextValue;
                    }
                    else if (ops[i] == '-')
                    {
                        result -= nextValue;
                    }
                }

                return result;
                // не виходить зберегти результат множення і ділення для дій другого порядку
            }
    }
}
