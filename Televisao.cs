public class Televisao{

    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CAN_MIN = 1;
    private const int CAN_MAX = 520;

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public int UltimoCanal{ get; private set; }
    public int NumeroCanal { get; set; }
    public bool Estado { get; set; }

    public Televisao (float tamanho) {
        Tamanho = tamanho;
        Volume = 0;
    }

    public Televisao (bool estado){
        Estado = estado;
        Canal = 1;
        UltimoCanal = 1;
        Volume = 0;
    }

    public void LigarTelevisao(){
        Estado = true;
        Canal = UltimoCanal;
        Console.WriteLine($"TV ligada. O canal atual é: {Canal}");
    }

    public void DesligarTelevisao(){
        Estado = false;
        UltimoCanal = Canal;
        Console.WriteLine("TV Desligada.");
    }

public void AumentarVolume(){
    if (Volume < VOL_MAX)
        Volume = Volume + 1;
    else
        Console.WriteLine(" TV ja esta no max."); 
}

public void DiminuirVolume(){
    if (Volume > VOL_MIN)
    Volume = Volume - 1;
    else 
        Console.WriteLine("TV ja esta no min.");
}

public void Mudo (){
    Volume = VOL_MIN;
}
public void AumentarCanal(){   
    if (Canal < CAN_MAX){
        Canal = Canal + 1;
        Console.WriteLine($"Canal atual é {Canal}");
        UltimoCanal = Canal;
    }
     else{
        Console.WriteLine("TV já está no Ultimo Canal.");
        UltimoCanal = Canal;
     }
}

public void DiminuirCanal(){
    if (Canal > CAN_MIN){
     Canal = Canal - 1;
     Console.WriteLine($"Canal atual é {Canal}");
    UltimoCanal = Canal;
    }
     else{
        Console.WriteLine("TV já está no primeiro Canal.");
        UltimoCanal = Canal;
     }
}

public void EscolherCanal (int NumeroCanal){
    if (NumeroCanal >= CAN_MIN && NumeroCanal <= CAN_MAX){
        Canal = NumeroCanal;
        UltimoCanal = NumeroCanal;
        Console.WriteLine($"Canal alterado para: {Canal}");
    }
    else{
        Console.WriteLine($"Canal inválido! Digite um número entre {CAN_MIN} e {CAN_MAX}.");
    }
}


}