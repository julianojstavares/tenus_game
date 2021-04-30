using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    private Narrador dungeonMaster;
    private Lizaro lizaro;

    private void Awake() {
        dungeonMaster = GetComponent<Narrador>();
        lizaro = GetComponent<Lizaro>();
    }
public void Show ()
  {
      dungeonMaster.Diz(" "); 
      dungeonMaster.Diz("Tenus");    
      dungeonMaster.Diz("Um jogo baseado em texto feito por:");
      dungeonMaster.Diz("Carla, Raphael, Bruno e Juliano");
      dungeonMaster.Diz("Escreva 'jogar' e pressione 'enter' quando estiver pronto");
      while(lizaro.Diz() != "jogar"){}
      dungeonMaster.Diz(" ");
  }
}
