namespace Project5.Application.Interfaces;

public interface IRequestValidator<TRequest>
{
    IEnumerable<string> ValidateRequest(TRequest request);
}
