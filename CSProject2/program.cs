namespace CSPractice2
{

    internal class Program
    {
        int number = 10;
        static void Main(string[] args)
        {
            // #6 23-7 ������
            int number = 20;
            Console.WriteLine(number); // 20

            // #6 23-7 ���̵�
            Child child = new Child();
            Console.WriteLine(child.variable); // ���: ���̵�
            child.Method(); // ���: �ڽĸ޼���
            Console.WriteLine(((Parent)child).variable); // ���: 273
            ((Parent)child).Method(); // ���: �θ� �޼���
            Parent p = child;
            Console.WriteLine(p.variable); // ���: 273

        }

    }

}