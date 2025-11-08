using UnityEngine;

public class VillagerInteraction : MonoBehaviour
{
    [Header("Configurações de Interação")]
    public float distanciaInteracao = 2f; // Distância para ativar a interação
    public DialogueUI dialogueUI; // Referência ao script de UI
    
    private Transform player;
    private bool playerProximo = false;
    
    void Start()
    {
        // Procura o player na cena
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj == null)
        {
            // Se não tiver tag, procura por nome
            playerObj = GameObject.Find("Player");
        }
        
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
        else
        {
            Debug.LogWarning("Player não encontrado! Certifique-se de que o GameObject do player tem a tag 'Player' ou se chama 'Player'.");
        }
        
        // Se não tiver referência do dialogueUI, tenta encontrar na cena
        if (dialogueUI == null)
        {
            dialogueUI = FindObjectOfType<DialogueUI>();
        }
    }
    
    void Update()
    {
        if (player == null || dialogueUI == null) return;
        
        // Calcula a distância entre o villager e o player
        float distancia = Vector2.Distance(transform.position, player.position);
        
        // Verifica se o player está dentro da distância de interação
        if (distancia <= distanciaInteracao)
        {
            if (!playerProximo)
            {
                playerProximo = true;
                dialogueUI.ShowDialogue("Olá, aventureiro! Bem-vindo à nossa vila!");
            }
        }
        else
        {
            if (playerProximo)
            {
                playerProximo = false;
                dialogueUI.HideDialogue();
            }
        }
    }
    
    // Visualização da área de interação no editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaInteracao);
    }
}

