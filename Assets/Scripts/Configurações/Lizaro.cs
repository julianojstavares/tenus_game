using UnityEngine;

using System;

class Lizaro
{
  private static string localizacao = "flor";
  private static bool temArma = false;
  private static bool temRoupa = false;
  private static bool leitor = false;
  private static int opcao = 0;
  
    private static Narrador dungeonMaster = new Narrador();

  public static void SetLocal(string local)
  {
    localizacao = local;
  }
  
  public static string GetLocal()
  {
    return localizacao;
  }

  public static void SetOpcao(int n)
  {
    opcao = n;
  }
  
  public static int GetOpcao()
  {
    return opcao;
  }

  public static void SetTemArma(bool resposta)
  {
    temArma = resposta;
  }

  public static bool GetTemArma()
  {
    return temArma;
  }

  public static void SetTemRoupa(bool resposta)
  {
    temRoupa = resposta;
  }

  public static bool GetTemRoupa()
  {
    return temRoupa;
  }

  public static void SetLeitor(bool resposta)
  {
    leitor = resposta;
  }

  public static bool GetLeitor()
  {
    return leitor;
  }

  public static void EscolhaTripla()
  {
    string input = "";
    int n = 0;
    bool valorInvalido = false;
    do
    {
      do
      {
        input = Console.ReadLine();
      } while (int.TryParse(input, out n) == false);
      switch (n)
      {
        case 1:
            valorInvalido = false;
            Lizaro.SetOpcao(n);
            dungeonMaster.Diz("<br>");
            break;
        case 2:
            Lizaro.SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        case 3:
            Lizaro.SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        default:
            Lizaro.SetOpcao(n);
            valorInvalido = true;
            break;
      }
    }while(valorInvalido);
  }

  public static void EscolhaDupla()
  {
    string input = "";
    int n = 0;
    bool valorInvalido = false;
    do
    {
      do
      {
        input = Console.ReadLine();
      } while (int.TryParse(input, out n) == false);
      switch (n)
      {
        case 1:
            valorInvalido = false;
            Lizaro.SetOpcao(n);
            dungeonMaster.Diz("<br>");
            break;
        case 2:
            Lizaro.SetOpcao(n);
            valorInvalido = false;
            dungeonMaster.Diz("<br>");
            break;
        default:
            valorInvalido = true;
            break;
      }
    }while(valorInvalido);
  }

  public static int RolarDado(int numeroFaces)
  {
    System.Random rand = new System.Random();
    int sorteado = rand.Next(1, numeroFaces);
    return sorteado;
  }

}
