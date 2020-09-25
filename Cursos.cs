using System;

class Cursos{

  public void Opcao() {

    string curso;

    Console.WriteLine("\n\n\nQual o número referente ao curso que deseja fazer?");
    curso = ( Console.ReadLine() );


    switch ( curso ) {

      case "1":
      Console.WriteLine("\nSegue o link do curso 'Gestão de Comprars': \nhttps://www.ewcursos.com/curso/gestao-de-compras");
      break;

      case "2":
      Console.WriteLine("\nSegue o link do curso 'Libras': \nhttps://www.ewcursos.com/curso/libras"           );
      break;

      case "3":
      Console.WriteLine("\nSegue o link do curso 'Microsoft Word': \nhttps://www.ewcursos.com/curso/microsoft-word"   );
      break;

      default:
      Console.WriteLine("Opção inexistente.");
      break;
      
    }
  }
}