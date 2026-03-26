# 🚚 Transp - Lojistik Yönetim Sistemi

ASP.NET Core MVC ile geliştirilmiş, MongoDB tabanlı full-stack **kargo takip ve lojistik yönetim platformu**.

---

## 🚀 Özellikler

### 🌐 Kullanıcı Tarafı

- Hero slider ile dinamik ana sayfa
- Lojistik hizmetlerin listelenmesi ve detay sayfaları
- Kargo maliyet hesaplama formu
- Takip numarasıyla anlık kargo sorgulama
- Sık sorulan sorular (FAQ) bölümü
- Müşteri yorumları ve referans markalar
- Galata Köprüsü konumlu interaktif harita ve iletişim bilgileri
- Proje portföyü ve "Nasıl Çalışır?" adımları

### 🛠️ Admin Paneli

- **Slider Yönetimi** — Hero slider içeriklerini ekleme, düzenleme, silme; aktif/pasif durumu takibi
- **Marka Yönetimi** — Anlaşmalı markaların logolarını ve bilgilerini yönetme
- **Hizmet Yönetimi** — Lojistik hizmet kartlarını CRUD işlemleriyle yönetme; görüntülenme istatistikleri
- **Hakkımızda Yönetimi** — Kurumsal içerikleri düzenleme; görüntülenme ve okuma oranı takibi
- **Proje Portföyü** — Tamamlanan projeleri aktif/pasif olarak yönetme
- **Müşteri Yorumları** — Yorum kartlarını, puan bilgilerini ve ortalama skoru yönetme
- **Nasıl Çalışır Adımları** — Süreç adımlarını sıralı ve görsel biçimde yönetme
- **Sık Sorulan Sorular** — FAQ veritabanını neon temalı özel arayüzle yönetme
- **Kargo Gönderi Yönetimi** — Tüm gönderileri takip numarasıyla listeleme, filtreleme, durum güncelleme
- **Kargo Hareketi Takibi** — Her gönderi için zaman çizelgesi tabanlı hareket geçmişi yönetimi

---

## 📌 Proje Detayları

### 🗄️ Veritabanı & Mimari

MongoDB üzerinde **Shipment**, **ShipmentTracking**, **Service**, **Slider**, **Brand**, **About**, **Portfolio**, **Testimonial**, **HowItWorks** ve **FAQ** koleksiyonları tasarlandı. Tüm veri akışı **DTO (Data Transfer Object)** katmanı üzerinden yönetildi — entity'ler hiçbir zaman doğrudan view'a taşınmadı. **AutoMapper** ile entity↔DTO dönüşümleri otomatikleştirildi. **Service Layer** ve **Interface** yapısıyla bağımlılıklar soyutlandı, test edilebilir ve sürdürülebilir bir mimari kuruldu.

### 📦 Kargo Gönderi Yönetimi

Admin panelinde tüm kargo gönderileri listelenir; **takip numarası, gönderici, alıcı, rota, oluşturma tarihi ve durum** bilgileriyle tablo görünümünde gösterilir. Üst kısımda **Toplam Gönderi, Teslim Edilen, Yolda ve Bu Hafta** istatistik kartları yer alır. Gönderiler **Tümü / Alındı / Yolda / Dağıtımda / Teslim Edildi** sekmesiyle filtrelenebilir; takip numarası, gönderici veya alıcıya göre **anlık arama** yapılabilir.

### 🗺️ Kargo Hareketi Takibi

Her gönderiye ait hareketler **zaman çizelgesi (timeline)** yapısıyla görüntülenir. Hareket başlığı, durum badge'i, konum, açıklama ve tarih bilgileri her adımda gösterilir. En son hareket **"En Son"** etiketi ile öne çıkarılır. Sağ panelde **Durum Özeti** bileşeni, her statüdeki hareket sayısını renkli noktalarla listeler. Hareketler düzenlenebilir ve silinebilir. Üst kısımda **Toplam Hareket, Son Durum, İlk Hareket ve Son Güncelleme** istatistik kartları yer alır.

### 🏷️ Marka & Hizmet Yönetimi

Markalar kart görünümünde listelenir; logo, isim, ID ve aktif/pasif durumu gösterilir. Hizmetler ise ikon, başlık ve açıklamayla yönetilir. Her iki modül için de **Toplam, Aktif, Pasif ve Toplam Görüntülenme** istatistikleri takip edilir. Filtre sistemiyle aktif ve pasif kayıtlar ayrı ayrı görüntülenebilir.

### 📝 İçerik Yönetimi

**Hakkımızda**, **Slider**, **Proje Portföyü**, **Nasıl Çalışır Adımları** ve **Müşteri Yorumları** modülleri birbirinden bağımsız özel arayüzlerle tasarlandı. Her modül kendi istatistik kartlarına, arama alanına ve filtre sistemine sahiptir. Örneğin Müşteri Yorumları modülünde **ortalama puan**, Hakkımızda modülünde **okuma oranı** ve **ortalama başlık uzunluğu** gibi özgün metrikler gösterilir.

