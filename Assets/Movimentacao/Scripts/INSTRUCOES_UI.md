# Instruções para Configurar a UI de Diálogo

## Passo 1: Criar o Canvas e UI

1. **Criar Canvas:**
   - Clique com botão direito na Hierarchy
   - UI > Canvas
   - Isso criará automaticamente um Canvas e um EventSystem

2. **Criar Painel de Diálogo:**
   - Clique com botão direito no Canvas
   - UI > Panel
   - Renomeie para "DialoguePanel"
   - Ajuste o tamanho e posição (recomendado: centro inferior da tela)
   - No Inspector, ajuste a cor de fundo (Image component) para um tom escuro semi-transparente

3. **Criar Texto:**
   - Clique com botão direito no DialoguePanel
   - UI > Text - TextMeshPro (ou UI > Text se não tiver TextMeshPro)
   - Renomeie para "DialogueText"
   - Ajuste o texto para "Olá, aventureiro! Bem-vindo à nossa vila!"
   - Configure fonte, tamanho e cor conforme desejar
   - Ajuste o RectTransform para ocupar a maior parte do painel

## Passo 2: Configurar o Script DialogueUI

1. **Adicionar o Script:**
   - Crie um GameObject vazio (GameObject > Create Empty)
   - Renomeie para "DialogueManager"
   - Adicione o componente DialogueUI (Add Component > DialogueUI)

2. **Configurar as Referências:**
   - No Inspector do DialogueManager:
     - Dialogue Panel: Arraste o DialoguePanel criado
     - Dialogue Text: Arraste o DialogueText criado
     - Mensagem Villager: Edite a mensagem se desejar

## Passo 3: Configurar o Villager

1. **Adicionar o Script ao Villager:**
   - Selecione o GameObject "Villager" na Hierarchy
   - Adicione o componente VillagerInteraction (Add Component > VillagerInteraction)

2. **Configurar as Referências:**
   - No Inspector do Villager:
     - Distancia Interacao: Ajuste para a distância desejada (padrão: 2)
     - Dialogue UI: Arraste o DialogueManager criado

3. **Adicionar Tag ao Player (Opcional mas Recomendado):**
   - Selecione o GameObject "Player"
   - No Inspector, na parte superior, clique em "Tag"
   - Se não existir, crie uma nova tag chamada "Player"
   - Aplique a tag "Player" ao GameObject do Player

## Passo 4: Testar

1. Execute o jogo (Play)
2. Mova o player próximo ao Villager
3. A mensagem deve aparecer automaticamente
4. Quando o player se afastar, a mensagem desaparece
5. Você também pode fechar a mensagem pressionando Enter ou Espaço

## Dicas

- A distância de interação pode ser visualizada no Scene View quando o Villager está selecionado (círculo amarelo)
- Você pode personalizar a mensagem diretamente no Inspector do DialogueManager
- O painel de diálogo pode ser estilizado com imagens de fundo, bordas, etc.

