using UnityEngine;

public class Coins : MonoBehaviour
{
    private float pontos;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pontos += 1;
            Debug.Log(pontos);
        }
    }
}
