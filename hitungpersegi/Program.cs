public class Persegi
{
    public double Sisi { get; set; }

    public double HitungLuas()
    {
        return Sisi * Sisi;
    }

    public double HitungKeliling()
    {
        return 4 * Sisi;
    }
}

class Program
{
    static void Main()
    {
        // Test code
        Console.WriteLine("Masukkan panjang sisi persegi:");
        double panjangSisi = Convert.ToDouble(Console.ReadLine());

        Persegi persegi = new Persegi { Sisi = panjangSisi };

        double luas = persegi.HitungLuas();
        double keliling = persegi.HitungKeliling();

        Console.WriteLine($"Luas persegi: {luas}");
        Console.WriteLine($"Keliling persegi: {keliling}");

        Console.ReadLine(); // Biar console tidak langsung tertutup
    }
}