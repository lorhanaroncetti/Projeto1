using System;

class Livros{

  public void Opcao(){

    string livro;

    Console.WriteLine("\n\n\nQual o número referente ao livro que deseja?");
    livro = ( Console.ReadLine() );


    switch ( livro ) {

      case "1":
      Console.WriteLine("\nSegue o link do livro 'Diálogos sobre a religião natural': \nhttps://www.amazon.com.br/dp/B07YQ82GJC/ref=s9_acsd_hps_bw_c2_x_1_t?pf_rd_m=A3RN7G7QC5MWSZ&pf_rd_s=merchandised-search-3&pf_rd_r=1FKC48K28RPBSHW6PTTH&pf_rd_t=101&pf_rd_p=19bd41aa-c77c-418a-b5a4-3f9dae465d00&pf_rd_i=6311441011");
      break;

      case "2":
      Console.WriteLine("\nSegue o link do livro 'O Cortiço': \nhttps://www.amazon.com.br/dp/B07LFL9NHV/ref=s9_acsd_hps_bw_c2_x_7_t?pf_rd_m=A3RN7G7QC5MWSZ&pf_rd_s=merchandised-search-3&pf_rd_r=S1ZK4GESHP2SMMW2V3K5&pf_rd_t=101&pf_rd_p=19bd41aa-c77c-418a-b5a4-3f9dae465d00&pf_rd_i=6311441011");
      break;

      case "3":
      Console.WriteLine("\nSegue o link do livro 'Sejamos todos feministas': \nhttps://www.amazon.com.br/dp/B00NXYVW4S/ref=s9_acsd_hps_bw_c2_x_4_t?pf_rd_m=A3RN7G7QC5MWSZ&pf_rd_s=merchandised-search-3&pf_rd_r=S1ZK4GESHP2SMMW2V3K5&pf_rd_t=101&pf_rd_p=19bd41aa-c77c-418a-b5a4-3f9dae465d00&pf_rd_i=6311441011");
      break;

      default:
      Console.WriteLine("Opção inexistente.");
      break;
      
    }
  }
}