

partial class Program
{
    static void Main(string[] args)
    {
        // Değikenler büyük küçük harf duyarlıdır.
        // Değişkenler rakam ile başlayamaz.
        // Değişkenler boşluk içeremez.
        // Değişkenler özel karakter içeremez.
        // Değişkenler tanımlanırken keywordler kullanılamaz.
        // Değişkenler tanımlanırken Türkçe karakter kullanılamaz.
        // Değişkenler tanımlanırken birden fazla kelime kullanılacaksa camelCase kullanılır.
        // Aynı kod bloğu içerisinde aynı isimde değişken tanımlanamaz.
        // Aynı değişken int ve string olarak tanımlanamaz.
        int value = 10;
        string name = "John";

        byte a = 5;    // 1 byte
        short b = 5;   // 1 byte
        sbyte c = 5;   // 2 byte
        ushort d = 5;  // 2 byte

        Int16 i16 = 2; // 2 byte
        int i = 2;     // 4 byte
        Int32 i32 = 2; // 4 byte
        Int64 i64 = 2; // 8 byte

        uint ui = 2;   // 4 byte
        long l = 4;    // 8 byte
        ulong ul = 4;  // 8 byte

        float f = 5;   // 4 byte
        double d1 = 5; // 8 byte
        decimal de = 5;// 16 byte

        char ch = '2'; // 2 byte
        string str = "John"; // Sınırsız

        bool b1 = true;

        DateTime dt = DateTime.Now; // 8 byte Date and hours
        Console.WriteLine(dt);

        // object her türlü veriyi tutabilir.

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        // string ifadeler

        string str1 = string.Empty;         // Boş değer
        str1 = "John";
        string ad = "Ferhat";
        string soyad = "Mete";
        string tamIsim = ad + " " + soyad;

        // integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        // boolean

        bool bool1 = 10 > 2;

        // Değişken dönüşümleri

        string str20 = "20";
        int int20 = 20;

        string newValue = str20 + int20.ToString();
        Console.WriteLine(newValue); // 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); // 40

        int int22 = int20 + int.Parse(str20); //40

        // datetime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}