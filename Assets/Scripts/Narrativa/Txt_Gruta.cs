using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Gruta : MonoBehaviour
{
    public string entrarGruta { get; } =
        "Ao entrar na gruta voc� percebe que h� uma fenda no teto por onde a �gua e a luz da lua entram e incidem sobre uma pilha enorme de ouro<br>"
        + "Existem alguns coelhos, cervos, e outros pequenos animais mortos no meio do ouro<br><br>"
        + "Quer levar o ouro com voc�?<br>"
        + "1-sim, 2-n�o<br>"
        ;

    public string comOuro { get; } = "A gan�ncia te entorpeceu e voc� ficou louco com tanto ouro. Fim de jogo<br>";

    public string semOuro { get; } = "Voc� n�o � ganancioso. Voc� sai da gruta e volta para a estrada.<br><br>";
}
