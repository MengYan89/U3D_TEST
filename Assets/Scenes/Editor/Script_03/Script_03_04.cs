using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_03_04 : UnityEditor.AssetModificationProcessor
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        // ȫ�ּ���project��ͼ�µ���Դ�Ƿ����仯(��ӡ�ɾ�����ƶ�)
        EditorApplication.projectChanged += delegate ()
        {
            Debug.Log("change");
        };
    }

    // ������˫��������������Դ���¼�
    public static bool IsOpenForEdit(string assetPath, out string message)
    {
        message = null;
        Debug.LogFormat("assetPath : {0}", assetPath);
        // true ��ʾ����Դ���Դ�. false��ʾ��������Unity�д򿪸���Դ
        return true;
    }

    //��������Դ�������������¼�
    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat("path : {0}", path);
    }

    // ����"��Դ����������"�¼�
    public static string[] OnWillSaveAsset(string[] paths)
    {
        if (paths != null)
        {
            Debug.LogFormat("path : {0}", string.Join(",", paths));
        }
        return paths;
    }

    // ����"��Դ�������ƶ�"�¼�
    public static AssetMoveResult OnWillMoveAsset(string oldPath, string newPath)
    {
        Debug.LogFormat("from : {0} to : {1}", oldPath, newPath);
        // AssetMoveResult.DidMove ��ʾ����Դ�����ƶ� FailedMove��ʾ�����ƶ�������DidNotMove
        return AssetMoveResult.DidNotMove;
    }

    // ����"��Դ������ɾ��"�¼�
    public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option)
    {
        Debug.LogFormat("delete : {0}", assetPath);
        //AssetDeleteResult.DidDelete ��ʾ��Դ���Ա�ɾ��
        return AssetDeleteResult.DidNotDelete;
    }


}
