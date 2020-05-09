# NETFLIX PROJESI
## Programlama Lab - II Proje - III
 > #### Kodlayan:  Engin Yenice |  2020-05-09 15:08:34 Saturday


Bu projede sizden Netflix platformunu geliştirmeniz beklenmektedir. Netflix, uzun metrajlı filmler,
belgeseller, diziler, programlar, animeler izleme platformudur.
Amaç: Proje gerçekleştirimi ile beraber öğrencilerin veritabanı yönetim sistemlerinin yapısını
anlaması ve çözüm sağlayabilmesi amaçlanmaktadır.
Programlama Dili: C# veya Java dili kullanılarak, Masaüstü uygulaması olarak geliştirilecektir (Web
veya Mobil uygulama istenmemektedir).
Veritabanı Yönetim Sistemi: Ms Access, MySQL veya MsSQL kullanılarak gerçekleştirilecektir.
1. İsterler
Geliştirilen Netflix masaüstü uygulamanızda iki farklı arayüz bulunmalı:
● Kullanıcı giriş sayfası.
● Kullanıcı kayıt sayfası.
● Kullanıcın içerik arayabileceği ve izleyebileceği arayüz.
Not: Burada filmleri/dizileri vs. video olarak eklemeniz beklenmemektedir. Veritabanında
bulunan içeriklerin isimlerinin bulunması yeterli. İzleme seçeneği için izle butonu eklemeniz
yeterli önemli olan kullanıcının içeriği izlediği bilgisinin veritabanında tutulmasıdır.)
A. Arayüz İsterleri
a. Kullanıcı giriş sayfası
Kullanıcı sisteme girerken e-mail adresini ve şifresini kullanarak giriş yapabilecektir. Şifremi unuttum
kısmını eklemenize gerek yoktur.
b. Kullanıcı kayıt sayfası
Kullanıcı sistemde kayıtlı değilse (bunun kontrolü email adresi ile yapılacak), kayıt edilecek.
● Kayıt sırasında kullanıcıdan, 3 farklı program türü (Aksiyon, Belgesel, Bilim Kurgu ve
Fantastik Yapımlar, Bilim ve Doğa, Çocuk ve Aile, Dramalar, Gerilim, Komedi, Korku,
Romantizm) seçmesi istenecek ve türlere göre 2 şer tane en çok puan alan film (toplamda 6
film) listelenecek.
c. Kullanıcı yönetim sayfası
Sisteme giriş yaptıktan sonra kullanıcı:
1. İçerik arayabilecek (Film Adına ve Türe göre arama yapabilecek)
2. İçerik izleyebilecek. (Hatırlatma: Bu kısımda kontrol amaçlı olarak sadece izle butonu
eklemeniz yeterli önemli olan kullanıcının içeriği izlediği bilgisinin veritabanında
tutulmasıdır.)
3. Eğer kullanıcı dizi izliyorsa, uygulama kapansa dahi uygulamanın tekrar açılması durumunda
kullanıcı kaldığı yerden devam edebilmeli.
B. Veritabanı İsterleri
a. Tablolar
Veritabanında 5 adet tablo olması beklenmektedir. Primary Key ve Foreign Key alanlarını bulmanız
beklenmektedir.
Program Tablosu:
● Her Bir programın unique (eşsiz) bir belirleyicisi olmalı
● Her Bir programın adı olmalı
● Programın Tipi olmalı (Dizi veya Film).
● Programın türü olmalı. Bu bilgi Tür tablosundan gelmeli. Unutulmamalı ki bir Program birden
fazla türe (komedi, korku ve romantik vs. ) bir Tür de birden fazla programa ait olabilir. Tablo
dizaynında buna dikkat etmelisiniz.
● Programın kaç bölümlü olduğunu gösterecek Bölüm Sayısı niteliği bulunmalı. Film de bu
kısıma “1” yazılabilir.
● Programın uzunluğunu belirtmek için Program Uzunluğu niteliği olmalı.
Tür Tablosu:
● Her bir tür için unique (eşsiz) bir belirleyicisi olmalı
● Tür ün adı olmalı. (Aksiyon, Belgesel, Bilim Kurgu ve Fantastik Yapımlar, Bilim ve Doğa,
Çocuk ve Aile, Dramalar, Gerilim, Komedi, Korku, Romantizm)
Kullanıcı Tablosu:
● Her bir kullanıcının unique (eşsiz) bir belirleyicisi olmalı.
● Adı olmalı
● Email adresi olmalı
● Şifresi olmalı
● Doğum tarihi olmalı
KullanıcıProgram Tablosu: Bu tablo, Kullanıcı ve Program arasında olan çoka-çok ilişki vardır bu
sebeple doğrudan bağlantı kurulamaz bu tabloda anahtar niteliklerini sizin bulmanız beklenmektedir.
Anahtar niteliklerinden farklı olarak bu tabloda
● İzleme tarihi bulunmalı
● İzleme süresi bulunmalı
● Kullanıcının hangi bölümde kaldığını gösteren değer bulunmalı
● Kullanıcının 1-10 arasında verdiği puan değeri tutulmalı.
Eklemeniz gereken bir tablo daha bulunmaktadır. Bu tablo Program ile Tür arasındaki bağlantı
ilişkisinden oluşmaktadır. Tabloyu ve tabloda bulunan nitelikleri sizin bulmanız
beklenmektedir.
2. Ödev Teslimi
● Projenizde kullanacağınız metot isimleri, değişken isimleri, fonksiyon isimlerinin vb. anlamlı
bir şekilde verilmesi gerekmektedir. (anlamlı isimler seçmeniz kaynak kodunuzun
okunabilirliği açısından oldukça önemlidir.)
● Projenizin başka bilgisayar üzerinde çalıştığından emin olunuz. (özellikle dosya yolu
belirtirken full path vermekten kaçınınız).
● Proje kodunuza yorum satırları ile yanlarına açıklamalar yazabilirsiniz.
● Projenizde yaptığınız tüm detayları raporunuzda ayrıntılı bir şekilde anlatmanız
gerekmektedir. Proje raporunuza, projenizin çalışır şeklinin ekran görüntülerine yer vermeniz
ve açıklamaları yapmanız gerekmektedir.
● Proje raporunun proje teslim tarihinde proje ile birlikte sisteme yüklenmesi gerekmektedir.
● Rapor IEEE formatında (önceki yıllarda verilen formatta) en az 4 sayfa, akış diyagramı veya
yalancı kod içeren (yalancı kod kodunuzun tamamı değildir dikkat ediniz), özet, giriş, yöntem,
deneysel sonuçlar, sonuç ve kaynakça bölümünden oluşmalıdır. Raporda Veritabanı, varlık