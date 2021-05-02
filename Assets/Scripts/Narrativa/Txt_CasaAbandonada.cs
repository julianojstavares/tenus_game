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

    public string sairCasa { get; } =
        "Pela janela da casa voc� v� a estrada que leva para fora da floresta. Parece seguro sair agora<br>"
        + "No meio da estrada voc� percebe que h� uma gruta, e escuta �gua correndo, como se uma pequena queda d'�gua estivesse caindo sobre uma pilha de metais. H� um brilho dourado saindo de l� de dentro.<br>"
        + "Deseja ir at� a gruta?<br>"
        + "1-sim, 2-n�o<br>"
        ;

    public string entrarGruta { get; } =
        "Ao entrar na gruta voc� percebe que h� uma fenda no teto por onde a �gua e a luz da lua entram e incidem sobre uma pilha enorme de ouro<br>"
        + "Existem alguns coelhos, cervos, e outros pequenos animais mortos no meio do ouro<br>"
        + "Quer levar o ouro com voc�?<br>"
        + "1-sim, 2-n�o<br>"
        ;

    public string comOuro { get; } = "A gan�ncia te entorpeceu e voc� ficou louco com tanto ouro. Fim de jogo<br>";
    
    public string semOuro { get; } = "Voc� n�o � ganancioso. Voc� sai da gruta.<br>";
}
