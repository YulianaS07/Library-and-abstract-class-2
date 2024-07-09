using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public abstract class Ksiazka
    {
        public string Nazwa { get; set; }
        public int NumerID { get; set; }
        public string Autor { get; set; }
        public string Wydawnictwo { get; set; }
        public int IloscStron { get; set; }
        public decimal Cena { get; set; }
        public int RokWydania { get; set; }

        public abstract void WyswietlInformacje();
    }
    class Czasopismo : Ksiazka
    {
        public int NumerWydania { get; set; }
        public string Tematyka { get; set; }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa książki: '{Nazwa}', \nAutor/autorzy: {Autor}, \nNazwa wydawnictwa: {Wydawnictwo}, \nRok wydania: {RokWydania}, \nNumerID: #{NumerID}, \nIlość stron: {IloscStron}, \nCena rynkowa: {Cena} zł, \nNumer wydania: №{NumerWydania}, \nTematyka: {Tematyka}");
        }
    }
    class PodrecznikAkademicki : Ksiazka
    {
        public string Dziedzina { get; set; }
        public string Poziom { get; set; }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa książki: '{Nazwa}', \nAutor/autorzy: {Autor}, \nNazwa wydawnictwa: {Wydawnictwo}, \nRok wydania: {RokWydania}, \nNumerID: #{NumerID}, \nIlość stron: {IloscStron}, \nCena rynkowa: {Cena} zł, \nDziedzina akademicka: {Dziedzina}, \nPoziom zaawansowania: {Poziom}");
        }
    }

    class Powiesc : Ksiazka
    {
        public string Gatunek { get; set; }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa książki: '{Nazwa}', \nAutor/autorzy: {Autor}, \nNazwa wydawnictwa: {Wydawnictwo}, \nRok wydania: {RokWydania}, \nNumerID: #{NumerID}, \nIlość stron: {IloscStron}, \nCena rynkowa: {Cena} zł, \nGatunek: {Gatunek}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Czasopismo czasopismo = new Czasopismo
            {
                Nazwa = "Legendy Krakowa",
                NumerID = 24,
                Autor = "Jan Morawski, Anna Kowalczyk",
                Wydawnictwo = "ABC Polska",
                IloscStron = 60,
                Cena = 59.99m,
                RokWydania = 2023,
                NumerWydania = 3,
                Tematyka = "Zaklęte Miejsca Krakowa; Krakowskie Legendy Historyczne; Przygody Niezwykłych Postaci Krakowa; Legendy Sztuki i Architektury Krakowa; Podziemne Tajemnice Krakowa; Magiczne Tradycje Krakowa; Współczesne Interpretacje Krakowskich Legend"
            };

            PodrecznikAkademicki podrecznik = new PodrecznikAkademicki
            {
                Nazwa = "Jak działa mózg oraz jak dbać o jego funkcjonowanie",
                NumerID = 31,
                Autor = "prof. Katarzyna Mogilska",
                Wydawnictwo = "LitNauka",
                IloscStron = 356,
                Cena = 40.99m,
                RokWydania = 2020,
                Dziedzina = "Biologia",
                Poziom = "wysoki"
            };

            Powiesc powiesc = new Powiesc
            {
                Nazwa = "Moje jedyne życzenie",
                NumerID = 19,
                Autor = "Ewa Rzepka",
                Wydawnictwo = "Książkowy Świat",
                IloscStron = 228,
                Cena = 38.98m,
                RokWydania = 2021,
                Gatunek = "Thriller psychologiczny"
            };

            czasopismo.WyswietlInformacje();
            Console.WriteLine("\r\n");
            podrecznik.WyswietlInformacje();
            Console.WriteLine("\r\n");
            powiesc.WyswietlInformacje();

            System.Threading.Thread.Sleep(20000);
        }
    }
}
