using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_BaseAvancada : MonoBehaviour
{
    public string intro { get; } =
        "Voc� observa um comandante elfo negro reunido com seus soldados e um guarda montando em um cavalo levando uma carro�a cheia de feno<br><br>"
        + "Voc� quer lutar ou seguir furtivamente dentro da carro�a cheia de feno em movimento?<br>"
        + "1 - Lutar, 2 - Seguir furtivamente<br>"
        ;

    public string matador { get; } = "Voc� matou guardas inocentes<br>";

    public string perdedor { get; } = "Voc� morreu";

    public string furtivo { get; } = "Voc� est� indo em dire��o ao port�o da cidade";
}
