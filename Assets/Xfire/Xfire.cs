using System.Runtime.InteropServices;
using UnityEngine;

public class AirDropShare : MonoBehaviour
{
    void Awake() {
        Debug.Log("さて起動");
        var documentPath = Application.persistentDataPath;
        var b = new byte[]{1,2,3};

        var path = "something.txt";
        // 保存する。
        
        ShareFile(path);
    }

#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern void _shareFile(string filePath);
#endif

    public void ShareFile(string filePath)
    {
#if UNITY_IOS
        _shareFile(filePath);
#endif
    }
}
