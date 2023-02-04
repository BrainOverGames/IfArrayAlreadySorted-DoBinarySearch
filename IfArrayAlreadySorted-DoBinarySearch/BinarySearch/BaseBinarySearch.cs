using System;

public class BaseBinarySearch
{
    protected int[] arr;
    protected int first = 0;
    protected int last;
    protected int itemToSearch;
    protected int mid = 0;
    protected bool isFound = false;

    public virtual void DoBinarySearch(int[] arr, int itemToSearch)
    {
        this.arr = arr;
        last = arr.Length - 1;
        this.itemToSearch = itemToSearch;
    }
}
