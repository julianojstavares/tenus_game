using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_CasaAbandonada : MonoBehaviour
{
    public string intro { get; } =
        "Voc� segue por um caminho na floresta e encontra uma casa abandonada e entra nela para se esconder<br>"
        + "� uma casa completamente vazia e velha. A �nica coisa que voc� v� � um livro brilhando no ch�o<br><br>"
        + "Quer ler o livro? 1 - sim, 2 - n�o<br>"
        ;

    public string ler { get; } =
        "No livro est� escrito: - �Quem comer da flor de T�nus ao amanhecer, viver� eternamente, e ter� a for�a dos deuses�<br>"
        + "N�o h� mais nada para fazer nessa casa velha e vazia<br><br>"
        ;

    public string sair { get; } = "Pela janela da casa voc� v� a estrada que leva para fora da floresta. Parece seguro sair agora<br>";
}
