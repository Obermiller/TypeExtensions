namespace Obermiller.TypeExtensions;

public static class NumericExtensions
{
    public static int[] SplitToIntArray(string x, string delimiter)
    {
        var splitString = x.Split(delimiter);
        var array = new int[splitString.Length];
        
        foreach (var split in splitString.WithIndex())
        {
            if (!int.TryParse(split.item, out var itemAsInt))
            {
                return Array.Empty<int>();
            }

            array[split.index] = itemAsInt;
        }

        return array;
    }
}