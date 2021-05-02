using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Estrada : MonoBehaviour
{
    public string intro { get; } = "Você segue pela estrada rumo a saída da floresta<br>";

    public string gruta { get; } =
        "No meio da estrada você percebe que há uma gruta que pode ser acessada por uma trilha que se conecta na lateral da estrada. É possível escutar água correndo, como se uma pequena queda d'água estivesse caindo sobre uma pilha de metais. Há um brilho dourado saindo de lá de dentro.<br><br>"
        + "Deseja ir até a gruta?<br>"
        + "1-sim, 2-não<br>"
        ;

    public string pergunta { get; } =
        "Está quase amanhecendo. É possível ver os primeiros raios de sol no horizonte<br><br>"
        + "Vai comer a flor como dizia o livro?<br>"
        + "1 - sim, 2 - não<br>"
        ;

    public string comer { get; } = "Você se sente mal, o gosto da flor é terrível, os raios de sol te queimam e você começa a definhar e morre lentamente<br><br>É o seu fim.";

}
