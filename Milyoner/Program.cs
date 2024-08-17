Console.WriteLine("Merhabalar ben Kenan İmirzalıoğru Kim Milyoner Olmak İster yarışmamıza Hoş Geldiniz ");
Console.WriteLine("İsiminizi Söyler Misiniz?");
string isim = Console.ReadLine();
Console.WriteLine($"Yarışmamıza Nereden Katılıyorsunuz {isim}");
string sehir = Console.ReadLine();

Console.WriteLine($"Kim milyoner olmak ister yarışmamıza tekrardan Hoş Geldin {isim}");
Console.WriteLine("Lütfen Cevaplarınızı Büyük harf kullanarak yazınız");
Console.WriteLine("O zaman hazırsanız yarışmamıza başlıyoruz (Enter'a basınız)");
Console.ReadLine();
Console.WriteLine("İşte ilk sorunuz geliyor...");

int Para = 0;
bool telefon = true;
bool seyirci = true;
bool yariyariya = true;

string[] sorular1 = new string[5];
sorular1[0] = "Soru 1-Çoğunlukla eski el yazması kitapların kenarlarında bulunan altın rengi süslemeler hangi sanat eserinin örnekleridir? ?\nA-Tezhip B-Telkari\nC-Hat D-Gravür";

sorular1[1] = "Soru 1-Bir sınıfta öğrenciler sırayla \"Burada\" \"Burada\" diyorlarsa o an sınıfta ne yapılıyordur? \nA-Yoklama B-Yazılı\nC-Sözlü D-Veli Toplantısı";

sorular1[2] = "Soru 1-Harikalar Diyarı'ndaki maceraları ile tanınan Alice'in en büyük düşmanı olan kralice, iskambilde hangi kart grubuna mensuptur?\nA-Kupa B-Karo\nC-Sinek D-Maça";

sorular1[3] = "Soru 1-Şehir Trafiğini aksatmamak amacıyla yerleşim yerinin dışından geçen ve şehir yollarına bağlanan ana yola ne ad verilir?\nA-Çevre yolu B-Tali yol\nC-Duble yol D-Stabilize yol";

sorular1[4] = "Soru 1-\"Kim milyoner olmak ister?\"yarışmasına katılan yarışmacıla klişe olarak en çok hangisinden korktuklarını söylerler?\nA-İlk soruda elenmekten B-Koltuktan düşmekten\nC-1 Milyonu Kazanmaktan D-Sunucudan";

Random rnd1 = new Random();
int rastgele1 = rnd1.Next(0, sorular1.Length);
Console.WriteLine("" + sorular1[rastgele1]);

Console.Write("Joker kullanmak ister misiniz? (E/H): ");
string joker1 = Console.ReadLine().ToUpper();

if (joker1 == "E")
{
    Console.WriteLine("Telefon Jokeri için 1'e, Yarı yarıya için 2'e, Seyirci hakkınız için 3'e basınız.");
    string ilkcevap = Console.ReadLine();
    switch (ilkcevap)
    {
        case "1":
            while (telefon == true)
            {

                Console.WriteLine("Ali Veli Aranıyor...");
                Console.WriteLine("Ali Veli: Cevabın A olduğunu düşünüyorum.");
                telefon = false;

            }

            ilkcevap = Console.ReadLine();
            Console.WriteLine("Evet son kararınız nedir?:");
            ilkcevap = Console.ReadLine();

            break;

        case "2":
            while (yariyariya == true)
            {

                Console.WriteLine("CEVAP B YADA D DEĞİL");
                yariyariya = false;

            }

            ilkcevap = Console.ReadLine();
            Console.WriteLine("Evet son kararınız nedir?:");
            ilkcevap = Console.ReadLine();

            break;


        case "3":
            while (seyirci == true)
            {

                Console.WriteLine("Seyircilerin Cevapları:" + " " + "%60A" + " " + "%10B" + " " + "%10C" + " " + "%20D");
                seyirci = false;
            }
            Console.WriteLine("Joker Hakkınız Bitmiştir");
            ilkcevap = Console.ReadLine();
            Console.WriteLine("Evet son kararınız nedir?:");
            ilkcevap = Console.ReadLine();


            break;



    }

    switch (ilkcevap)
    {

        case "A":
            Para += 5000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }

}

else
{
    Console.WriteLine("joker hakkınızı kullanmadınız, cevabınızı yazınız.");
    string ilkcevap = Console.ReadLine();
    switch (ilkcevap)
    {

        case "A":
            Para += 5000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sırada ki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }
}



Console.WriteLine();
Console.WriteLine();
string s1 = Console.ReadLine();
if (s1 == "EVET" || s1 == "evet")
{

    Console.WriteLine("Yarışmadan Çekildiniz Kazancınız " + Para + "TL");
    Environment.Exit(0);
}


//Soru 2 dizisi

