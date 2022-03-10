namespace ConsoleBeforeExam.Cases.OOP
{
    public abstract class ServiceBase
    {
        public virtual int Value()
        {
            return 10;
        }
    }

    public class Sevice1 : ServiceBase
    {

    }

    public class Sevice2 : ServiceBase
    {
        public override int Value()
        {
            return 20;
        }
    }
}
