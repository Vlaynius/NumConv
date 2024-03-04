namespace NumConverter;
class Program
{
    static void Main(string[] args)
    {
        string[] numText = {"", "bir ", "iki ", "üç ", "dört ", "beş ", "altı ", "yedi ", "sekiz ", "dokuz " };
        string[] yazi = {"","on ","yirmi ","otuz ","kırk ","elli ", "altmış ", "yetmiş ","seksen ", "doksan " };
        string metin = "";
        long temp;int a,b,c;
        long number = 1234567890;//Number to Convert
        if(number == 0)
        {
            metin = "sıfır";
            Console.WriteLine(metin);
            Console.ReadKey();
            return;
        }
        temp = number / 1000000000;
        number = number - temp * 1000000000;
        if (temp != 0)
        {
            a = (int)temp / 100;
            temp = temp - a * 100;
            if( a != 0 && a!= 1)
                metin = metin + numText[a] + "yüz ";
            else if(a == 1)
                metin = metin + "yüz ";
            b = (int)temp / 10;
            c = (int)temp - b * 10;
            metin = metin + yazi[b] + numText[c] + "milyar ";
        }
        temp = number / 1000000;
        number = number - temp * 1000000;
        if (temp != 0)
        {
            a = (int)temp / 100;
            temp = temp - a * 100;
            if (a != 0 && a != 1)
                metin = metin + numText[a] + "yüz ";
            else if (a == 1)
                metin = metin + "yüz ";
            b = (int)temp / 10;
            c = (int)temp - b * 10;
            metin = metin + yazi[b] + numText[c] + "milyon ";
        }
        temp = number / 1000;
        number = number - temp * 1000;
        if (temp != 0)
        {
            a = (int)temp / 100;
            temp = temp - a * 100;
            if (a != 0 && a != 1)
                metin = metin + numText[a] + "yüz ";
            else if (a == 1)
                metin = metin + "yüz ";
            b = (int)temp / 10;
            metin = metin + yazi[b];
            c = (int)temp - b * 10;
            if(c != 1)
                metin = metin + numText[c];
            metin = metin + "bin ";
        }
        temp = number;
        if(temp != 0)
        {
            a = (int)temp / 100;
            temp = temp - a * 100;
            if (a != 0 && a != 1)
                metin = metin + numText[a] + "yüz ";
            else if (a == 1)
                metin = metin + "yüz ";
            b = (int)temp / 10;
            c = (int)temp - b * 10;
            metin = metin + yazi[b] + numText[c]; ;
        }
        Console.WriteLine(metin);
        Console.ReadKey();
    }
}