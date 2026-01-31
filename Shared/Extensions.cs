namespace Contoso.Spaces.Web.Shared
{
    public static class RazorExtensions
    {
        public static List<List<T>> Chunk<T>(this List<T> source, int size = 2)
        {
            var target = new List<List<T>>();
            for (int i = 0; i < source.Count; i += size)
            {
                target.Add(source.GetRange(i, Math.Min(size, source.Count - i)));
            }
            return target;
        }
    }
}