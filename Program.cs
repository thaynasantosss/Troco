decimal valorCompra, valorPago, valorTroco;

Console.WriteLine("*** Troco ***");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Valor total da compra (R$): ");
valorCompra = Convert.ToDecimal(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Valor recebido pelo caixa (R$): ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorTroco = valorPago - valorCompra;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nTroco: {valorTroco:C}");
Console.ResetColor();
