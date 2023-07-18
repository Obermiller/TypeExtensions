namespace Obermiller.TypeExtensions.Numeric;

public static class IntegerExtensions
{
    public static int[] SplitToArray(string x, string delimiter)
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

    public static List<int> SplitToList(string x, string delimiter)
    {
        var splitString = x.Split(delimiter);
        var list = new List<int>();

        foreach (var number in splitString)
        {
            if (!int.TryParse(number, out var numberAsInt))
            {
                return new List<int>();
            }
            
            list.Add(numberAsInt);
        }

        return list;
    }
}