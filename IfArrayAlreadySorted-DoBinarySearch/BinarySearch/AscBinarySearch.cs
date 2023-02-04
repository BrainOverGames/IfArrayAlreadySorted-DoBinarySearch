using UnityEngine;

public class AscBinarySearch : BaseBinarySearch
{
    public override void DoBinarySearch(int[] arr, int itemToSearch)
    {
        base.DoBinarySearch(arr, itemToSearch);
        DoAscBinarySearch();
    }

    private void DoAscBinarySearch()
    {
        while (first <= last)
        {
            mid = (first + last) / 2;

            if (arr[mid] == itemToSearch)
            {
                //Debug.Log("FOUND",first);
                Debug.Log("ASC FOUND at index "+ mid);
                //Debug.Log("FOUND",last);   
                isFound = true;
                break;
            }
            else if (arr[mid] > itemToSearch)
            {
                //ascending
                last = mid - 1;
            }
            else if (arr[mid] < itemToSearch)
            {
                //ascending
                first = mid + 1;
            }
        }
        if (!isFound)
        {
            Debug.LogError("ASC NOT FOUND");
        }
    }
}
