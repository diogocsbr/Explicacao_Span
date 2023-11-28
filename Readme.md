## Limitações do `Span<T>`

- **Escopo Localizado:** `Span<T>` não pode ser usado como campo de uma classe ou estrutura. Ele é limitado ao escopo local (por exemplo, dentro de um método).
- **Incompatibilidade com Async:** Não pode ser usado com métodos assíncronos (`async`/`await`).
- **Não Serializável:** `Span<T>` não pode ser serializado.

## Quando Usar `Span<T>`

- Em operações de baixo nível em buffers, arrays ou strings.
- Em cenários de processamento de dados em que a performance é crítica.
- Quando você precisa de um acesso eficiente a subseções de dados sem criar cópias adicionais.

## Conclusão

`Span<T>` é uma poderosa estrutura do .NET que oferece uma maneira eficiente e segura de trabalhar com dados contíguos, como arrays e strings. É particularmente útil em cenários onde a performance e o controle sobre a alocação de memória são importantes.
