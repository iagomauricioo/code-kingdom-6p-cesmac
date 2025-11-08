using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [Header("Componentes UI")]
    public GameObject dialoguePanel; // Painel de diálogo
    public Text dialogueText; // Texto da mensagem
    
    [Header("Configurações")]
    public string mensagemVillager = "Olá, aventureiro! Bem-vindo à nossa vila!";
    
    private void Start()
    {
        // Garante que o painel começa escondido
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
    }
    
    public void ShowDialogue(string mensagem = "")
    {
        if (dialoguePanel == null)
        {
            Debug.LogWarning("DialoguePanel não configurado! Configure no Inspector.");
            return;
        }
        
        // Usa a mensagem passada ou a padrão
        string textoFinal = string.IsNullOrEmpty(mensagem) ? mensagemVillager : mensagem;
        
        // Atualiza o texto
        if (dialogueText != null)
        {
            dialogueText.text = textoFinal;
        }
        
        // Mostra o painel
        dialoguePanel.SetActive(true);
    }
    
    public void HideDialogue()
    {
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
    }
    
    // Método para fechar o diálogo com uma tecla (opcional)
    void Update()
    {
        if (dialoguePanel != null && dialoguePanel.activeSelf)
        {
            // Fecha o diálogo ao pressionar Enter ou Espaço
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                HideDialogue();
            }
        }
    }
}