string[] soru2 = new string[5];
soru2[0] = "Soru 2-Birini başladığı işten vazgeçirmek için söylenen söz hangisidir?\r\n\nA-Eski hamam eski tas B-Şov devam etmeli\nC-Yol yakınken dön D-Oldu da bitti maşallah\r\n";

soru2[1] = "Soru 2-\"Civcivli\" ifadesi nasıl yerler için kullanılır?\r\n\nA-Sessiz sakin  B-Eski püskü\nC-Gürültü patırtılı D-Ufak tefek";

soru2[2] = "Soru 2-\"Game of Thrones\" dizisinde ki yedi krallık'ın başkentinde ki kraliyet tahtı hangisinden hangisinden yapılmıştır?\nA-Kemiklerden B-Kristalden\nC-Kılıçlardan D-Altından";

soru2[3] = "Soru 2-Hanig türk filmi, bir kitaptan uyarlanmıştır?\nA-Yılanların öcü B-Selvi boylum al yazmalım\nC-Bizim aile D-Susuz yaz";

soru2[4] = "Soru 2-Nane, lavanta çiçeği, kekik ve biberiye gibi örnekleri olan bitki ailesinin adı nedir?\nA-Kahkahaçiçeğigiller B-Ebegümecigiller\nC-Ballıbabagiller D-Hanımeligiller";



Random rnd2 = new Random();
int rastgele2 = rnd2.Next(0, soru2.Length);
Console.WriteLine("" + soru2[rastgele2]);

Console.Write("Joker kullanmak ister misiniz? (E/H): ");
string joker2 = Console.ReadLine().ToUpper();

if (joker2 == "E")
{
    Console.WriteLine("Telefon Jokeri için 1'e, Yarı yarıya için 2'e, Seyirci hakkınız için 3'e basınız.");
    string cev2 = Console.ReadLine();
    switch (cev2)
    {
        case "1":
            if (telefon == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ali Veli Aranıyor...");
                Console.WriteLine("Ali Veli: Bence Cevap A");
            }


            telefon = false;
            Console.WriteLine("Son kararınız nedir?:");
            cev2 = Console.ReadLine();
            break;

        case "2":
            if (yariyariya == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("CEVAP A ya da D değil");

            }
            Console.WriteLine("Son kararınız nedir?:");
            yariyariya = false;
            cev2 = Console.ReadLine();
            break;


        case "3":
            if (seyirci == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seyircilerin Cevapları:" + " " + "%10A" + " " + "%10B" + " " + "%60C" + " " + "%20D");

            }
            Console.WriteLine("Evet son kararınız nedir?:");
            seyirci = false;
            cev2 = Console.ReadLine();
            break;



    }

    switch (cev2)
    {

        case "C":
            Para += 7500;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }

}

else
{
    Console.WriteLine("joker hakkınızı kullanmadınız, cevabınızı yazınız.");
    string cev2 = Console.ReadLine();
    switch (cev2)
    {

        case "C":
            Para += 7500;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }
}



Console.WriteLine();
Console.WriteLine();
string s2 = Console.ReadLine();
if (s2 == "EVET" || s2 == "evet")
{

    Console.WriteLine("Yarışmadan Çekildiniz Kazancınız " + Para + "TL");
    Environment.Exit(0);
}


Console.ReadLine();

//RANDOM SORU 3 İÇİN

string[] soru3 = new string[5];
soru3[0] = "Soru 3-2007'de bir garaj satışında 3 dolara satın alınan ve bin yıllık olduğu anlaşılıp, 2013'te açık artırmada 2.225.000 dolara satılan eşya hangisidir?\nA-Kase B-Zar \nC-Anahtar D-Şamdan";

soru3[1] = "Soru 3-11 yalında ki ciro ortiz, Newyork Bedford metrosunda, pazar günleri saat 12 ile 14 arasında, 5 dakikalığına 2 dolar alarak hangi hizmeti vermektedir?\nA-Turist Rehberliği B-Ses Eğitmenliği\nC-Fizik tedavi D-Psikolojik danışmanlık";

soru3[2] = "Soru 3-ABD Başkanlarının besledikleri hayvanlar arasında hangileri yoktur? \nA-Muhabbet kuşu B-Sırtlan \nC-Su Aygırı D-Zürafa";

soru3[3] = "Soru 3-İtalyancadan Türkçeye geçen tavla kelimesinin kökeninin anlamı nedir?\nA-Şans  B-Pul\nC-Zar D-Tahta";

soru3[4] = "Soru 3-\"Ağrıdağı'nın yamacında 4200 metrede bir göl vardır...\"cümlesiyle başlayan \"Ağrıdağı Efsanesi\" kitabının yazarı kimdir?\nA-Kemal Tahir B-Orhan Kemal\nC-Fakir Bayburt D-Yaşar Kemal";


