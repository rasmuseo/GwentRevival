namespace Api.Extensions;

public static class ArrayExtensions
{
    public static IEnumerable<T> ToEnumerable<T>(this Array target)
    {
        foreach (var item in target)
            if (item is not null)
            {
                yield return (T)item;
            }
    }
}