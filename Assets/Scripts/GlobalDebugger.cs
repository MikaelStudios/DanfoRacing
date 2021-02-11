using UnityEngine;

public class GlobalDebugger : MonoBehaviour
{
    public static GlobalDebugger instance;
    public Vector3 camOffset;
    public float distance = 2f;
    public float height = 1.5f;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }
}
