using UnityEngine;

public class Tenus : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Tenus txt;
    private bool waitOption = true;

    private void Awake() {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Tenus>();
    }
  public void Jogar()
  {
    narrador.Silencio();
    narrador.Diz(txt.part_1);
    narrador.Diz(txt.part_2);
    narrador.Diz(txt.part_3);
    narrador.Silencio();
    lizaro.Escolhas(3);

  }

  private void Update() {
    if(waitOption)
    {
      switch (lizaro.GetOpcao())
      {
        case 1:
            waitOption = false;
            //Cemiterio.Ir();
            break;
        case 2:
            waitOption = false;
            //BaseAvancada.Ir();
            break;
        case 3:
            waitOption = false;
            //CidadeElfosInimigos.Ir();
            break;
        default:
            break;
      }
    }
  }

}
