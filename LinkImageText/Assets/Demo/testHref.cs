using UnityEngine;

public class testHref : MonoBehaviour
{
    public LinkImageText textPic;

    void Awake()
    {
        textPic = GetComponent<LinkImageText>();
    }

    void OnEnable()
    {
        textPic.onHrefClick.AddListener(OnHrefClick);
    }

    void OnDisable()
    {
        textPic.onHrefClick.RemoveListener(OnHrefClick);
    }

    private void OnHrefClick(string hrefName)
    {
        Debug.Log("点击了 " + hrefName);
    }
}
