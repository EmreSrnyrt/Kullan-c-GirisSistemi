using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<kullanici> kullanicis = new List<kullanici>()
            {
                new kullanici() {Username = "qqq", Password = "111", Userid = 1, Ad = "emre", Soyad = "srn", TC =  11111111111, Posta = "abcdef@gmail.com" },
                new kullanici() {Username = "www", Password = "222", Userid = 2, Ad = "emre1", Soyad = "srn", TC = 22222222222, Posta = "abcdef@gmail.com" },
                new kullanici() {Username = "aaa", Password = "333", Userid = 3, Ad = "emre2", Soyad = "srn", TC = 33333333333, Posta = "abcdef@gmail.com" },
                new kullanici() {Username = "add", Password = "444", Userid = 4, Ad = "emre3", Soyad = "srn", TC = 44444444444, Posta = "abcdef@gmail.com" },
                new kullanici() {Username = "abc", Password = "555", Userid = 5, Ad = "emre4", Soyad = "srn", TC = 55555555555, Posta = "abcdef@gmail.com" }
            };
            int hak = 3;
        giris:
            //Console.WriteLine(kullanicis.Count());
            hak--;
            Console.WriteLine("*****Kullanıcı Sistemi*****");
            Console.Write("Kullanıcı Username: ");
            string Username = Console.ReadLine();
            Console.Write("Kullanıcı Şifre: ");
            string Password = Console.ReadLine();

            foreach (kullanici x in kullanicis)
            {
                if (Username == x.Username && Password == x.Password)
                {
                    Console.Clear();
                    Console.WriteLine("Merhaba " + x.Ad.ToUpper() + " " + x.Soyad.ToUpper());
                    Console.WriteLine("Devam etmek için enter'a tıklayın.");
                    Console.ReadLine();

                    bool secim = true;
                    while (secim)
                    {
                        Console.Clear();
                        //menu:
                        Console.WriteLine("***********************");
                        Console.WriteLine("KULLANICI GİRİŞ SİSTEMİ");
                        Console.WriteLine("***********************");

                        Console.WriteLine("İşlem Seçiniz");
                        Console.WriteLine("Kullanıcı Ekle \t\t [1]");
                        Console.WriteLine("Kullanıcı Listele \t [2]");
                        Console.WriteLine("Kullanıcı Sil \t\t [3]");
                        Console.WriteLine("Programı Kapat \t\t [0]");
                        Console.Write("SEÇİMİNİZ: ");

                        int islem = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (islem)
                        {
                            case 1:
                                Console.WriteLine("****************");
                                Console.WriteLine("KULLANICI EKLEME");
                                Console.WriteLine("****************");
                                Console.WriteLine("Kaç kişi eklenecek: ");
                                int a = Convert.ToInt32(Console.ReadLine());
                                //kullanici yeniuser = new kullanici(); 
                                //for (int i = 0; i < a; i++)
                                //{
                                //    kullanicis.Add(new kullanici { Ad = "", Soyad ="",});
                                //    Console.Write("Adınızı Giriniz:");
                                //    yeniuser.Ad = Console.ReadLine();
                                //    Console.Write("Soyadınızı Giriniz:");
                                //    yeniuser.Soyad = Console.ReadLine();
                                //    Console.Write("Username: ");
                                //    yeniuser.Username = Console.ReadLine();
                                //    Console.Write("Password: ");
                                //    yeniuser.Password = Console.ReadLine();
                                //    Console.WriteLine();
                                //    yeniuser.Userid = kullanicis.Count() + 1;
                                //    kullanicis.Add(yeniuser);
                                //}
                                for (int i = 0; i < a; i++)
                                {
                                    Console.Write("Adınızı Giriniz:");
                                    string Ad = Console.ReadLine();
                                    Console.Write("Soyadınızı Giriniz:");
                                    string Soyad = Console.ReadLine();
                                    Console.Write("Username: ");
                                    string Usname = Console.ReadLine();
                                    Console.Write("Password: ");
                                    string Pasword = Console.ReadLine();
                                    Console.WriteLine();
                                    int Userid = kullanicis.Count() + 1;
                                    kullanicis.Add(new kullanici { Ad = Ad, Soyad = Soyad, Username = Usname, Password = Pasword, Userid = Userid });
                                }
                                break;
                            case 2:
                                Console.WriteLine("*******************");
                                Console.WriteLine("KULLANICI LİSTELEME");
                                Console.WriteLine("*******************");
                                foreach (kullanici nesne in kullanicis)
                                {
                                    Console.WriteLine(nesne.Ad + " " + nesne.Soyad + " " + nesne.Userid + " " + nesne.Password);
                                }
                                Console.WriteLine("Menüye dönmek için enter'a tıklayın.");
                                Console.ReadKey();
                                break;


                            case 3:
                                Console.WriteLine("***************");
                                Console.WriteLine("KULLANICI SİLME");
                                Console.WriteLine("***************");
                                Console.Write("Silmek istediğiniz kullanıcı username'i giriniz: ");
                                string kadi = Console.ReadLine();
                                bool durum = false;
                                foreach (kullanici nesne1 in kullanicis)
                                {
                                    if (kadi == nesne1.Username)
                                    {
                                        durum = true;
                                        kullanicis.Remove(nesne1);
                                        Console.WriteLine("kullanıcı silindi");
                                        // Console.ReadKey();
                                        break;
                                        //goto menu;
                                    }
                                }
                                if (durum == false)
                                {
                                    Console.WriteLine("kayıtlı kullanıcı bulunamadı");
                                    Console.ReadKey();
                                }
                                break;
                            case 0:
                                Console.WriteLine("Sistem kapatılıyor !");
                                Console.ReadLine();
                                return;

                        }
                    }
                }
            }
            if (hak == 0)
            {
                Console.Clear();
                Console.WriteLine("Giriş Başarısız");

                Console.WriteLine("Çıkış Yapılıyor");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Giriş Başarısız");

                Console.WriteLine($"Kalan Hak:{hak}");
                Console.WriteLine("Tekrar Giriş Yapmak İçin Enter'a basınız.");
                Console.ReadLine();
                goto giris;

            }
        }
    }
}
