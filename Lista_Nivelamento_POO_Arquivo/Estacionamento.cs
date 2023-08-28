using System;

namespace Lista_Nivelamento_POO_Arquivo
{
       public class Estacionamento
       {
              private String nome;
              private int numTotalVagas;
              private int numVagasLivres;
              private String[] vaga;

              public Estacionamento(String nome, int numTotalVagas)
              {
                     this.nome = nome;
                     this.numTotalVagas = numTotalVagas;
                     this.numVagasLivres = numTotalVagas;
                     this.vaga = new String[numTotalVagas];

                     for (int i = 0; i < numTotalVagas; i++)
                     {
                            this.vaga[i] = null;
                     }
              }

              public int Estacionar(String placa)
              {
                     if (numTotalVagas > 0)
                     {
                            for (int i = 0; i < numTotalVagas; i++)
                            {
                                   if (vaga[i] == null)
                                   {
                                          vaga[i] = placa;
                                          numVagasLivres--;
                                          return i;
                                   }
                            }
                     }
                     return -1;
              }

              public int ObterVagaOcupada(String placa)
              {
                     for (int i = 0; i < numTotalVagas; i++)
                     {
                            if (vaga[i] == placa)
                            {
                                   return i;
                            }
                     }
                     return -1;
              }

              public void RetirarVeiculo(String placa)
              {
                     for (int i = 0; i < numTotalVagas; i++)
                     {
                            if (vaga[i] == placa)
                            {
                                   vaga[i] = null;
                                   numVagasLivres++;
                            }
                     }
              }

              public int ObterNumVagasLivres()
              {
                     return numVagasLivres;
              }

              public void ExibirOcupacaoEstacionamento()
              {
                     for (int i = 0; i < numTotalVagas; i++)
                     {
                            Console.WriteLine("Vaga " + i + ": " + vaga[i]);
                     }
              }
       }
}