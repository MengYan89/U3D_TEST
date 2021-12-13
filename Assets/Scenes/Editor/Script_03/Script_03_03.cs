using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_03
{
    // 该修饰告诉 Unity ，被修饰的方法在脚本编译完后首先调用。必须时静态方法
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        {

            if (Selection.activeObject && guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                // 设置拓展按钮区域
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 3f;
                selectionRect.width = width;
                selectionRect.height = (selectionRect.height / 2);
                GUI.color = Color.red;

                // 点击事件
                if (GUI.Button(selectionRect, "click"))
                {
                    Debug.LogFormat("click : {0}", Selection.activeObject.name);
                }
                GUI.color = Color.white;
            }
        };
    }
}
