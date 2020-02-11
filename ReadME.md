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
* Booking
* CustomerBooking
* Customer
* Employee
* Room
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
<h4> NOT:ProjectContext isminin sonundaki "[Copy(Kopyası)]" yazısını silin ve projeye dahil edin.</h4>
<h4> NOT:ProjectContext SQL Server bağlatı ayarlarınızı verin (TODOLARI OKUYUN!!!)</h4>

* SampleData: Örnek verilerimizin bulunduğu classtır.
#### 2.5 - Migrations
* Configuration içerisine 2.4 Context içerisinde yer alan SampleData instece alınarak Seed metotun içerisine verilmiştir.
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
<h4> NOT:MailSender isminin sonundaki "[Copy(Kopyası)]" yazısını silin ve projeye dahil edin.</h4>
<h4> NOT:MailSender: E-Posta SMTP Servis gönderim ayarlarınızı verin (TODOLARI OKUYUN!!!)</h4>

### 6 - MVC_BilgeHotel.API

