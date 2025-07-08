namespace DataTypeLimits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Byte-8 
            Console.WriteLine(nameof(Byte));                        //Veri tipi hakkında bilgi verir.
            Console.WriteLine($"Minimum Limit:\t {Byte.MinValue}"); //Veri tipinin alabileceği en küçük değeri yazdırır.
            Console.WriteLine($"Maximum Limit:\t {Byte.MaxValue}"); //Veri tipinin alabileceği en büyük değeri yazdırır.
            Console.WriteLine($"Size:\t {sizeof(Byte)}");           //Veri türünün bellekte kapladığı alanı yazdırır.

            Console.WriteLine(new string('*', 41));                 //Ekranı görsel olarak ayırmak için 41 yıldız. Kocaelispor’a Süper Lig’de başarılar:)

            //SByte-8
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Minimum Limitt:\t {SByte.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {SByte.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(SByte)}");

            Console.WriteLine(new string('*', 41));


            //Short-16 bit
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Minimum Limit:\t {Int16.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {Int16.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(Int16)}");

            Console.WriteLine(new string('*', 41));

            //UShort-16 bit
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Minimum Limit:\t {UInt16.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {UInt16.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(UInt16)}");

            Console.WriteLine(new string('*', 41));

            //Int-32 bit
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Minimum Limit:\t {Int32.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {Int32.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(Int32)}");

            Console.WriteLine(new string('*', 41));

            //UInt-32 bit
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Minimum Limit:\t {UInt32.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {UInt32.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(UInt32)}");

            Console.WriteLine(new string('*', 41));


            //long-64 bit
            Console.WriteLine(nameof(Int64));
            Console.WriteLine($"Minimum Limit:\t {Int64.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {Int64.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(Int64)}");

            Console.WriteLine(new string('*', 41));

            //ulong-64 bit
            Console.WriteLine(nameof(UInt64));
            Console.WriteLine($"Minimum Limit:\t {UInt64.MinValue}");
            Console.WriteLine($"Maximum Limit:\t {UInt64.MaxValue}");
            Console.WriteLine($"Size:\t {sizeof(UInt64)}");

            Console.WriteLine(new string('*', 41));
        }
    }
}
