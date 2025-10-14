# Projeto Code Kingdom Unity 2D

Este é um projeto Unity 2D focado em ensinar programação.

## 📋 Funcionalidades Implementadas

### 🎮 Sistema de Movimentação
- **Movimento horizontal**: Controle com setas ou WASD
- **Pulo**: Espaço para pular (apenas quando no chão)
- **Detecção de chão**: Sistema de verificação usando OverlapCircle
- **Inversão de sprite**: Personagem vira automaticamente na direção do movimento

### 🎨 Sistema de Animações
- **Animação de Idle**: Animação quando o personagem está parado
- **Animação de Walking**: Animação quando o personagem está andando
- **Controle de animações**: Sistema automático baseado no input do jogador

## 🛠️ Componentes Técnicos

### PlayerController.cs
Script principal que controla a movimentação do personagem:

```csharp
// Configurações principais
public float velocidadeMovimento = 5f;  // Velocidade de movimento
public float forcaPulo = 10f;           // Força do pulo
public Transform verificadorChao;       // Ponto de verificação do chão
public float raioVerificacao = 0.2f;    // Raio da verificação
public LayerMask camadaChao;            // Camada do chão
```

**Funcionalidades:**
- Movimento horizontal com `Input.GetAxisRaw("Horizontal")`
- Pulo com verificação de chão usando `Physics2D.OverlapCircle`
- Inversão de escala para mudar direção do sprite
- Controle de animações através do Animator
- Visualização de debug com Gizmos

## 📁 Estrutura do Projeto

```
Assets/
├── Animacao/
│   ├── Player/
│   │   ├── Idle.anim          # Animação de idle
│   │   ├── Walking.anim       # Animação de caminhada
│   │   └── Player.controller  # Controller de animações
│   └── sprites/
│       ├── idle.png           # Sprite de idle
│       ├── walking.png        # Sprite de caminhada
│       ├── player.png         # Sprite principal
│       ├── attack.png         # Sprite de ataque
│       ├── death.png          # Sprite de morte
│       └── hit.png            # Sprite de dano
├── Movimentacao/
│   └── Scripts/
│       └── PlayerController.cs # Script principal
└── Scenes/
    └── Teste.unity            # Cena de teste
```

## 🎯 Como Usar

1. **Configuração do Personagem:**
   - Adicione o script `PlayerController` ao GameObject do personagem
   - Configure o `verificadorChao` como um Transform vazio na base do personagem
   - Defina a `camadaChao` para a layer do chão
   - Ajuste `velocidadeMovimento` e `forcaPulo` conforme necessário

2. **Configuração das Animações:**
   - Adicione o Animator ao personagem
   - Configure as animações Idle e Walking no Animator Controller
   - Certifique-se de que o parâmetro "walking" está configurado corretamente

3. **Controles:**
   - **Movimento**: Setas ou WASD
   - **Pulo**: Espaço (apenas quando no chão)

## 🔧 Tecnologias Utilizadas

- **Unity 2023.x** com Universal Render Pipeline
- **Unity Input System** para controle de entrada
- **Unity 2D Physics** para detecção de chão
- **Unity Animator** para sistema de animações
- **C#** para scripts

## 📦 Dependências

O projeto utiliza os seguintes pacotes Unity:
- `com.unity.inputsystem` - Sistema de entrada
- `com.unity.feature.2d` - Recursos 2D
- `com.unity.render-pipelines.universal` - Pipeline de renderização universal

## 🚀 Próximos Passos

- [ ] Implementar sistema de ataque
- [ ] Adicionar mais animações (ataque, morte, dano)
- [ ] Implementar sistema de vida
- [ ] Adicionar inimigos
- [ ] Criar sistema de coleta de itens
- [ ] Implementar sistema de sons

## 📝 Notas de Desenvolvimento

- O sistema de detecção de chão usa `Physics2D.OverlapCircle` para maior precisão
- As animações são controladas automaticamente baseadas no input
- O projeto está configurado para desenvolvimento 2D com física apropriada
- O sistema de debug visual ajuda na configuração do verificador de chão

---

**Desenvolvido com Unity 2023.x**
