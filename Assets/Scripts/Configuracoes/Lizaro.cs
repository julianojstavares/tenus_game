using UnityEngine;

class Lizaro : MonoBehaviour
{
  private string localizacao = "flor";
  private bool temArma = false;
  private bool temRoupa = false;
  private bool leitor = false;
  private int opcao = 0;
  public TMPro.TMP_InputField text;
    public Narrador dungeonMaster;

  public  void SetLocal(string local)
  {
    localizacao = local;
  }
  
  public  string GetLocal()
  {
    return localizacao;
  }

  public  void SetOpcao(int n)
  {
    opcao = n;
  }
  
  public  int GetOpcao()
  {
    return opcao;
  }

  public  void SetTemArma(bool resposta)
  {
    temArma = resposta;
  }

  public  bool GetTemArma()
  {
    return temArma;
  }

  public  void SetTemRoupa(bool resposta)
  {
    temRoupa = resposta;
  }

  public  bool GetTemRoupa()
  {
    return temRoupa;
  }

  public  void SetLeitor(bool resposta)
  {
    leitor = resposta;
  }

  public  bool GetLeitor()
  {
    return leitor;
  }

  public  void EscolhaTripla()
  {
    string input = "";
    int n = 0;
    bool valorInvalido = false;
    do
    {
      do
      {
        input = Diz();
        Espera();
      } while (int.TryParse(input, out n) == false);
      switch (n)
      {
        case 1:
            valorInvalido = false;
            SetOpcao(n);
            dungeonMaster.Diz("<br>");
            break;
        case 2:
            SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        case 3:
            SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        default:
            SetOpcao(n);
            valorInvalido = true;
            break;
      }
    }while(valorInvalido);
  }

  public  void EscolhaDupla()
  {
    string input = "";
    int n = 0;
    bool valorInvalido = false;
    do
    {
      do
      {
        input = Diz();
        Espera();
      } while (int.TryParse(input, out n) == false);
      switch (n)
      {
        case 1:
            valorInvalido = false;
            SetOpcao(n);
            dungeonMaster.Diz("<br>");
            break;
        case 2:
            SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        default:
            valorInvalido = true;
            break;
      }
    }while(valorInvalido);
  }

  public  int RolarDado(int numeroFaces)
  {
    System.Random rand = new System.Random();
    int sorteado = rand.Next(1, numeroFaces);
    return sorteado;
  }
    public  void Espera()
    {
        text.readOnly = true;
    }
  public  string Diz()
  {
      text.readOnly = false;
      text.Select();
      return text.ToString();
  }

}