Random rnd3 = new Random();
int rastgele3 = rnd3.Next(0, soru3.Length);
Console.WriteLine("" + soru3[rastgele3]);

Console.Write("Joker kullanmak ister misiniz? (E/H): ");
string joker3 = Console.ReadLine().ToUpper();

if (joker3 == "E")
{
    Console.WriteLine("Telefon Jokeri için 1'e, Yarı yarıya için 2'e, Seyirci hakkınız için 3'e basınız.");
    string cev3 = Console.ReadLine();
    switch (cev3)
    {
        case "1":
            if (telefon == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev3 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ali Veli Aranıyor...");
                Console.WriteLine("Ali Veli:Cevabın D olduğunu düşünüyorum.");
            }


            telefon = false;
            Console.WriteLine("Son kararınız nedir?:");
            cev3 = Console.ReadLine();
            break;

        case "2":
            if (yariyariya == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev3 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("CEVAP B ya da C DEĞİL");

            }
            Console.WriteLine("Son kararınız nedir?:");
            yariyariya = false;
            cev3 = Console.ReadLine();
            break;


        case "3":
            if (seyirci == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev3 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seyircilerin Cevapları:" + " " + "%10A" + " " + "%20B" + " " + "%10C" + " " + "%60D");

            }
            Console.WriteLine("Evet son kararınız nedir?:");
            seyirci = false;
            cev3 = Console.ReadLine();
            break;



    }

    switch (cev3)
    {

        case "D":
            Para += 15000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }

}

else
{
    Console.WriteLine("joker hakkınızı kullanmadınız, cevabınızı yazınız.");
    string cev3 = Console.ReadLine();
    switch (cev3)
    {

        case "D":
            Para += 5000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }
}



Console.WriteLine();
Console.WriteLine();
string s3 = Console.ReadLine();
if (s3 == "EVET" || s3 == "evet")
{

    Console.WriteLine("Yarışmadan Çekildiniz Kazancınız " + Para + "TL");
    Environment.Exit(0);
}

//RANDOM SORU 4 İÇİN

string[] soru4 = new string[5];
soru4[0] = "Soru 4-Başta Kanada olmak üzere 17. ve 18. yüzyıllarda birçok Fransız kolonisinde hangisi para olarak kullanılmıştır?\nA-Posta pulu B-İskambil Kağıdı \nC-Bitki Tohumu D-Cam Boncuk";

soru4[1] = "Soru 4-Filmlerde \"Yarısı Şimdi yarısı iş bittikten sonra\"sözüyle genellikle hangisinden bahsedilir?\nA-Onur Belgesi B-Para \nC-Elma Şekeri D-Dükkan Tapusu";

soru4[2] = "Soru 4-Rönesans döneminde popüler olan fresk resim tekniği çoğunlukla hangi zemin üzerinde uyarlanırdı?\nA-Kumaş B-Duvar \nC-Kağıt D-Cam";

soru4[3] = "Soru 4-Havadaki duman, is, koku ve yabancı maddeleri emerek dışarıya atan aygıta ne ad verilir?\nA-Regülatör B-Aspiratör\nC-Kompresör D-Transistör";

soru4[4] = "Soru 4-Kardan adamın gözlerini yapmak için genellikle ne kullanılır?\nA-Çikolata B-Kömür \nC-Ceviz D-Havuç";

Random rnd4 = new Random();
int rastgele4 = rnd4.Next(0, soru4.Length);
Console.WriteLine("" + soru4[rastgele4]);

Console.Write("Joker kullanmak ister misiniz? (E/H): ");
string joker4 = Console.ReadLine().ToUpper();

if (joker4 == "E")
{
    Console.WriteLine("Telefon Jokeri için 1'e, Yarı yarıya için 2'e, Seyirci hakkınız için 3'e basınız.");
    string cev4 = Console.ReadLine();
    switch (cev4)
    {
        case "1":
            if (telefon == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev4 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ali Veli Aranıyor...");
                Console.WriteLine("Ali Veli:Cevabın B olacağını Düşünüyorum");
            }


            telefon = false;
            Console.WriteLine("Son kararınız nedir?:");
            cev4 = Console.ReadLine();
            break;

        case "2":
            if (yariyariya == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev4 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("CEVAP C ya da D değil");

            }
            Console.WriteLine("Son kararınız nedir?:");
            yariyariya = false;
            cev4 = Console.ReadLine();
            break;


        case "3":
            if (seyirci == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev4 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seyircilerin Cevapları:" + " " + "%10A" + " " + "%50B" + " " + "%20C" + " " + "%20D");

            }
            Console.WriteLine("Son kararınız nedir?:");
            seyirci = false;
            cev4 = Console.ReadLine();
            break;



    }

    switch (cev4)
    {

        case "B":
            Para += 50000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }

}

