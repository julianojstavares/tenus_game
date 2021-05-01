using UnityEngine;

class Lizaro : MonoBehaviour
{
  private string localizacao = "flor";
  private bool temArma = false;
  private bool temRoupa = false;
  private bool leitor = false;
  public int opcao = 0;
  public bool getEscolhaUnica = false;
  public bool getEscolhaDupla = false;
  public bool getEscolhaTripla = false;
  private TMPro.TMP_InputField input;

  private void Awake() {
    input = GameObject.FindGameObjectWithTag("Input").GetComponent<TMPro.TMP_InputField>();
  }
  private void Update() {
    WaitInput();
  }
  public void SetLocal(string local)
  {
    localizacao = local;
  }
  
  public string GetLocal()
  {
    return localizacao;
  }

  public void SetOpcao()
  {
    opcao = int.Parse(input.text);
    Debug.Log(input.text);
    FinishInput();
  }
  
  public int GetOpcao()
  {
    return opcao;
  }

  public void SetTemArma(bool resposta)
  {
    temArma = resposta;
  }

  public bool GetTemArma()
  {
    return temArma;
  }

  public void SetTemRoupa(bool resposta)
  {
    temRoupa = resposta;
  }

  public bool GetTemRoupa()
  {
    return temRoupa;
  }

  public void SetLeitor(bool resposta)
  {
    leitor = resposta;
  }

  public bool GetLeitor()
  {
    return leitor;
  }

  public int RolarDado(int numeroFaces)
  {
    System.Random rand = new System.Random();
    int sorteado = rand.Next(1, numeroFaces);
    return sorteado;
  }

  public void FinishInput()
  {
      input.readOnly = true;
      input.interactable = false;
  }
  public void Diz()
  {
      ReadyInput();
  }

  private void ReadyInput()
  {
    input.text = "";
    input.readOnly = false;
    input.interactable = true;
    input.ActivateInputField();
    Debug.Log("ReadyInput");
  }

  public void Escolhas(int opcoes)
  {
    switch (opcoes)
    {
      case 1:
        getEscolhaUnica = true;
        break;
      case 2:
        getEscolhaDupla = true;
        break;
      case 3:
        getEscolhaTripla = true;
        break;
      default:
        Debug.Log("Escolhas(int <= 3)");
        break;
    }
  }

  public void WaitInput()
  {
    if(Input.GetKeyDown(KeyCode.Return) && input.readOnly == false)
    {
      if(input.text != ""){SetOpcao();}
      EscolhaUnica();
      EscolhaDupla();
    }
  }
  private void EscolhaUnica()
  {
    if(getEscolhaUnica)
      if(GetOpcao() != 1)
        ReadyInput();
      else
        getEscolhaUnica = false;
  }

  private void EscolhaDupla()
  {
    if(getEscolhaDupla)
      switch (GetOpcao())
      {
        case 1:
          getEscolhaDupla = false;
          break;
        case 2:
          getEscolhaDupla = false;
          break;    
        default:
          ReadyInput();
          break;
      }
  }

}
