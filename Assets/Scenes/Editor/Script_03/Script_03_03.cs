using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_03
{
    // �����θ��� Unity �������εķ����ڽű�����������ȵ��á�����ʱ��̬����
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        {

            if (Selection.activeObject && guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                // ������չ��ť����
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 3f;
                selectionRect.width = width;
                selectionRect.height = (selectionRect.height / 2);
                GUI.color = Color.red;

                // ����¼�
                if (GUI.Button(selectionRect, "click"))
                {
                    Debug.LogFormat("click : {0}", Selection.activeObject.name);
                }
                GUI.color = Color.white;
            }
        };
    }
}
