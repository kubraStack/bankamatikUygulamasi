using System;

namespace bankamatıkUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uygulama Bankamatik

            // menü: Bakiye

            // para yatırma
            // para çekme
            // çıkış
            string secim = "";
            double bakiye = 0;
            double ekHesap = 1000;
            double ekHesapLimiti = 1000; 
            do
            {
                System.Console.Write("1-Bakiye Görüntüleme\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış\nSeçiminiz: ");
                secim = Console.ReadLine();
                switch (secim)
            {
                case "1":
                    System.Console.WriteLine("Bakiyeniz = {0} Tl ", bakiye);
                    System.Console.WriteLine("Ek Hesap Bakiyeniz = {0} Tl ", ekHesap);
                    break;

                case "2":
                    System.Console.Write("Yatırmak istediğiniz miktar: ");
                    double yatirilan = double.Parse(Console.ReadLine());

                    if (ekHesap<ekHesapLimiti)
                    {
                        double ekhesaptankullanilan = ekHesapLimiti - ekHesap;
                        if (yatirilan>=ekhesaptankullanilan)
                        {
                            ekHesap = ekHesapLimiti;
                            bakiye = yatirilan - ekhesaptankullanilan;
                        }else
                        {
                            ekHesap += yatirilan;
                        }
                    }else{
                        bakiye += yatirilan;
                    }
                    
                    break;

                case "3":
                    System.Console.Write("Çekmek istediğiniz miktar: ");
                    double cekilen = double.Parse(Console.ReadLine());
                    if (cekilen > bakiye)
                    {
                        double toplam = bakiye + ekHesap;
                        if (toplam >= cekilen)
                        {
                            System.Console.WriteLine("Ek Hesap Kullanılsın mı ? (e/h)");
                            string ekHesapTercihi = Console.ReadLine();
                            if (ekHesapTercihi=="e")
                            {
                                System.Console.WriteLine("Paranızı Alabilirsiniz");
                                ekHesap -= (cekilen - bakiye);
                                bakiye=0;
                            }else{
                                System.Console.WriteLine("Bakiyeniz Yetersiz");
                            }
                        }
                        
                    }else{
                        System.Console.WriteLine("Parayı Alabilirsiniz.");
                        bakiye -= cekilen; 
                    }
                   
                    break;

                case "4":
                    System.Console.WriteLine("Çıkış");
                    break;
                default:
                    System.Console.WriteLine("Hatalı Seçim");
                    break;
            }
            }  
            while (secim != "4");
            System.Console.WriteLine("Uygulamadan Çıkıldı.");
        }
    }
}
