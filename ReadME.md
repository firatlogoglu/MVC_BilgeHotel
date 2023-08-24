# Bilge Hotel MVC Projesi

## Oluşturulan Katmanlar

### 1 - MVC_BilgeHotel.CORE
#### 1.1 - Entity
* IEntity: Tüm entitylerimizde yer alan ID'yi T tipine verdim, böylece dışardan herhangi bir tip alabilecek.
* CoreEntity: Tüm etitylerimizde yer alacak özellikler (Genel Durum vs.) tanımladım. Burda ID'yi Guid tipini verdim. Bu class ilk tetiklendiğinde otomatik olarak: Genel Durum(GenerelStatus) = Aktif. Oluşturma tarihi, Uuşturan kişinin çeşitli bilgileri burada otomatik olarak ctor metotuyla doldurulacak. 
* PersonEntity: Model katmanında yer alan Çalışan ve Müşterilerde bulunan ortak özellikler bulunur.
#### 1.2 - Enums
* GeneralStatus(Genel Durumlar): Aktif, Update ve Deleted. Enum listesi olarak tanımlanıp 1.1 Entity içerisindeki CoreEntity içerisine verilmiştir.
* Gender(Cinsiyet): Male(Erkek) ve Female(Kadın). Bu Enum listesi 1.1 Entity içerisindeki PersonEntitye verilmiştir.
#### 1.3 - Map
* CoreMap: CoreEntity içerisindeki özelliklere çeşitli isimledirmeler ve sınırlandırılmalar verilmiştir.
### 2 - MVC_BilgeHotel.MODEL
#### 2.1 - Entities
* 2.1.1 Booking
* 2.1.2 CustomerBooking
* 2.1.3 Customer
* 2.1.4 Employee
* 2.1.5 Room
* 2.1.6.1 VMs
* 2.1.6.1.1 RoomBookingVM
* 2.1.6.1.2 CustomerBookingsVM
#### 2.2 - Enums
* Roles
* RoomStatus
* RoomTypes
#### 2.3 - Map
* RoomMap:
* CustomerMap:
* EmployeeMap:
* BookingMap:
* CustomerBookingMap
#### 2.4 - Context
* ProjectContext: Context nesnemizdir.
* SampleData: Örnek verilerimizin bulunduğu classtır.
#### 2.5 - Migrations
* Configuration içerisine 2.4 Context içerisinde yer alan SampleData instance alınarak Seed metotun içerisine verilmiştir.
### 3 - MVC_BilgeHotel.SERVICE/BLL (İş Katmanı) 
#### 3.1 - Base
* BaseSerice: Tüm Etitylerde bulunan belli başlı CRUD ve Listeleme işlemleri tanımlanmıştır.
#### 3.2 - Options
* RoomService:
* EmployeeService:
* CustomerService:
* CustomerBookingService
* BookingService:
### 4 - MVC_BilgeHotel.WEBUI (Sunum Katmanı)
#### 4.1 - Giriş Sayfası - Controllers/Home
* Areasız(bölgesiz) olarak tanımlanmıştır. Home Controllerin içerisinde Index, About, Contact ve ManagerIndex isimli ActionResultlar bulunuyor. ManagerIndex Hotel personline ait olan Arealarda bulunun Login sayfalarına yönlerimesini yapar.
* Views içerisinde bulunan Home Controller'ına ait olan Viewler bulununur.
* Views içerisinde bulunan Shared klasörü içersinde bulunan: _Layout, Giriş sayfasının Layout'tıdır.
* Views içerisinde bulunan Shared klasörü içersinde bulunan: PartialViews klasörü içerisinde yer alan: _Footer ve _TopNavbar parçalı viewleri tüm arealarda ve areasız kısımda görülecek Footer ve Üst menüyü bu kısımda yer alır.

#### 4.2 - Areas (Alanlar)
* BookingC: 
* BooingManagement:
* HotelBooingManagement:

#### 4.3 - Filters
* AuthorizationFilters: Personel ve Müşterilere ait sayfaların giriş yapılmamaksızın girilmesini engellemek için fiterlar uygulanmıştır.

### 5 - MVC_BilgeHotel.COMMON
#### Tools/Araçlar
* ImagesUploader/Resim Yükleyicisi
* MailSender/E-Posta Göndericisi

### 6 - MVC_BilgeHotel.STATICMASSAGES
#### Error Messages
#### Information Messages
#### Successful Messages

### 7 - MVC_BilgeHotel.API (Sunum Katmanı)
#### Controllers
* HomeController: FullRoomsCustomers, O günkü odalarda kalan müşterileri XML formatında getirir.

## Çalıştırılmadan Önce Yapılacak Ayarlar
* 1.) MVC_BilgeHotel.WEBUI ve MVC_BilgeHotel.API ilk etapta başlangıç projeleri olarak ayarlanması gerekiyor: Çözüm Gezgini'de (Solution Explorer'da) <b>“Solution 'MVC_BilgeHotel'/Çözüm 'MVC_BilgeHotel' ”</b> e Sağ tıklayıp. <b>“Set StartUp Projects.../Başlangıç Projelarini Olarak Ayarla...”</b> ya tıklayın. <b>“Birden fazla başlangıç projesi:/Multiple startup projects”</b> seçin. Ardından <b>MVC_BilgeHotel.WEBUI</b> ve <b>MVC_BilgeHotel.API</b> projelerin <b>Action/Eylem</b> kısmına <b>Start/Başla</b> yapıp <b>“OK/Tamam”</b> a tıklayın.

* 2.) SQL Database Server'ın yolu varsayılan olarak ayarlıdır ("server=.;database=MVCBilgeHotelDB;uid=sa;pwd=123"). Bu yolu, MVC_BilgeHotel.MODEL/Context/ProjectContext.cs dosyası içerisinde değiştirebilirsiniz.

* 3.) NuGet Paket Konsol Yöneticisini kullanarak veritabanını basılması gerekiyor.  

* 4.) Bu programın e-posta gönderebilmesi (gönderici) için, MVC_BilgeHotel.COMMON/Tools/MailSender.cs dosyasının ayarlanması gerekiyor.

* 5.) SampleData içerisindeki veriler kullanıcaksa, sahte (fake) e-posta adreslerine, e-posta gönderecektir. Bu e-posta adresleri gerçek kişi/kurumlara ait olabilir. Bunu engellemek için, MVC_BilgeHotel.COMMON/Tools/MailSender.cs dosyası içerisindeki //email = ""; yorum satırından çıkarılıp, içerisine alcı e-posta adresi olarak kendi e-posta adresinizi eklemek zorundasınız.

* 6.) Proje, ilk kez çalıştırılmasında <b>"...\MVC_BilgeHotel\MVC_BilgeHotel.WEBUI\bin\roslyn\csc.exe' yolunun bir parçası bulunamadı."</b> hata verirse, <b> "bin" klasörünü silin.</b>

## Projedeki Eksik Yerler
* 1.) Kampanya ve paket işlemleri ve sayfaları tamamlanacak.

* 2.) Bilet(Ticket), Ödeme PDF/Yazdırma işlemleri ve sayfaları tamamlanacak.

* 3.) SpecialDays (Özel Günler) için, resim veya fotoğraf bulunacak.

* 4.) MVC_BilgeHotel.API tarafında güvenlik için Token tanımlaması yapılacak. 