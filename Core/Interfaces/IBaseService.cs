using Core.Helpers.Result;

namespace Core.Interfaces;

public abstract class BaseService
{
    protected static Result MatchResult<T>(T data) => data is null ? Result.NotFound() : Result.Ok(data);
}