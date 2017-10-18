using System;

namespace s3d2t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CPF");
            string cpf = Console.ReadLine();

            if(cpf.Length != 11){
                Console.WriteLine("CPF Inválido");
            }
            else{
                int[] multiplicador1 = new int[]{10,9,8,7,6,5,4,3,2};
                int[] multiplicador2 = new int[]{11,10,9,8,7,6,5,4,3,2};
                string cpf9, cpf10, cpf11, digito1, digito2;
                int soma1=0, resto1=0, soma2=0, resto2=0;
                cpf9 = cpf.Substring(0,9);

                for(int i = 0; i < 9; i++){
                    soma1 += Convert.ToInt16(cpf9[i].ToString()) * multiplicador1[i];                     
                }

                resto1 = soma1%11;

                if(resto1 < 2){
                    resto1 = 0;
                }
                else{
                    resto1 = 11 - resto1;
                }
                
                digito1 = resto1.ToString();
                cpf10 = cpf9 + digito1;
                              
                
                for(int i=0;i<10;i++){
                    soma2 += Convert.ToInt32(cpf10[i].ToString()) * multiplicador2[i]; 
                }
                
                resto2 = soma2%11;

                if(resto2 < 2){
                    resto2 = 0;
                }
                else{
                    resto2 = 11 - resto2;
                }

                digito2 = resto2.ToString();
                cpf11 = cpf10 + digito2;

                if(cpf11==cpf){
                    Console.WriteLine("CPF Válido");
                }
                 else{
                     Console.WriteLine("CPF Inválido");
                      }

            }
        
        }
    }
}
