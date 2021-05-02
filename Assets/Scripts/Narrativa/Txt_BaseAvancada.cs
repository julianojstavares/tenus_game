using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_BaseAvancada : MonoBehaviour
{
    public string intro { get; } =
        "Você observa um comandante elfo negro reunido com seus soldados e um guarda montando em um cavalo levando uma carroça cheia de feno<br><br>"
        + "Você quer lutar ou seguir furtivamente dentro da carroça cheia de feno em movimento?<br>"
        + "1 - Lutar, 2 - Seguir furtivamente<br>"
        ;

    public string matador { get; } = "Você matou guardas inocentes<br>";

    public string perdedor { get; } = "Você morreu";

    public string furtivo { get; } = "Você está indo em direção ao portão da cidade";
}
