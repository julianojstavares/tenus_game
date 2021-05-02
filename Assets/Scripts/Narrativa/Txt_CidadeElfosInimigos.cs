using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_CidadeElfosInimigos : MonoBehaviour
{
    public string intro { get; } =
        "Ao se aproximar da cidade você observa 4 guardas no portão<br>"
        + "1 - Lutar, 2 - Seguir furtivamente<br>"
        ;

    public string furtivo { get; } = "Você conseguiu, passou pelos guardas sem ser notado, e entrou na cidade<br>";

    public string disfarce { get; } = "Foi fácil até. Com essa roupa de guarda que você vestiu no cemitério eles nem suspeitaram de você.<br>";

    public string naoFurtivo { get; } = "Você não conseguiu passar pelos guardas sem ser notado. Eles te viram e você teve que lutar por sua vida<br>";

    public string combateEspada { get; } = "Parece que aquela espada que você pegou no cemitério foi fundamental no combate. Você segue em frente como se nada tivesse acontecido.<br>";

    public string derrotado { get; } =
        "Você foi muito mal no combate.<br><br>"
        + "No céu tem pão.. e morreu<br>"
        ;

    public string ferido { get; } =
        "Você ficou ferido e foi capturado por outros guardas da cidade<br>"
        + "Você está sendo levado para virar comida de aranha dentro de uma gaiola em cima de uma carroça. Você vê que ninguém está olhando para você e o guarda guiando o cavalo tem uma chave no cinto e parece que você consegue alcançá-la com algum esforço<br>"
        + "Quer tentar roubar do guarda e fugir silenciosamente?<br>"
        + "1 - Roubar a chave, 2 - Não fazer nada<br>"
        ;

    public string pegouChave { get; } = "Você pegou a chave sem que ninguém percebesse e fugiu<br>";

    public string semChave { get; } = "Quando você tentou pegar a chave o guarda disse: - Nem tente isso ou vai morrer agora<br>";

    public string vitoria { get; } = "Você derrotou sozinho os 4 guardas do portão<br>";
}
