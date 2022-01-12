using DesignPatternConsole.Models;

namespace DesignPatternConsole.Patterns.Builder
{
    // https://www.youtube.com/watch?v=WfBsYo20D_I
    public interface ICarBuilder
    {
        public ICarBuilder SetName(string? name);
        public ICarBuilder SetColor(string? color);
        public ICarBuilder SetManifactureDate(DateTime setManifactureDate);

        // it's not in the design pattern...
        public Car GetInstance();
    }

    //Run command:
    //var builderPattern = new CarBuilder()
    //            .SetName("BMW")
    //            .SetColor("Black")
    //            .SetManifactureDate(DateTime.UtcNow);
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car = new();

        // if we have some required property we can put them in the constructor.
        public ICarBuilder SetName(string? name)
        {
            _car.Name = name;
            return this;
        }

        public ICarBuilder SetColor(string? color)
        {
            _car.Color = color;
            return this;
        }

        public ICarBuilder SetManifactureDate(DateTime setManifactureDate)
        {
            _car.ManifactureDate = setManifactureDate;
            return this;
        }

        public Car GetInstance()
        {
            return _car;
        }

    }
}
