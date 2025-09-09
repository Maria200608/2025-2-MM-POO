// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);

Console.WriteLine ($"A tv tem o tamanho {tv.Tamanho}");

tv.LigarTelevisao();
tv.AumentarCanal();

tv.EscolherCanal(100);

tv.DiminuirCanal();
tv.DesligarTelevisao();

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.Mudo();
Console.WriteLine($"Volume {tv.Volume}");

tv.LigarTelevisao();