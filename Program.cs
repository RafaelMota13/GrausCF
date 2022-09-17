double ce, fa;
Console.Write("Digite a temperatura (C°): ");
ce = Convert.ToDouble(Console.ReadLine());

fa = ce * 1.8 + 32;

Console.WriteLine($"\n{ce} C° equivalem a {fa} F°\n");
