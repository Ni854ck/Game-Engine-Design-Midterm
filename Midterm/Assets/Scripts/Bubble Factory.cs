using UnityEngine;

public class BubbleFactory : MonoBehaviour
{
    [SerializeField] private GameObject bubblePrefab;
    [SerializeField] private GameObject heavyBubblePrefab;

    public GameObject CreateBubble(
        BubbleType type,
        Vector3 position)
    {
        GameObject prefab = null;

        switch (type)
        {
            case BubbleType.Bubble:
                prefab = bubblePrefab;
                break;

            case BubbleType.HeavyBubble:
                prefab = heavyBubblePrefab;
                break;
        }

        if (prefab == null)
        {
            return null;
        }

        return Instantiate(prefab, position, Quaternion.identity);
    }

    public enum BubbleType
    {
        Bubble,
        HeavyBubble
    }
}
