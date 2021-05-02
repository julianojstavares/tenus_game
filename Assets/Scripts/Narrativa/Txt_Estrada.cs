using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Estrada : MonoBehaviour
{
    public string intro { get; } =
        "Voc� segue pela estrada e vai saindo da floresta<br>"
        + "Est� quase amanhecendo. � poss�vel ver os primeiros raios de sol no horizonte<br>"
        ;

    public string pergunta { get; } =
        "Vai comer a flor como dizia o livro?<br>"
        + "1 - sim, 2 - n�o<br>"
        ;

    public string comer { get; } = "Voc� se sente mal, o gosto da flor � terr�vel, os raios de sol te queimam e voc� come�a a definhar e morre lentamente<br>";

    public string fim { get; } = "Voc� chega em sua vila, mostra a flor e � recebido pelos seus e o seu anci�o. Parab�ns leal soldado! Voc� foi muito nobre e corajoso!<br>";
}
