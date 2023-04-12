using UnityEngine;
public class SampleMonoBehaviour : MonoBehaviour
{
    void Awake()
    {
        var buffer = new byte[] { 1, 2, 3 };
        Xfire.ShareFile(buffer);
    }
}