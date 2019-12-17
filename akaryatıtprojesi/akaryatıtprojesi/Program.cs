using System;

namespace akaryatıtprojesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 6.00, benzin = 6.50, lpg = 3.50;
            double dizelTank = 1000, benzinTank = 1000, lpgTank = 1000;
            double satilacakMiktar = 0;
            char anaMenuSecim = '0', altMenuSecim = '0', akarYakitFiyatiGuncelle = '0', akarYakitSatisTipi = '0';
            MENU:
            Console.WriteLine("AkaryatıSatış Takip Programı:");
            Console.WriteLine("1-Akaryakıt Fiyatlarını Göster:");
            Console.WriteLine("2-Akaryakıt Fiyatlarını Güncelle:");
            Console.WriteLine("3-Akaryakıt Satış Yap :");
            Console.WriteLine("4-Depo Durumunu Göster:");
            Console.WriteLine("5-Satışları Göster:");
            Console.WriteLine("6-Programdan Çık");
            
            Console.Write("Seçim Yapınız [1,2,3,4,5,6]");
            anaMenuSecim = Convert.ToChar(Console.ReadLine());
            if (anaMenuSecim=='1')
            {
                Console.Clear();
                Console.WriteLine("1'i seçtiniz");
                Console.WriteLine("Birim Fiyatlar Listesi :");
                Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                Console.WriteLine("Lpg (L):{0} TL/Litre", lpg);
            ALTMENU:
                Console.WriteLine("Seçiminizi Yapın : [1: Ana Menüye Dön 2:Programı Kapat!]:");

                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim=='1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim=='2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız!");
                    goto ALTMENU;

                }







            }
            else if (anaMenuSecim=='2')
            {
                Console.Clear();
                Console.WriteLine("2'yi seçtiniz!");
                Console.WriteLine("Birim Fiyatlarını Güncelleme Menüsü:");
            AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt tipini lütfen seçiniz:[D,B,L]");
                akarYakitFiyatiGuncelle = Convert.ToChar(Console.ReadLine());
                if (akarYakitFiyatiGuncelle=='D' || akarYakitFiyatiGuncelle=='d')
                {
                    Console.WriteLine("Dizeli seçtiniz (D):{0} TL/Litre", dizel);
                    Console.WriteLine("Lütfen Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik başarıyla yapılmıştır!");
                    Console.WriteLine("Dizel'in Yeni Fiyatı (D):{0} TL/Litre", dizel);

                }
                else if (akarYakitFiyatiGuncelle == 'B' || akarYakitFiyatiGuncelle == 'b')
                {
                    Console.WriteLine("Benzini seçtiniz (B):{0} TL/Litre", dizel);
                    Console.WriteLine("Lütfen Yeni Fiyat Giriniz:");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik başarıyla yapılmıştır!");
                    Console.WriteLine("Benzin'in Yeni Fiyatı (D):{0} TL/Litre", benzin);

                }
                else if (akarYakitFiyatiGuncelle == 'L' || akarYakitFiyatiGuncelle == 'l')
                {
                    Console.WriteLine("Lpg'yi seçtiniz (D):{0} TL/Litre", dizel);
                    Console.WriteLine("Lütfen Yeni Fiyat Giriniz:");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik başarıyla yapılmıştır!");
                    Console.WriteLine("Lpg'nin Yeni Fiyatı (L):{0} TL/Litre", lpg);

                }
                else
                {
                    Console.WriteLine("Lütfen yukarıdaki karakterlerden(d,l,b) birini seçiniz!:");
                    goto AKARYAKITTIPI;
                }
            ALTMENU:
                Console.WriteLine("Seçiminizi Yapın : [1: Ana Menüye Dön 2:Programı Kapat!]:");

                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız!");
                    goto ALTMENU;

                }
            }
            else if (anaMenuSecim=='3')
            {
                Console.Clear();
                Console.WriteLine("3'ü seçtiniz!");
                Console.WriteLine("Akaryakıt Satış Yapma:");
            AKARYAKITSATIS:
                Console.WriteLine("Akaryakıt tipini seçiniz [D,B,L]");
                akarYakitSatisTipi = Convert.ToChar(Console.ReadLine());
                if (akarYakitSatisTipi=='D' || akarYakitSatisTipi=='d')
                {
                    if (dizelTank==0)
                    {
                        Console.WriteLine("Dizel Yakıt Tankı Boş Satış Yapılamaz");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Alınacak Dizel Yakıt?");
                        satilacakMiktar = Convert.ToDouble(Console.ReadLine());
                        if (dizelTank<satilacakMiktar)
                        {
                            Console.WriteLine("Tankta {0} litre var!İşlem yapılamaz!",dizelTank);
                            goto MENU;
                        }
                        else if (satilacakMiktar<=dizelTank)
                        {
                            dizelTank = dizelTank - satilacakMiktar;
                            Console.WriteLine("Yakıt dolumunuz başarıyla tamamlanmıştır!");
                            Console.WriteLine("Yakıt Tankında {0} litre dizel yakıt kalmıştır", dizelTank);

                        }
                    }
                }
               else if (akarYakitSatisTipi == 'B' || akarYakitSatisTipi == 'b')
                {
                    if (dizelTank == 0)
                    {
                        Console.WriteLine("Benzin Yakıt Tankı Boş Satış Yapılamaz");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Alınacak Benzin Yakıt?");
                        satilacakMiktar = Convert.ToDouble(Console.ReadLine());
                        if (benzinTank < satilacakMiktar)
                        {
                            Console.WriteLine("Tankta {0} litre var!İşlem yapılamaz!", benzinTank);
                            goto MENU;
                        }
                        else if (satilacakMiktar <= benzinTank)
                        {
                            benzinTank = benzinTank - satilacakMiktar;
                            Console.WriteLine("Yakıt dolumunuz başarıyla tamamlanmıştır!");
                            Console.WriteLine("Yakıt Tankında {0} litre benzin yakıt kalmıştır", benzinTank);

                        }
                    }
                }
              else if (akarYakitSatisTipi == 'L' || akarYakitSatisTipi == 'l')
                {
                    if (lpgTank == 0)
                    {
                        Console.WriteLine("Lpg Yakıt Tankı Boş Satış Yapılamaz");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Alınacak Lpg Yakıt?");
                        satilacakMiktar = Convert.ToDouble(Console.ReadLine());
                        if (lpgTank < satilacakMiktar)
                        {
                            Console.WriteLine("Tankta {0} litre var!İşlem yapılamaz!", lpgTank);
                            goto MENU;
                        }
                        else if (satilacakMiktar <= lpgTank)
                        {
                            lpgTank = lpgTank - satilacakMiktar;
                            Console.WriteLine("Yakıt dolumunuz başarıyla tamamlanmıştır!");
                            Console.WriteLine("Yakıt Tankında {0} litre lpg yakıt kalmıştır", lpgTank);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Yukarıdaki Yakıt Türlerinden [D,B,L] birini seçiniz");
                    goto AKARYAKITSATIS;
                }
            ALTMENU:
                Console.WriteLine("Seçiminizi Yapın : [1: Ana Menüye Dön 2:Programı Kapat!]:");

                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız!");
                    goto ALTMENU;

                }


            }
            else if (anaMenuSecim=='4')
            {
                Console.Clear();
                Console.WriteLine("4'ü seçtiniz!");
                Console.WriteLine("Bu menü depo durumunu gösterir.");
                Console.WriteLine("Dizel Yakıt Tankı %{0} doludur.", (dizelTank/10));
                Console.WriteLine("Benzin Yakıt Tankı %{0} doludur.", (benzinTank / 10));
                Console.WriteLine("Lpg Yakıt Tankı %{0} doludur.", (lpgTank / 10));
            ALTMENU:
                Console.WriteLine("Seçiminizi Yapın : [1: Ana Menüye Dön 2:Programı Kapat!]:");

                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız!");
                    goto ALTMENU;

                }

            }
            else if (anaMenuSecim=='5')
            {
                Console.Clear();
                Console.WriteLine("Bu menü satışları gösterir");
                Console.WriteLine("Satılan toplam dizel yakıt :{0}",(1000-dizelTank)*dizel);
                Console.WriteLine("Satılan toplam benzin yakıt :{0}", (1000 - benzinTank)*benzin);
                Console.WriteLine("Satılan toplam lpg yakıt :{0}", (1000 - lpgTank)*lpg);
                Console.WriteLine("Toplam Satış:{0}", ((1000 - dizelTank) * dizel)+ ((1000 - benzinTank) * benzin)+((1000 - lpgTank) * lpg));
            ALTMENU:
                Console.WriteLine("Seçiminizi Yapın : [1: Ana Menüye Dön 2:Programı Kapat!]:");

                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız!");
                    goto ALTMENU;

                }

            }
            else if (anaMenuSecim=='6')
            {
                Console.WriteLine("Program Sonlandırılıyor!");
                Environment.Exit(0);
            }












            

        }
    }
}
