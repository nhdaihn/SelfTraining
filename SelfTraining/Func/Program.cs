using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func là một delegate có sẵn trả về giá trị.
            // Func đầu vào 2 kiểu int. Đầu ra một kiểu string.
            Func<int, int, string> MyFunc = (a, b) => (a + b).ToString();
            Console.WriteLine(MyFunc(1, 1));

            // Action là một delegate trả về kiểu void :
            // Nhập vào 2 kiểu int. Trả về một kiểu void
            Action<int, int> MyAction = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");

            // Predicate là một delegate trả về kiểu bool.
            // Nhập vào một kiểu int check xem có chia hết cho 2 không
            Predicate<int> predicate = p => p % 2 == 0;
            Console.WriteLine(predicate(2));

            // Thực thi Extension method Square
            Console.WriteLine(5.Square());
        }
    }

    static class MyClass
    {
        // Extension method phương thức mở rộng trong C#.
        // Phương thức mở rộng tính bình phương của một số kiểu int.
        public static int Square(this int n)
        {
            return n * n;
        }
    }
}
