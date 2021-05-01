using UnityEngine;

public class Tenus : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Tenus tenus;
    private bool waitOption = true;

    private void Awake() {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        tenus = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Tenus>();
    }
  public void Jogar()
  {
    narrador.Silencio();
    narrador.Diz(tenus.txt);
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
