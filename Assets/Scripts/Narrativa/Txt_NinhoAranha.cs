using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_NinhoAranha : MonoBehaviour
{
    public string txtAranhaChegando { get; } =
        "Os guardas te levaram at� o ninho da aranha e te jogaram em cima de uma teia grande e grudenta. Rapidamente eles sairam correndo e te deixam para tr�s<br><br>"
        + "Est� muito escuro, nessa �rea da floresta a copa das �rvores n�o deixa nem a luz da lua passar direito<br><br>"
        + "...<br><br>"
        + "Algo est� pingando no seu rosto . . .<br><br>"
        + "A teia come�a a tremer tanto que voc� passa a balan�ar sem parar ... pelas vibra��es e pelo som voc� nota que uma aranha gigante est� vindo te devorar!<br><br>"
        ;

    public string txtFugindo { get; } =
        "Rapidamente voc� aproveita o balan�ar da teia e for�a para que ela balance ainda mais<br>"
        + "Voc� � um elfo treinado na floresta e consegue antecipar os movimentos de ataque da aranha<br>"
        + "Com movimentos precisos voc� rompe a teia ao desviar das investidas do monstro e consegue escapar e sair correndo<br>"
        ;

    public string txtMorte { get; } =
    "Quando voc� ia tentar reagir para tentar fugir, o monstro numa s� investida, te envenena com suas presas. � o fim"
    ;
}
