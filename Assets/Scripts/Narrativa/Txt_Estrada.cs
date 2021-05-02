using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Estrada : MonoBehaviour
{
    public string intro { get; } = "Voc� segue pela estrada rumo a sa�da da floresta<br>";

    public string gruta { get; } =
        "No meio da estrada voc� percebe que h� uma gruta que pode ser acessada por uma trilha que se conecta na lateral da estrada. � poss�vel escutar �gua correndo, como se uma pequena queda d'�gua estivesse caindo sobre uma pilha de metais. H� um brilho dourado saindo de l� de dentro.<br><br>"
        + "Deseja ir at� a gruta?<br>"
        + "1-sim, 2-n�o<br>"
        ;

    public string pergunta { get; } =
        "Est� quase amanhecendo. � poss�vel ver os primeiros raios de sol no horizonte<br><br>"
        + "Vai comer a flor como dizia o livro?<br>"
        + "1 - sim, 2 - n�o<br>"
        ;

    public string comer { get; } = "Voc� se sente mal, o gosto da flor � terr�vel, os raios de sol te queimam e voc� come�a a definhar e morre lentamente<br><br>� o seu fim.";

}
