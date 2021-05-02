using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_CasaAbandonada : MonoBehaviour
{
    public string intro { get; } =
        "Você segue por um caminho na floresta e encontra uma casa abandonada e entra nela para se esconder<br>"
        + "É uma casa completamente vazia e velha. A única coisa que você vê é um livro brilhando no chão<br><br>"
        + "Quer ler o livro? 1 - sim, 2 - não<br>"
        ;

    public string ler { get; } =
        "No livro está escrito: - “Quem comer da flor de Tênus ao amanhecer, viverá eternamente, e terá a força dos deuses”<br>"
        + "Não há mais nada para fazer nessa casa velha e vazia<br><br>"
        ;

    public string sair { get; } = "Pela janela da casa você vê a estrada que leva para fora da floresta. Parece seguro sair agora<br>";
}
