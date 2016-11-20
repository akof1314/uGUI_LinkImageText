using UnityEngine;

public class testScrollView : MonoBehaviour
{
    public GameObject goPrefab;

    public void Add()
    {
        if (goPrefab)
        {
            GameObject go = Instantiate(goPrefab);
            go.transform.SetParent(goPrefab.transform.parent);
        }
    }
}
