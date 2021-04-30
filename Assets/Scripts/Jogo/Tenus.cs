using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tenus : MonoBehaviour
{
    private Intro intro;
    private Narrador narrador;
    private Lizaro lizaro;

    private void Awake() {
        intro = GetComponent<Intro>();
    }
  public void Jogar()
  {
    intro.Show(); 
    // narrador.Diz(GetTextIntro.Parte_1());
    // narrador.Diz(GetTextIntro.Parte_2());
    // narrador.Diz(GetTextIntro.Parte_3());
    // narrador.Diz("Para onde você vai? Digite 1, 2, ou 3 para escolher");
    // lizaro.EscolhaTripla();
    // switch (Lizaro.GetOpcao())
    // {
    //   case 1:
    //       Cemiterio.Ir();
    //       break;
    //   case 2:
    //       BaseAvancada.Ir();
    //       break;
    //   case 3:
    //        CidadeElfosInimigos.Ir();
    //       break;
    //   default:
    //       break;
    // }
  }
}
