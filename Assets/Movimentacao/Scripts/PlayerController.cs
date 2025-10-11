using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadeMovimento = 5f;
    public float forcaPulo = 10f;

    private bool estaNoChao;
    public Transform verificadorChao;
    public float raioVerificacao = 0.2f;
    public LayerMask camadaChao;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 3;
    }

    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimentoX * velocidadeMovimento, rb.linearVelocity.y);

        estaNoChao = Physics2D.OverlapCircle(verificadorChao.position, raioVerificacao, camadaChao);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (estaNoChao)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(verificadorChao.position, raioVerificacao);
    }
}
