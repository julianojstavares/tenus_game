using UnityEngine;

public class StartGame : MonoBehaviour
{
    private Narrador narrador;
    private Txt_Intro intro;
    private Lizaro lizaro;
    private Tenus tenus;
    private bool waitOption = true;

    private void Awake() {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        intro = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Intro>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        tenus = GameObject.FindGameObjectWithTag("Map").GetComponent<Tenus>();
    }
    // Start is called before the first frame update
    void Start()
    {
        narrador.NovaHistoria();
        narrador.Silencio();
        narrador.Diz(intro.txt);
        lizaro.Escolhas(1);
    }

    private void Update() {
        if(waitOption)
        {
            if(lizaro.GetOpcao() == 1)
            {
                tenus.Jogar();
                waitOption = false;
            }
        }
    }
    
}
