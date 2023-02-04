public class BaseSort
{
    protected int[] arr;
    protected BaseBinarySearch binarySearch;

    public BaseSort(int[] arr)
    {
        this.arr = arr;
    }

    public virtual BaseBinarySearch ReturnBinarySearchTypeIfSorted()
    {
        return null;
    }
}
