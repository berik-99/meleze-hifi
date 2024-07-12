namespace Meleze.SBC.GUI.Helpers;

public static class ListExtensions
{
    public static int DistanceBetween<T>(this List<T> list, T fromElement, T toElement) => list.DistanceBetween(list.IndexOf(fromElement), list.IndexOf(toElement));

    public static int DistanceBetween<T>(this List<T> list, int fromIndex, int toIndex)
    {
        if (fromIndex == -1 || toIndex == -1)
            throw new ArgumentException("One or both elements not found in the list");
        int forwardSteps = (toIndex - fromIndex + list.Count) % list.Count;
        int backwardSteps = forwardSteps - list.Count;
        return Math.Abs(forwardSteps) <= Math.Abs(backwardSteps) ? forwardSteps : backwardSteps;
    }
}
