using System;

namespace DataTypeLimits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konsol başlığını ayarlıyoruz
            Console.Title = "Veri Tipleri Bilgilendirme Uygulaması";

            // Her veri tipi için bilgi yazdıran metodu çağırıyoruz
            PrintTypeInfo<byte>();
            PrintTypeInfo<sbyte>();
            PrintTypeInfo<short>();
            PrintTypeInfo<ushort>();
            PrintTypeInfo<int>();
            PrintTypeInfo<uint>();
            PrintTypeInfo<long>();
            PrintTypeInfo<ulong>();
        }

        /// <summary>
        /// Belirtilen veri tipi hakkında minimum, maksimum ve bellek boyutu bilgilerini ekrana yazdırır.
        /// </summary>
        /// <typeparam name="T">İncelenecek sayısal veri tipi</typeparam>
        static void PrintTypeInfo<T>() where T : struct
        {
            // Veri tipinin adını yazdır
            Console.WriteLine($"Veri Tipi: {typeof(T).Name}");

            // Minimum ve maksimum değerleri yazdır
            Console.WriteLine($"Minimum Limit:\t {GetMinValue<T>()}");
            Console.WriteLine($"Maximum Limit:\t {GetMaxValue<T>()}");

            // Bellekte kapladığı boyutu yazdır (byte cinsinden)
            Console.WriteLine($"Size:\t\t {System.Runtime.InteropServices.Marshal.SizeOf(typeof(T))} byte");

            // Görsel ayrım için yıldız çizgisi
            Console.WriteLine(new string('*', 41));
        }

        /// <summary>
        /// Generic veri tipinin MinValue alanını yansıma (reflection) ile alır.
        /// </summary>
        static object GetMinValue<T>() => typeof(T).GetField("MinValue").GetValue(null);

        /// <summary>
        /// Generic veri tipinin MaxValue alanını yansıma (reflection) ile alır.
        /// </summary>
        static object GetMaxValue<T>() => typeof(T).GetField("MaxValue").GetValue(null);
    }
}
