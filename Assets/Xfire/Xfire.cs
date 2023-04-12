using System.Runtime.InteropServices;
using UnityEngine;
using System.IO;
using System;

public static class Xfire
{
    private const string XFIRE_DIR_NAME = "xfire";

#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern void _shareFile(string filePath);
#endif

    public static void ShareFile(byte[] buffer)
    {
#if UNITY_IOS
        try
        {
            if (!Directory.Exists(Path.Combine(Application.persistentDataPath, XFIRE_DIR_NAME)))
            {
                Directory.CreateDirectory(Path.Combine(Application.persistentDataPath, XFIRE_DIR_NAME));
            }

            var path = Path.Combine(Application.persistentDataPath, XFIRE_DIR_NAME, "data.txt");// 毎回同じファイルを書き潰す
            File.WriteAllBytes(path, buffer);
            _shareFile(path);
        }
        catch (Exception e)
        {
            Debug.LogError("failed to send file. e:" + e);
        }
#endif
    }
}
