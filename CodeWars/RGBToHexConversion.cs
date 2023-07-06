public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        r = Clamp(r, 0, 255);
        g = Clamp(g, 0, 255);
        b = Clamp(b, 0, 255);

        return $"{r:X2}{g:X2}{b:X2}";
    }

    private static int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;
        if (value > max)
            return max;
        return value;
    }
}
