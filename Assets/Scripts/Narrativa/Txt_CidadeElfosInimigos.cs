using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_CidadeElfosInimigos : MonoBehaviour
{
    public string intro { get; } =
        "Ao se aproximar da cidade voc� observa 4 guardas no port�o<br>"
        + "1 - Lutar, 2 - Seguir furtivamente<br>"
        ;

    public string furtivo { get; } = "Voc� conseguiu, passou pelos guardas sem ser notado, e entrou na cidade<br>";

    public string disfarce { get; } = "Foi f�cil at�. Com essa roupa de guarda que voc� vestiu no cemit�rio eles nem suspeitaram de voc�.<br>";

    public string naoFurtivo { get; } = "Voc� n�o conseguiu passar pelos guardas sem ser notado. Eles te viram e voc� teve que lutar por sua vida<br>";

    public string combateEspada { get; } = "Parece que aquela espada que voc� pegou no cemit�rio foi fundamental no combate. Voc� segue em frente como se nada tivesse acontecido.<br>";

    public string derrotado { get; } =
        "Voc� foi muito mal no combate.<br><br>"
        + "No c�u tem p�o.. e morreu<br>"
        ;

    public string ferido { get; } =
        "Voc� ficou ferido e foi capturado por outros guardas da cidade<br>"
        + "Voc� est� sendo levado para virar comida de aranha dentro de uma gaiola em cima de uma carro�a. Voc� v� que ningu�m est� olhando para voc� e o guarda guiando o cavalo tem uma chave no cinto e parece que voc� consegue alcan��-la com algum esfor�o<br>"
        + "Quer tentar roubar do guarda e fugir silenciosamente?<br>"
        + "1 - Roubar a chave, 2 - N�o fazer nada<br>"
        ;

    public string pegouChave { get; } = "Voc� pegou a chave sem que ningu�m percebesse e fugiu<br>";

    public string semChave { get; } = "Quando voc� tentou pegar a chave o guarda disse: - Nem tente isso ou vai morrer agora<br>";

    public string vitoria { get; } = "Voc� derrotou sozinho os 4 guardas do port�o<br>";
}
