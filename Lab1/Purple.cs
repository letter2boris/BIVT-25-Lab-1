namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0 && c > 0) 
            { 
                answer = true;
            }
            if (a < 0 && b < 0 && c < 0) 
            { 
                answer = true;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 && b == 0)
            {
                answer = false;
            }
            else if (a == 0) 
            {
                answer = true;
            }
            else if (b == 0)
            {
                answer = true;
            }
            else if (a % b == 0 || b % a == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            // Проверяем, является ли a квадратным или кубическим корнем из b
            if (a != 0)
            {
                // Проверка квадратного корня
                if (a * a == b)
                    return true;

                // Проверка кубического корня
                if (a * a * a == b)
                    return true;
            }

            // Проверяем, является ли b квадратным или кубическим корнем из a
            if (b != 0)
            {
                // Проверка квадратного корня
                if (b * b == a)
                    return true;

                // Проверка кубического корня
                if (b * b * b == a)
                    return true;
            }

            // Особые случаи с нулями
            if (a == 0 && b == 0)
                return true; // 0 является корнем 0
            if (a == 0 && b != 0)
                return false; // 0 не может быть корнем ненулевого числа
            if (a != 0 && b == 0)
                return false; // ненулевое число не может быть корнем 0
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = Math.Pow(f, 2) - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) 
            {
                answer = 1;
            }
            if (-1 < x && x <= 1) 
            {
                answer = -x;
            }
            if (x > 1) 
            {
                answer = -1;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            if (2*Math.Sqrt(circleS / Math.PI) >= Math.Sqrt(2* squareS)) 
            {
                answer = true;
            }
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else 
            {
                if (t)
                {
                    answer = 3;
                }
                else 
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else 
                    {
                        answer = 1;
                    }
                }
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            if (DateTime.IsLeapYear(year))
            {
                return false;
            }
            int avr = (pupils + 6) / 7;
            
            int need = salary * avr + pupils * 5;
            if (need <= bank)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}