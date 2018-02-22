namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ÁBCDEFGHIJKLMNÑOPQRSTUVWXYZABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedarios = ("ábcdefghijklmnñopqrstuvwxyzabcdefghijklmnñopqrstuvwxyz");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            int i=0;
            int s=0;
            string igualdad=Mensaje;
            for(i=0;i<Mensaje.Length;i++){    
                for(s=0;s<=52;s++){
                    if(Mensaje[i]==ABECEDARIO[s]){
                        igualdad=igualdad.Replace(igualdad[i],ABECEDARIO[s-clave]);
                    }
                     if(Mensaje[i]==abecedarios[s]){
                        igualdad=igualdad.Replace(igualdad[i],abecedarios[s-clave]);

                    }
                }    
                
            }
            Mensaje=igualdad;
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        
        public string Encriptar(string Mensaje, int clave)
        {
            int r=0;
            int j=0;
            int a=0;
            string comparar=Mensaje;
            for(r=0;r<Mensaje.Length;r++){ 
                for(j=0;j<=52;j++){
                    if(Mensaje[r]==ABECEDARIO[j]){
                            comparar=comparar.Replace(comparar[r],ABECEDARIO[j+clave]);
                    }
                     if(Mensaje[r]==abecedarios[j]){
                        comparar=comparar.Replace(comparar[r],abecedarios[j+clave]);
                    }
                }    
            }
            Mensaje=comparar;
            return Mensaje;
            

        }
        
        }
    }


