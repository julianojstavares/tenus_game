using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Gruta : MonoBehaviour
{
    public string entrarGruta { get; } =
        "Ao entrar na gruta você percebe que há uma fenda no teto por onde a água e a luz da lua entram e incidem sobre uma pilha enorme de ouro<br>"
        + "Existem alguns coelhos, cervos, e outros pequenos animais mortos no meio do ouro<br><br>"
        + "Quer levar o ouro com você?<br>"
        + "1-sim, 2-não<br>"
        ;

    public string comOuro { get; } = "A ganância te entorpeceu e você ficou louco com tanto ouro. Fim de jogo<br>";

    public string semOuro { get; } = "Você não é ganancioso. Você sai da gruta e volta para a estrada.<br><br>";
}
