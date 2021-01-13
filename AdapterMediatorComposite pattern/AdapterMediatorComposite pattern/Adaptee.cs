using System;

class Adaptee
{
    public void SpecificHash(string input)
    {
        static char Crypter(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey);
            return character;
        }
        string NewStr = "";
        foreach (var c in input)
           NewStr += Crypter(c, 0x0088);
        Console.WriteLine(NewStr);
    }
}
