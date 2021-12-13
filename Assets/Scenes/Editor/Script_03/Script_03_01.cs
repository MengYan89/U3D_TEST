using UnityEngine;
using UnityEditor;


public class Script_03_01
{

    [MenuItem("Assets/My Tools/Tools 1", true, 2)]
    static bool MyTools1Check()
    {
        return Selection.activeObject != null;
    }

    [MenuItem("Assets/My Tools/Tools 1", false, 2)]
    static void MyTools1()
    {
        Debug.Log("Tools 1 " + Selection.activeObject.name);
    }

    [MenuItem("Assets/My Tools/Tools 2", false, 1)]
    static void MyTools2()
    {
        Debug.Log("Tools 2 " + Selection.activeObject.name);
    }


}
