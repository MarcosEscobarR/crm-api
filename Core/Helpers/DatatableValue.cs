namespace Core.Helpers
{

    public class DatatableValue<T>
    {
        public DatatableValue(string title, T value)
        {
            Title = title;
            Value = value;
        }

        public string Title { get; set; }
        public T Value { get; set; }
    }
}