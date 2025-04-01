using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;
namespace Solution;
internal class Program{
    static void Main(string[] args){
        // Browser history
        //Outputnya berbeda karena masalah pada test file sehingga history menjadi terbalik
            Console.WriteLine("\nBH Tests:");
            var hM = new HistoryManager();
            hM.KunjungiHalaman("google.com");
            System.Console.WriteLine($"Mengunjungi halaman: google.com");
            hM.KunjungiHalaman("example.com");
            System.Console.WriteLine($"Mengunjungi halaman: example.com");
            hM.KunjungiHalaman("stackoverflow.com");
            System.Console.WriteLine($"Mengunjungi halaman: stackoverflow.com");
            System.Console.WriteLine($"Halaman saat ini: {hM.LihatHalamanSaatIni()}");
            System.Console.WriteLine("Kembali ke halaman sebelumnya...");
            hM.Kembali();
            System.Console.WriteLine($"Halaman saat ini: {hM.LihatHalamanSaatIni()}");
            System.Console.WriteLine("Menampilkan history:");
            hM.TampilkanHistory();
        // Bracket validator
            Console.WriteLine("\nBV Tests:");
            var vd = new BracketValidator();
            var t1 = "{[()]}";
            System.Console.WriteLine($"Ekspresi '{t1}' valid? {vd.ValidasiEkspresi(t1)}");
            var t2 = "{[(])}";
            System.Console.WriteLine($"Ekspresi '{t2}' valid? {vd.ValidasiEkspresi(t2)}");
            var t3 = "";
            System.Console.WriteLine($"Ekspresi '{t3}' valid? {vd.ValidasiEkspresi(t3)}");
            var t4 = "(((";
            System.Console.WriteLine($"Ekspresi '{t4}' valid? {vd.ValidasiEkspresi(t4)}");
            var t5 = ")))";
            System.Console.WriteLine($"Ekspresi '{t5}' valid? {vd.ValidasiEkspresi(t5)}");
        //Palindrome Checker
        string[] testStrings = {
                "Hooh",
                "Ibu ubi",
                "Sisi's Hello World Adventures",
                "Nama : Aman",
                ""
            };
            foreach (var test in testStrings){
                bool result = PalindromeChecker.CekPalindrom(test);
                Console.WriteLine($"{result}\n");
            }

    }
}
