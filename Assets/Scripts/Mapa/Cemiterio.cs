using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cemiterio : MonoBehaviour
{
  private void Ir()
  {
    Narrador.Diz("Ao se aproximar do cemitério, você percebe que vários corpos foram enterrados recentemente");
    Narrador.Diz("No cemitério você acha tem um túmulo aberto e nele você encontra uma arma e uma roupa de guarda. Você pega: 1 – a arma, 2 – a roupa 3 – A arma e a roupa");
    Lizaro.EscolhaTripla();
    switch (Lizaro.GetOpcao())
      {
        case 1:
            Lizaro.SetTemArma(true);
            Continuar();
            break;
        case 2:
            Lizaro.SetTemRoupa(true);
            Continuar();
            break;
        case 3:
            Lizaro.SetTemArma(true);
            Lizaro.SetTemRoupa(true);
            Continuar();
            break;
        default:
            break;
      }
  }

  private void Continuar()
  {
    Narrador.Diz("Não há nada mais para fazer aqui. Há um caminho para o portão da cidade dos elfos inimigos. Como é o único caminho a seguir você anda por ele.");
    CidadeElfosInimigos.Ir();
  }
}
