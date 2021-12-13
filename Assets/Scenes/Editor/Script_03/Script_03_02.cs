using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_02
{
    [MenuItem("Assets/Create/My Create/Cube", false, 2)]
    static void CreateCube()
    {
        // 创建立方体
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    [MenuItem("Assets/Create/My Create/Sphere", false, 1)]
    static void CreateSphere()
    {
        // 创建球体
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }

}
