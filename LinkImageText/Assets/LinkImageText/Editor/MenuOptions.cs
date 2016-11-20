using System;
using System.Reflection;
using UnityEngine;
using UnityEditor;

public static class MenuOptions
{
    private static MethodInfo m_PlaceUIElementRoot;

    [MenuItem("GameObject/UI/LinkImageText", false, 2004)]
    public static void AddText(MenuCommand menuCommand)
    {
        GameObject child = new GameObject("Text");
        RectTransform rectTransform = child.AddComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(160f, 30f);
        LinkImageText lbl = child.AddComponent<LinkImageText>();
        lbl.text = "New LinkImageText";
        lbl.color = new Color(50f / 255f, 50f / 255f, 50f / 255f, 1f);
#if UNITY_5_3_OR_NEWER
        lbl.alignByGeometry = true;
#endif

        PlaceUIElementRoot(child, menuCommand);
    }

    private static void PlaceUIElementRoot(GameObject element, MenuCommand menuCommand)
    {
        if (m_PlaceUIElementRoot == null)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(UnityEditor.UI.TextEditor));
            Type type = assembly.GetType("UnityEditor.UI.MenuOptions");
            m_PlaceUIElementRoot = type.GetMethod("PlaceUIElementRoot", BindingFlags.NonPublic | BindingFlags.Static);
        }
        m_PlaceUIElementRoot.Invoke(null, new object[] {element, menuCommand});
    }
}
