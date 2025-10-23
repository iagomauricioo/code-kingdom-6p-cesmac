using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; // o player
    public float suavizacao = 0.15f; // quanto mais alto, mais lenta a câmera acompanha
    private Vector3 velocidade = Vector3.zero;

    void LateUpdate()
    {
        if (alvo == null) return;

        Vector3 posicaoDesejada = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, posicaoDesejada, ref velocidade, suavizacao);
    }
}
