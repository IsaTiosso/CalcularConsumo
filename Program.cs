float tempo = 0, vm = 0, distancia = 0, litros = 0;

Console.Write("Entre com tempo gasto: ");
tempo = float.Parse(Console.ReadLine());

Console.WriteLine("Entre com a velocidade média");
vm = float.Parse(Console.ReadLine());

distancia = tempo * vm;

/* Este cálculo asume que o veículo consume 1 litro de combústivel para cada 
 * 12 quilometros percorridos */
litros = distancia / 12;

Console.WriteLine("Sua velocidade média fois de" + vm + "Km/h");
Console.WriteLine("O tempo gasto foi de" + tempo);
Console.WriteLine("A distancia percorrida foi de" + distancia + "km");
Console.WriteLine("Foram utilizados" + litros + "litros");