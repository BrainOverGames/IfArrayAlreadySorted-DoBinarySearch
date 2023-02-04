using UnityEngine;

public class DescBinarySearch : BaseBinarySearch
{
    public override void DoBinarySearch(int[] arr, int itemToSearch)
    {
        base.DoBinarySearch(arr, itemToSearch);
        DoDescBinarySearch();
    }

    private void DoDescBinarySearch()
    {
        while (first <= last)
        {
            mid = (first + last) / 2;

            if (arr[mid] == itemToSearch)
            {
                //Debug.Log("FOUND",first);
                Debug.Log("DESC FOUND at index " + mid);
                //Debug.Log("FOUND",last);     
                isFound = true;
                break;
            }
            else if (arr[mid] > itemToSearch)
            {
                //descending
                first = mid + 1;
            }
            else if (arr[mid] < itemToSearch)
            {
                //descending
                last = mid - 1;
            }
        }
        if (!isFound)
        {
            Debug.LogError("DESC NOT FOUND");
        }
    }
}
