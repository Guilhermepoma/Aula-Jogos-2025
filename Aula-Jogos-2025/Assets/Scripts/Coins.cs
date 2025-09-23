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
            Debug.Log("colidiu");
            pontos += 10;
            Debug.Log(pontos);
        }
    }
}
