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

    public string sairCasa { get; } =
        "Pela janela da casa você vê a estrada que leva para fora da floresta. Parece seguro sair agora<br>"
        + "No meio da estrada você percebe que há uma gruta, e escuta água correndo, como se uma pequena queda d'água estivesse caindo sobre uma pilha de metais. Há um brilho dourado saindo de lá de dentro.<br>"
        + "Deseja ir até a gruta?<br>"
        + "1-sim, 2-não<br>"
        ;

    public string entrarGruta { get; } =
        "Ao entrar na gruta você percebe que há uma fenda no teto por onde a água e a luz da lua entram e incidem sobre uma pilha enorme de ouro<br>"
        + "Existem alguns coelhos, cervos, e outros pequenos animais mortos no meio do ouro<br>"
        + "Quer levar o ouro com você?<br>"
        + "1-sim, 2-não<br>"
        ;

    public string comOuro { get; } = "A ganância te entorpeceu e você ficou louco com tanto ouro. Fim de jogo<br>";
    
    public string semOuro { get; } = "Você não é ganancioso. Você sai da gruta.<br>";
}
