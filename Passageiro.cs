namespace Uber
{
    public class Passageiro : Usuario
    {
      public string LocalInicio{get; set;}
        public string LocalChegada {get; set;}
        public string statusCorrida {get; set;}             
        public string motorista {get; set;}
        public string passageiro {get; set;}

        public string Motobrabo(){
            if(motorista == "Encontrado"){
                return "Motorista Encontrado     \n\nO Motorista está a caminho";
            } return "Nenhum motorista disponivel nessa área";
        }

        public string Cancelar(){
            return "Corrida Candelada";
        }
        public string ProcurarMotorista(){
            return "Procurando motoristas disponíveis...";
        }

        
    }
}