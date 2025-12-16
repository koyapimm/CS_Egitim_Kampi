# C# Eğitim Kampı - Entity Framework Gezi Projesi

Bu proje, C# Eğitim Kampı kapsamında geliştirilen, **Entity Framework** altyapısını kullanarak MSSQL veritabanı ile etkileşime giren bir Tur/Gezi Yönetim Otomasyonudur.

## 🎯 Projenin Amacı

Proje; Rehber (Guide), Lokasyon (Location), Müşteri (Customer) ve Yönetici (Admin) tablolarından oluşan ilişkisel bir veritabanı mimarisi üzerinde CRUD işlemlerini ve gelişmiş veri sorgulamayı (LINQ) örneklendirmektedir.

## 🖼️ Proje Görselleri

### İstatistik Paneli (Dashboard)
Aşağıdaki panelde `Location` ve `Guide` tablolarından Entity Framework LINQ sorguları ile çekilen anlık veriler görüntülenmektedir:

<img width="1123" height="670" alt="Ekran görüntüsü 2025-12-16 182636" src="https://github.com/user-attachments/assets/a579e9dc-e75b-4861-8a26-9af716fcd690" />

> **Case Senaryosu:** Eğitim Kampı C# Gezi Projesi kapsamında, Entity Framework kullanılarak veritabanındaki `Location` ve `Guide` tabloları üzerinde veri analitiği yapılması hedeflenmektedir. `FrmStatistics` formu üzerinde; toplam lokasyon sayısı, ortalama tur kapasitesi, en pahalı tur, belirli bir rehberin tur sayısı ve bölgesel doluluk oranları gibi kritik metrikler dinamik olarak hesaplanıp son kullanıcıya sunulacaktır.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Veri Erişimi:** Entity Framework (Code First / Db First)
* **Veritabanı:** Microsoft SQL Server

## 📂 Veritabanı Yapısı

Proje şu an için aktif olarak aşağıdaki iki tablo üzerinde yoğunlaşmıştır:
1.  **Location:** Tur lokasyonu, şehir, ülke, kapasite ve fiyat bilgilerini tutar.
2.  **Guide:** Tur rehberlerinin isim ve iletişim bilgilerini tutar.
*(Customer ve Admin modülleri geliştirme aşamasındadır)*

## 🚀 Kurulum

1.  Projeyi klonlayın.
2.  `app.config` veya `Context` sınıfı içerisindeki `connection string` bilgisini kendi sunucunuza göre güncelleyin.
3.  Package Manager Console üzerinden `update-database` komutunu çalıştırarak veritabanını oluşturun.
4.  Projeyi başlatın.

---
*Bu proje koyapimm tarafından C# Eğitim Kampı için geliştirilmiştir.*
