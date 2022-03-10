namespace ConsoleBeforeExam.Cases.OOP
{
    //new Class1(23).Run();
    public abstract class BaseClass
    {
        protected int _value;
        public BaseClass(int value)
        {
            _value = value;
        }

        public void Run()
        {
            Console.WriteLine(_value);
        }
    }

    public class Class1 : BaseClass
    {
        public Class1(int value) : base(value) { }


    }
}