### ❓ FAQ Yönetimi

Sık Sorulan Sorular modülü **neon/siber temalı** özel bir arayüzle tasarlandı. Sorular kart görünümünde listelenir; **Toplam, Aktif, Pasif ve Toplam Görüntülenme** metrikleri üst panelde gösterilir. Her soru için düzenleme ve silme işlemleri yapılabilir.

### 🎨 Arayüz & UX

Tüm admin sayfaları **Silva Admin Template**, **Bootstrap 5** ve **Bootstrap Icons** kullanılarak sıfırdan özelleştirildi. Her modül için tutarlı stat kartları, arama kutuları, filtre sekmeleri ve aksiyon butonları oluşturuldu. Kullanıcı tarafı ise **Transp** adıyla markalanmış kurumsal bir lojistik temasıyla tasarlandı; sarı-lacivert renk paleti, full-screen hero slider, animasyonlu sayaçlar ve Galata Köprüsü konumlu Google Maps entegrasyonu içerir.

---

## 🧰 Kullanılan Teknolojiler

| Teknoloji | Versiyon | Açıklama |
|-----------|----------|----------|
| ASP.NET Core MVC | 8.0 | Web framework |
| MongoDB.Driver | 3.7.0 | MongoDB bağlantısı |
| MongoDB.Bson | 3.7.0 | BSON serileştirme |
| AutoMapper | 12.0.1 | DTO ↔ Entity dönüşümü |
| AutoMapper.Extensions.DI | 12.0.1 | Dependency Injection entegrasyonu |
| Bootstrap Icons | 1.11.3 | UI ikonları |
| Silva Admin Template | — | Admin panel tasarımı |
| Google Maps Embed | — | İletişim sayfası haritası |

---

## 🖼️ Ekran Görüntüleri

### Kullanıcı Tarafı

#### Ana Sayfa 
![Default1](https://github.com/user-attachments/assets/b2b9e84d-0577-4524-b6f2-f180f47d10c5)

#### Hizmetlerimiz
![Defaul2](https://github.com/user-attachments/assets/8720a84b-d9ad-4905-a9f9-fee5e3db3534)

#### Hakkımızda
![Defaul3](https://github.com/user-attachments/assets/80b184dd-ee1b-45e9-b6dc-77ed3273f23c)

#### Nasıl Çalışıyoruz?
![Defaul4](https://github.com/user-attachments/assets/16112bd0-90dd-48bc-a22d-ca106cabf798)

#### Müşteri Yorumları
![Defaul5](https://github.com/user-attachments/assets/79d7274a-2099-4a7e-816e-00179fddbe0b)

#### Proje Portföyü
![Defaul6](https://github.com/user-attachments/assets/7751fff2-4e9a-469e-88fd-528376eb6ba5)

#### Sık Sorulan Sorular
![Defaul7](https://github.com/user-attachments/assets/14077d96-64a7-44e0-9422-7ee54fda3adc)

#### İstatistikler & Kargo Maliyet Hesaplama
![Defaul8](https://github.com/user-attachments/assets/06aaedb5-5602-42a0-9e43-0930dbe33059)

#### İletişim & Harita
![Defaul9](https://github.com/user-attachments/assets/1f0e0982-26ad-4ae9-82ea-a803d1467546)

#### Footer
![Default10](https://github.com/user-attachments/assets/61387ac3-1167-4bd2-bc84-faf05288959e)

---

### Admin Paneli

#### Slider Yönetimi
![AdminSlider](https://github.com/user-attachments/assets/430f0f69-df0b-4989-866c-0d3f42d32fd1)

#### Marka Yönetimi
![AdminMarka](https://github.com/user-attachments/assets/5beb384f-bcb7-499b-8dda-bdbfa704cf27)

#### Hizmet Yönetimi
![AdminService](https://github.com/user-attachments/assets/f68b9eca-eeb3-44b7-a2c6-bc55ae83bcde)

#### Hakkımızda Yönetimi
![AdminAbout](https://github.com/user-attachments/assets/6c2b2e8f-6e75-4041-9015-99bc9dd1af26)

#### Proje Portföyü
![AdminPortfolyo](https://github.com/user-attachments/assets/994610b5-78fa-44ad-b051-20201ca5f083)

#### Müşteri Yorumları
![AdminTestimonial](https://github.com/user-attachments/assets/7281c0c6-f950-4c13-9bcf-c2cad342c394)

#### Nasıl Çalışır Adımları
![AdminWhy](https://github.com/user-attachments/assets/38d1e876-ef72-4522-9cfd-b6d886fd7812)

#### FAQ Yönetimi
![AdminSorular](https://github.com/user-attachments/assets/79b426fa-9259-4840-8738-70e739b25ba0)

#### Kargo Gönderi Yönetimi
![AdminKargolar](https://github.com/user-attachments/assets/a9e2f396-e0dd-405c-a6b5-5d1e46e1b55f)

#### Kargo Hareketi Takibi
![AdminHareketler](https://github.com/user-attachments/assets/e98771a4-ce08-4562-9537-b8b931914aad)


## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.
