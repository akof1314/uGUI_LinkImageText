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

            LinkImageText text = go.GetComponentInChildren<LinkImageText>();
            text.text = "<quad name=xb_a size=25 width=1 />";
            if (Random.value > 0.5f)
            {
                text.text += text.text;
            }
        }
    }
}
