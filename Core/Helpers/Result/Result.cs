namespace Core.Helpers.Result;

public  class Result
{
    public bool IsSuccessful;
    public bool IsNotFound;
    public object Data { get; set; }

    private Result(bool isSuccessful, bool isNotFound, object data = null)
    {
        IsSuccessful = isSuccessful;
        IsNotFound = isNotFound;
        Data = data;
    }

    public static Result Ok() => new(true, false);
    public static Result Ok<T>(T data) => new(true, false, data);
    public static Result NotFound() => new(false, true);
}