internal class Program
{
    private static void Main(string[] args)
    {
        string filepath = "D:/VSWorks/symbolfiles/symbols.txt";
        StreamReader file = new(filepath);
        string infile = file.ReadToEnd();
        int lngth = 1;
        int mxlngth = 0;
        if (infile.Length <= 1000000 - 1)
            for (int i = 1; i < infile.Length; i++)
            {
                if (infile[i] == 'X' & infile[i - 1] == 'X')
                    lngth += 1;
                else
                {
                    if (mxlngth < lngth)
                    mxlngth = lngth;
                    lngth = 1;
                }
                if (i == infile.Length - 1)
                {
                    if (mxlngth < lngth)
                        mxlngth = lngth;
                    lngth = 1;
                }
            }
        else Console.WriteLine("Количество символов в файле превышает допустимую величину!");
        Console.WriteLine(mxlngth);
    }
}