// 19. Проверить истинность утверждения ¬(X V Y) = ¬X ∧ ¬Y
// !(X || Y)==!X && !Y

System.Console.WriteLine(" ¬(X || Y) = ¬X && ¬Y");
System.Console.WriteLine($"0 0 {Convert.ToInt32(!(false||false)),5} {Convert.ToInt32(!false && !false),8}");