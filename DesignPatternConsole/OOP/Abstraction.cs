namespace ConsoleBeforeExam.Cases.OOP
{
    //var first = new FirstService();
    //var result1 = first.Handle(new FirstRequest { RequestValue = 50 });
    //var result2 = first.Handle(new FirstRequest { RequestValue = 300 });
    public interface IRequest { abstract int RequestValue { get; set; } }
    public interface IResponse { abstract int ResponseValue { get; set; } }

    public abstract class BaseRequestService<Request, Response>
        where Request : IRequest
        where Response : IResponse
    {
        public Response? Handle(Request request)
        {
            if (ValidateRequest(request))
                if (GrantAccess(request))
                    return Run(request);

            Console.WriteLine("Validation or Access error!");
            return default;
        }

        protected abstract bool ValidateRequest(Request request);
        protected abstract bool GrantAccess(Request request);
        protected abstract Response? Run(Request request);

    }

    public class FirstRequest : IRequest { public int RequestValue { get; set; } }
    public class FirstResponse : IResponse { public int ResponseValue { get; set; } }

    public class FirstService : BaseRequestService<FirstRequest, FirstResponse>
    {
        protected override bool GrantAccess(FirstRequest request)
        {
            return request.RequestValue < 100;
        }
        protected override bool ValidateRequest(FirstRequest request)
        {
            return request.RequestValue < 200;
        }

        protected override FirstResponse? Run(FirstRequest request)
        {
            return new FirstResponse { ResponseValue = request.RequestValue };
        }


    }
}
