[UnityEditor.InitializeOnLoad]
public class IfSortedDoBinarySearch
{
    private static readonly int itemToSearch = -2;

    //ASC
    //private static readonly int[] arr = new int[] { -2, 5, 10, 20, 30, 50, 55, 65 };
    //DESC
    private static readonly int[] arr = new int[] { 65, 55, 50, 30, 20, 10, 5, -2 };

    private static readonly BaseSort[] sortedArray = new BaseSort[] { new AscSort(arr) , new DescSort(arr) };

    private static BaseBinarySearch binarySearch;

    static IfSortedDoBinarySearch()
    {
        if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode) 
            return;
        Init();
    }

    [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        for (int i = 0; i < sortedArray.Length; i++)
        {
            if (binarySearch == null)
            {
                binarySearch = sortedArray[i].ReturnBinarySearchTypeIfSorted();
            }
        }
        binarySearch.DoBinarySearch(arr, itemToSearch);
    }
}