using System;
using System.Numerics;
using System.Runtime.Intrinsics;

//задание1
// namespace Vector
// {
//     public struct Vectors
//     {
//         public double X { get; set; }
//         public double Y { get; set; }
//         public double Z { get; set; }
//         public Vectors(double x, double y, double z)
//         {
//             X = x;
//             Y = y;
//             Z = z;
//         }
//         public static Vectors operator *(Vectors vector, double number)
//         {
//             return new Vectors(vector.X * number, vector.Y * number, vector.Z * number);
//         }
//         public static Vectors operator +(Vectors a1, Vectors a2)
//         {
//             return new Vectors(a1.X + a2.X, a1.Y + a2.Y, a1.Z + a2.Z);
//         }
//         public static Vectors operator -(Vectors a1, Vectors a2)
//         {
//             return new Vectors(a1.X - a2.X, a1.Y - a2.Y, a1.Z - a2.Z);
//         }
//         public override string ToString()
//         {
//             return $"Vector: ({X}, {Y}, {Z})";
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Vectors a1 = new Vectors(1.0, 2.0, 3.0);
//             Vectors a2 = new Vectors(4.0, 5.0, 6.0);
//             Vectors umn= a2 * 3;
//             Console.WriteLine("Умножение вектора на число: " + umn);
//             Vectors sum = a1 + a2;
//             Console.WriteLine("Сложение векторов: " + sum);
//             Vectors otnim = a1 -a2;
//             Console.WriteLine("Вычитание векторов: " + otnim);
//         }
//     }
// }



//задание 2
// namespace Number
// {
//     public struct Number10
//     {
//         public int Value { get; set; }
//         public Number10(int value)
//         {
//             Value = value;
//         }
//         public string Number2()
//         {
//             return Convert.ToString(Value, 2);
//         }
//         public string Number8()
//         {
//             return Convert.ToString(Value, 8);
//         }
//         public string Number16()
//         {
//             return Convert.ToString(Value, 16).ToUpper();
//         }
//         public override string ToString()
//         {
//             return $"Number10: ({Value})";
//         }
//     }
//     internal class DecimalNumbers
//     {
//         static void Main()
//         {
//             Number10 number = new Number10(221);
//             Console.WriteLine("Двоичная система: " + number.Number2());
//             Console.WriteLine("Восьмеричная система: " + number.Number8());
//             Console.WriteLine("Шестнадцатеричная система: " + number.Number16());
//         }
//     }
// }




//задание3
// namespace Color
// {
//     public struct RGBColor
//     {
//         public string R { get; set; }
//         public string G { get; set; }
//         public string B { get; set; }
//         public RGBColor(string r, string g, string b)
//         {
//             R = r;
//             G = g;
//             B = b;
//         }
//         public string HexFormat()
//         {
//             int r = int.Parse(R);
//             int g = int.Parse(G);
//             int b = int.Parse(B);
//             return $"#{r:X2}{g:X2}{b:X2}";
//         }
//         public string HSLFormat()
//         {
//             double r = int.Parse(R) / 255.0;
//             double g = int.Parse(G) / 255.0;
//             double b = int.Parse(B) / 255.0;
//             double max = Math.Max(r, Math.Max(g, b));
//             double min = Math.Min(r, Math.Min(g, b));
//             double delta = max - min;
//             double h = 0;
//             if (delta != 0)
//             {
//                 if (max == r)
//                     h = (g - b) / delta + (g < b ? 6 : 0);
//                 else if (max == g)
//                     h = (b - r) / delta + 2;
//                 else
//                     h = (r - g) / delta + 4;
//                 h /= 6;
//             }
//             double l = (max + min) / 2;
//             double s = delta == 0 ? 0 : delta / (1 - Math.Abs(2 * l - 1));
//             return $"H={h * 360:F1}, S={s * 100:F1}%, L={l * 100:F1}%";
//         }
//         public string CMYKFormat()
//         {
//             double r = int.Parse(R) / 255.0;
//             double g = int.Parse(G) / 255.0;
//             double b = int.Parse(B) / 255.0;
//             double k = 1 - Math.Max(r, Math.Max(g, b));
//             if (k == 1)
//                 return "C=0.0%, M=0.0%, Y=0.0%, K=100.0%";
//             double c = (1 - r - k) / (1 - k);
//             double m = (1 - g - k) / (1 - k);
//             double y = (1 - b - k) / (1 - k);
//             return $"C={c * 100:F1}%, M={m * 100:F1}%, Y={y * 100:F1}%, K={k * 100:F1}%";
//         }
//         public override string ToString()
//         {
//             return $"RGB({R}, {G}, {B})";
//         }
//     }
//     internal class RGB
//     {
//         static void Main()
//         {
//             RGBColor color = new RGBColor("255", "255", "255");
//             string hex = color.HexFormat();
//             Console.WriteLine("HEX формат: " + hex);
//             string hsl = color.HSLFormat();
//             Console.WriteLine("HSL формат: " + hsl);
//             string cmyk = color.CMYKFormat();
//             Console.WriteLine("CMYK формат: " + cmyk);
//         }
//     }
// }