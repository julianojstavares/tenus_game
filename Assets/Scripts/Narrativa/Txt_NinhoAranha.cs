using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_NinhoAranha : MonoBehaviour
{
    public string txtAranhaChegando { get; } =
        "Os guardas te levaram até o ninho da aranha e te jogaram em cima de uma teia grande e grudenta. Rapidamente eles sairam correndo e te deixam para trás<br><br>"
        + "Está muito escuro, nessa área da floresta a copa das árvores não deixa nem a luz da lua passar direito<br><br>"
        + "...<br><br>"
        + "Algo está pingando no seu rosto . . .<br><br>"
        + "A teia começa a tremer tanto que você passa a balançar sem parar ... pelas vibrações e pelo som você nota que uma aranha gigante está vindo te devorar!<br><br>"
        ;

    public string txtFugindo { get; } =
        "Rapidamente você aproveita o balançar da teia e força para que ela balance ainda mais<br>"
        + "Você é um elfo treinado na floresta e consegue antecipar os movimentos de ataque da aranha<br>"
        + "Com movimentos precisos você rompe a teia ao desviar das investidas do monstro e consegue escapar e sair correndo<br>"
        ;

    public string txtMorte { get; } =
    "Quando você ia tentar reagir para tentar fugir, o monstro numa só investida, te envenena com suas presas. É o fim"
    ;
}
