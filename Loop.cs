using System;

class Loop{

  public void Infinito(){
    
    bool continuar = true;
    int op = 0;

    
    while(continuar){
      
      
      Livros livrosInstancia = new Livros();

      livrosInstancia.Opcao();


      Console.WriteLine ("\n\nDeseja adquirir mais algum livro? Digite '1' para sim, '0' para não.");

      op = int.Parse(Console.ReadLine());
      if(op == 0)
      {
        continuar = false;
      }
      
    }

  } 


  public void Infinito2(){

    bool continuar = true;
    int op = 0;
    
    while(continuar){
      
      Cursos cursosInstancia = new Cursos();
      
      cursosInstancia.Opcao();

      Console.WriteLine ("\n\nDeseja adquirir mais algum curso? Digite '1' para 'SIM', '0' para 'NÃO'.");

      op = int.Parse(Console.ReadLine());
      if(op == 0)
      {
        continuar = false;
      }
      
    }
  }
}