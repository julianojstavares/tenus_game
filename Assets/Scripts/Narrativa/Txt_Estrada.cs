using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_Estrada : MonoBehaviour
{
    public string intro { get; } =
        "Você segue pela estrada e vai saindo da floresta<br>"
        + "Está quase amanhecendo. É possível ver os primeiros raios de sol no horizonte<br>"
        ;

    public string pergunta { get; } =
        "Vai comer a flor como dizia o livro?<br>"
        + "1 - sim, 2 - não<br>"
        ;

    public string comer { get; } = "Você se sente mal, o gosto da flor é terrível, os raios de sol te queimam e você começa a definhar e morre lentamente<br>";

    public string fim { get; } = "Você chega em sua vila, mostra a flor e é recebido pelos seus e o seu ancião. Parabéns leal soldado! Você foi muito nobre e corajoso!<br>";
}
