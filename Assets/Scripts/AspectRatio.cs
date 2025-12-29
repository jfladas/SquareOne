using UnityEngine;

public class AspectRatio : MonoBehaviour
{
    [SerializeField] Vector2Int aspectRatio = new(16, 9);
    public bool fullScreen = true;

    void Start()
    {
        Vector2Int size = default;
        float currentRatio = (float)Screen.width / Screen.height;
        float ratioGoal = (float)aspectRatio.x / aspectRatio.y;
        if (currentRatio > ratioGoal)
        {
            size.y = Screen.height;
            size.x = (int)(Screen.height * ratioGoal);
        }
        else
        {
            size.y = (int)(Screen.width / ratioGoal);
            size.x = Screen.width;
        }
        Screen.SetResolution(size.x, size.y, fullScreen);
    }
}
