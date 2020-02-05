using System;
using System.Collections;

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


            // Ở đây hàm GetItem() sẽ trả về lần lượt các giá trị 1 - 8. 
            // Vòng lặp foreach sẽ lặp qua từng phần tử đó sau đó nó lại tiếp tục get gái trị từ hàm GetItem()
            foreach (var item in GetItem())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        [Is("Hàm GetItem sử dụng từ khóa yield return để return từng giá trị một Từ khóa yield break dùng để kết thúc vòng lặp")]
        private static IEnumerable GetItem()
        {
            for (int i = 1; i <= 8; i++)
            {
                if (i == 8)
                {
                    yield break;
                }

                yield return i;
            }
        }
    }

    [Is("Extension method cần được chứa trong static class")]
    static class MyClass
    {
        [Is(" Extension method phương thức mở rộng trong C# Phương thức mở rộng tính bình phương của một số kiểu int")]
        public static int Square(this int n)
        {
            return n * n;
        }

        [Is("Attribute có sẵn")]
        [Obsolete("This method is obsolete")]
        public static int Square1(this int n)
        {
            return n * n;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method) ]
    public class IsAttribute : Attribute
    {
        public IsAttribute(string v) => Description = v;

        public string Description { set; get; }
    }
	
	// abfsdafdafdsssdfs
	//fsdafsdafsdafd
	//fsdafdaf
}
