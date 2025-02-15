using UnityEngine;

public class Zoom : MonoBehaviour
{
    public SpriteRenderer targetSize;
    void Start()
    {
        float screenRatio=(float)Screen.width / (float)Screen.height;
        float targetRatio=targetSize.bounds.size.x/targetSize.bounds.size.y;
        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = targetSize.bounds.size.y / 2;
        }
        else
        {
            float differentInSize=targetRatio/screenRatio;
            Camera.main.orthographicSize = targetSize.bounds.size.y / 2 * differentInSize;
        }
    }  
}
