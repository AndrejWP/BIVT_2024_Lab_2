using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10); +++++++
        //program.Task_2_2(5, 1, 3, 1); ++++++
        //program.Task_2_2(5, 1.5, 1.5, 1);  ++++
        //program.Task_2_2(5, 1, 3, 1); +++++++
        //program.Task_2_3(8); ++++++++++
        //program.Task_2_4(3, 1, 2); ++++++++++++
        //program.Task_2_5(6, 25.2); ++++++++
        //program.Task_2_6(3); ++++++++++++
        //program.Task_2_7(4); ++++++++++++
        //program.Task_2_8(3); ++++++++++++++++
        //program.Task_2_9(10); +++++++++++++++++
        //program.Task_2_10(6); +++++++++++++
        //program.Task_2_11(6); ++++++++++++
        //program.Task_2_12(10, 0);
        //program.Task_2_13(1.5, 3, 2);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        //x = double.Parse(Console.ReadLine());
        //y = double.Parse(Console.ReadLine());
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
        {
            answer = true;
        }


        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        //x = double.Parse(Console.ReadLine());
        //y = double.Parse(Console.ReadLine());

        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }


        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0)
        {
            if (a > b) { answer = a; }
            else { answer = b; }
        }
        else
        {
            if (a < b) { answer = a; }
            else { answer = b; }
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        if (a < b)
        {
            if (c > a) { answer = c; }
            else { answer = a; }
        }
        else
        {
            if (c > b) { answer = c; }
            else { answer = b; }
        }

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        if (s <= 2 * (r / Math.PI))
        {
            answer = true;
        }
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        if (Math.Sqrt(r/Math.PI)*2 <= Math.Sqrt(s)) { answer = true; }
            
        return answer;
    }
    public double Task_1_7(double x)
    {
        if (Math.Abs(x) > 1) { return 1; }
        else { return Math.Abs(x); }
    }
    public double Task_1_8(double x)
    {
        if (Math.Abs(x) >= 1) { return 0; }
        else { return x * x - 1; }
    }
    public double Task_1_9(double x)
    {
        if (x <= -1) { return 0; }
        else if (x > 0) { return 1; }
        else { return 1 + x; }
    }
    public double Task_1_10(double x)
    {

        if (x <= -1) { return 1; }
        else if (x > 1) { return -1; }
        else { return -x;}
    }
    #endregion

    #region Level 2
    //сделал
    public double Task_2_1(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);
        return answer;
    }

    // +
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x-a)*(x-a) + (y-b)*(y-b) <= r*r) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }

    //сделал
    public double Task_2_3(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            if (double.Parse(Console.ReadLine()) < 30.0)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }

    // +
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y >= r1*r1)
            {
                if (x * x + y * y <= r2*r2) { answer++; }
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());
            if (input <= norm) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            if (x >= 0 && y >= 0)
            {
                if (x <= Math.PI && y <= Math.Sin(x)) { answer++; }
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(((Console.ReadLine())));
            double y = double.Parse(((Console.ReadLine())));
            if (x > 0)
            {
                if (y > 0) {
                    Console.WriteLine("1 квадрант");
                    answer1++;
                }
                if (y < 0) {
                    Console.WriteLine("4 квадрант"); 
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("2 квадрант");
                }
                if (y < 0)
                {
                    Console.WriteLine("3 квадрант");
                    answer3++;
                }
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        for (int i = 1; i <= n; i ++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(x * x + y * y);
            if (s < answerLength)
            {
                answer = i;
                answerLength = s;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        return (answer, Math.Round(answerLength, 2));
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res < answer)
            {
                answer = res;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if ((a > 3) && (b > 3) && (c > 3) && (d > 3)) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if ((a < 3) || (b < 3) || (c < 3) || (d < 3)) { answer++; }
            avg += (double)(a + b + c + d) / 4;
        }
        avg /= n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r <= 0) { return 0; }
        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = r * r * Math.PI; break;
            case 2: answer = r * r * Math.Sqrt(3) / 4; break;
        }
        
        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if ((A <= 0) || (B <= 0) ) { return 0; }
        switch(type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(
                (Math.PI * A * A) - (Math.PI * B * B));
                break;
            case 2:
                double p = (double) (A + B + B);
                p = (double) p / 2.0;
                answer = Math.Sqrt(p * (p-A) * (p-B) * (p-B));
                break;
        }
        Console.WriteLine(Math.Round(answer, 2));
        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;

        do
        {
            double input = 0;
            bool is_correct = double.TryParse(Console.ReadLine(), out input);
            if (!is_correct)
            {
                break;
            }
            if (input < 30.0) { answer += 0.2; }
        } while (true);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;
        double x, y;
        do
        {
            bool f_check = double.TryParse(Console.ReadLine(), out x);
            if (!f_check) { break; }
            bool s_check = double.TryParse(Console.ReadLine(), out y);
            if (!s_check) { break; }
            if (x >= 0 && y >= 0)
            {
                if (x <= Math.PI && y <= Math.Sin(x)) { answer++; }
            }

        } while (true);
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        do
        {
            double res;
            bool is_correct = double.TryParse(Console.ReadLine(), out res);
            if (!is_correct) { break; }
            if (res < answer) { answer = res; }
        } while (true);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}
