public class AscSort : BaseSort
{
    public AscSort(int[] arr) : base(arr)
    {
        binarySearch = new AscBinarySearch();
    }

    public override BaseBinarySearch ReturnBinarySearchTypeIfSorted()
    {
        int last = arr.Length - 1;
        if (last < 1) return binarySearch;

        int i = 0;

        while (i < last && arr[i] <= arr[i + 1])
            i++;

        if (i == last)
            return binarySearch;
        else return null;
    }
}
