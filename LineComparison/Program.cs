Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
//int num=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("the number is:"+num);
int x1 = Convert.ToInt16(Console.ReadLine());
int y1 = Convert.ToInt16(Console.ReadLine());
int x2 = Convert.ToInt16(Console.ReadLine());
int y2=Convert.ToInt16(Console.ReadLine());
double lengthoftheline;

lengthoftheline= (double)Math.Sqrt((x2 - x1)^2 +(y2 - y1)^2); 
Console.WriteLine(lengthoftheline);
