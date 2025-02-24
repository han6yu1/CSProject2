namespace CSPractice2
{

    internal class Program
    {
        int number = 10;
        static void Main(string[] args)
        {
            // #6 23-7 섀도잉
            int number = 20;
            Console.WriteLine(number); // 20

            // #6 23-7 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable); // 출력: 하이딩
            child.Method(); // 출력: 자식메서드
            Console.WriteLine(((Parent)child).variable); // 출력: 273
            ((Parent)child).Method(); // 출력: 부모 메서드
            Parent p = child;
            Console.WriteLine(p.variable); // 출력: 273

            // #6 23-8 오버라이딩
            child2 child2 = new Child2();
            child2.Method(); // 출력: 오버라이드 된 자식 메서드
            ((Parent)child2).Method(); // 출력: 오버라이드 된 자식 메서드
            
        }

    }

}