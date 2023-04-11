using System.Runtime.InteropServices;
using UnityEngine;
using System.IO;

public class Xfire : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("さて起動");
        var b = new byte[] { 1, 2, 3 };
        var path = Path.Combine(Application.persistentDataPath, "data.txt");
        using (var sw = new StreamWriter(path))
        {
            sw.Write(b);
        }
        Debug.Log("path:" + path);
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
