using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadeMovimento = 5f;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // sem gravidade no top-down
        rb.freezeRotation = true;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal");
        float movimentoY = Input.GetAxisRaw("Vertical");

        Vector2 movimento = new Vector2(movimentoX, movimentoY).normalized;
        rb.linearVelocity = movimento * velocidadeMovimento;

        // Atualiza a animação (se tiver)
        bool estaAndando = movimento.magnitude > 0;
        animator.SetBool("walking", estaAndando);

        // Flip horizontal opcional
        if (movimentoX > 0) transform.localScale = new Vector3(1, 1, 1);
        else if (movimentoX < 0) transform.localScale = new Vector3(-1, 1, 1);
    }
}