else
{
    Console.WriteLine("joker hakkınızı kullanmadınız, cevabınızı yazınız.");
    string cev4 = Console.ReadLine();
    switch (cev4)
    {

        case "B":
            Para += 25000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor Hazır Ol!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }
}



Console.WriteLine();
Console.WriteLine();
string s4 = Console.ReadLine();
if (s4 == "EVET" || s4 == "evet")
{

    Console.WriteLine("Yarışmadan Çekildiniz Kazancınız " + Para + "TL");
    Environment.Exit(0);
}
//RANDOM SORU 5 İÇİN

string[] soru5 = new string[5];
soru5[0] = "Soru 5-Çocuklar masaya çarpıp ağlamaya başladıklarında, anne ve babalar teselli etmek için ne yaparlar?\nA-Masayı azarlayıp döverler B-Masayı sevip okşar \nC-Masayı evden kovarlar D-Masayı odaya hapsederler";

soru5[1] = "Soru 5-Türkiye'de bir eserin telif hakkı koruma süresi sahibinin ölümünden sonra kaç yıldır?\nA-70 B-30\nC-90 D-100";

soru5[2] = "Soru 5-ABD Başkanının içinde bulunduğu uçak\"Air Force One\"adını alırken, başkan hangi araca bindiğinde o aracın adı \"Marine One\" olur?\nA-Helikopter B-Otobüs\nC-Uçak Gemisi D-Denizaltı";

soru5[3] = "Soru 5-Eskiden aşure yerken hangisinin ilk ağıza geleni çıkarılarak yıkanıp, bereket getirdiğine inanıldığından para kesesine atılırdı?\nA-Bakla B-Nohut\nC-Fındık D-Nar";

soru5[4] = "Soru 5-\"The Godfather\"'da, belirtilmemesine rağmen Vito Corleone'nin oğlu Sonny'nin ölüm tarihinin 3 Ekim 1951 olduğunu iddia eden hayranları bunu hangisine dayandırır?\nA-Radyoda ki maç yayını B-Gişe duvarında ki takvim\nC-TV'deki haber bülteni D-Arabada ki gazetenin manşeti";

Random rnd5 = new Random();
int rastgele5 = rnd5.Next(0, soru5.Length);
Console.WriteLine("" + soru5[rastgele5]);

Console.Write("Joker kullanmak ister misiniz? (E/H): ");
string joker5 = Console.ReadLine().ToUpper();

if (joker5 == "E")
{
    Console.WriteLine("Telefon Jokeri için 1'e, Yarı yarıya için 2'e, Seyirci hakkınız için 3'e basınız.");
    string cev5 = Console.ReadLine();
    switch (cev5)
    {
        case "1":
            if (telefon == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev5 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ali Veli Aranıyor...");
                Console.WriteLine("Ali Veli: Bence Cevap A");
            }


            telefon = false;
            Console.WriteLine("Son kararınız nedir?:");
            cev5 = Console.ReadLine();
            break;

        case "2":
            if (yariyariya == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev5 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("CEVAP B ya da D değil");

            }
            Console.WriteLine("Son kararınız nedir?:");
            yariyariya = false;
            cev5 = Console.ReadLine();
            break;


        case "3":
            if (seyirci == false)
            {
                Console.WriteLine("Joker Hakkınız Bitmiştir");
                cev5 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seyircilerin Cevapları:" + " " + "%40A" + " " + "%30B" + " " + "%10C" + " " + "%20D");

            }
            Console.WriteLine("Evet son kararınız nedir?:");
            seyirci = false;
            cev5 = Console.ReadLine();
            break;



    }

    switch (cev5)
    {

        case "A":
            Para += 5000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("Yarışmadan çekilmek istiyor musunuz?");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }

}

else
{
    Console.WriteLine("joker hakkınızı kullanmadınız, cevabınızı yazınız.");
    string cev5 = Console.ReadLine();
    switch (cev5)
    {

        case "A":
            Para += 5000;
            Console.WriteLine("Tebrikler Cevabınız Doğru Kazancınız" + " " + Para + "TL");
            Console.WriteLine();
            Console.WriteLine("Sıradaki Soru Geliyor!");
            Console.WriteLine();
            Console.WriteLine("TEBRİKLERRR YARIŞMAYI BAŞARIYLA TAMAMLADINIZ VE ARTIK BİR MİLYONERSİNİZ");
            break;

        default:
            Console.WriteLine("Cevabınız Yanlış Kazancınız = " + Para + "TL");
            Environment.Exit(0);
            break;

    }
}



Console.WriteLine();
Console.WriteLine();
string s5 = Console.ReadLine();
if (s5 == "EVET" || s5 == "evet")
{

    Console.WriteLine("Yarışmadan Çekildiniz Kazancınız " + Para + "TL");
    Environment.Exit(0);
}