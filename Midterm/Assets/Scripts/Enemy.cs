using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int Health = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            Health -= 5;

            if (Health <= 0)
            {
                //Die();
            }
        }
    }
}
