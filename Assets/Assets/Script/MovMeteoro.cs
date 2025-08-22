using UnityEngine;
using TMPro;

public class MovMeteoro : MonoBehaviour
{
    public Transform posicaoPlaneta;
    public float velocidade = 0.1f;
    private Vector3 posicao;
    private Rigidbody rb;

    public TMP_Text gameOverText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverText.gameObject.SetActive(true);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         posicao= Vector3.MoveTowards(transform.position, posicaoPlaneta.position, Time.fixedDeltaTime * velocidade);
         rb.MovePosition(posicao);
    }
}
