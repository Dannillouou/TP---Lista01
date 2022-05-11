# TP-Lista01
Estudo de caso de músicas utilizando a linguagem C#

## Estrutura de dados

### Produtor e Artista
A estrutura de dados possui as classes Produtor(que possui produtora e gêneros) e Artista(que possui data do contrato e gêneros), ambos derivados da classe abstrata Pessoa, que tem nome, cpf e datas de nascimento e falecimento

### Album
Produtores e artistas possuem uma lista de álbuns, que por sua vez têm as propriedades de nome, gênero, capa, data de lançamento e uma lista músicas.

### Musica
A classe música possui os atributos de nome, gênero, duração e data de lancamento.

## Buscas
É possível fazer pela estrutura 7 tipos de busca, que são apresentadas no menu:

<ul>
    <li>1. Todos os álbuns de determinado artista</li>
    <li>2. Todos os álbuns de determinado ano</li>
    <li>3. Todas as músicas de um determinado artista</li>
    <li>4. Todas as músicas de um artista lançadas em um determinado ano</li>
    <li>5. Todos os albuns de um mesmo genero de um produtor</li>
    <li>6. Todos os álbuns do mesmo ano de um produtor</li>
    <li>7. A lista ordenada decrescente de lançamento dos álbuns de um artista</li>
</ul>

Todas foram implementadas utilizando a tecnologia de LINQ (Language Integrated Query) do C#