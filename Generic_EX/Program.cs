namespace Generic_EX
{
     class Program
    {
        public class GenericList<T>
        {
            private List<T> _list = new List<T>();
            public void Add(T input)
            {
                _list.Add(input);
            }
            public T Get(int index)
            {
                return _list[index];
            }
        }

        // 제네릭 메서드 정의
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        public static void Run()
        {
            // 제네릭 클래스 사용 예
            GenericList<int> intList = new GenericList<int>();
            intList.Add(10);
            intList.Add(20);
            Console.WriteLine($"First element : {intList.Get(0)}");
            
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine($"First element : {stringList.Get(0)}");

            Print<string>("Hello World");
            Print<int>(1);
        }
        static void Main(string[] args)
        {
           Run();
        }
    }
}
