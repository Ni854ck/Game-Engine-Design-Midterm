using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField] private BubbleFactory bubbleFactory;

    private void Start()
    {
        bubbleFactory.CreateBubble(
            BubbleFactory.BubbleType.Bubble,
            new Vector3(-4f, 0f, 0f)
        );

        bubbleFactory.CreateBubble (
        BubbleFactory.BubbleType.HeavyBubble,
        new Vector3(10f, 0f, 0f)
    );
    }
}
