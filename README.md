
# 🌊 SeaGuard — Marine Waste Reporting & Education Platform

**Kelompok SeaGuard**  
Anggota 1: **Desi D Simamora** – 23/514990/TK/56564  
Anggota 2: **Fanisah** – 23/518614/TK/57120  
Anggota 3: **Hayunitya Edadwi Pratita** – 23/518670/TK/57134  

---

SeaGuard adalah aplikasi edukasi dan pelaporan sampah laut untuk komunitas nelayan, wisatawan, dan masyarakat pesisir.  
Dikembangkan sebagai solusi digital untuk meningkatkan kesadaran lingkungan serta menyediakan sistem pelaporan sampah laut yang terstruktur dan mudah digunakan.

---

## 📘 Class Diagram Aplikasi SeaGuard
Diagram berikut menggambarkan rancangan struktur class dalam aplikasi, lengkap dengan relasi, atribut, dan method:

<img width="533" alt="class-diagram" src="https://github.com/user-attachments/assets/b33a2442-08b3-491b-a769-369d4b6d8643" />

---

## 🗂️ ERD Aplikasi SeaGuard
ERD ini menggambarkan struktur database serta relasi antar tabel yang digunakan dalam aplikasi:

<img width="811" alt="erd-seaguard" src="https://github.com/user-attachments/assets/8d1adaf8-d79b-4adb-87bd-5a08f5148413" />

---

## ⭐ Fitur Utama

### 📝 1. Pelaporan Sampah Laut
- Input kategori sampah  
- Input lokasi (koordinat/area)  
- Form pelaporan sederhana  
- Data laporan tersimpan di database  

### 🔥 2. Heatmap
- Visualisasi lokasi laporan  
- Analisis sebaran sampah  
- Representasi hotspot sampah  

### 📚 3. Modul Edukasi
- Informasi dampak sampah laut  
- Konten edukasi untuk masyarakat  
- Materi ramah pengguna  

### 👤 4. Manajemen User
- Login & Registrasi  
- Profil user  
- Riwayat laporan  

### 📋 5. Daftar & Detail Laporan
- List laporan user  
- Detail laporan lengkap  
- Status laporan  

---

## 🧱 Arsitektur & Teknologi

### 🔹 Frontend / Aplikasi Desktop
- C#  
- .NET Framework  
- Windows Forms  

### 🔹 Backend & Database
- PostgreSQL (utama)  
- SQL Server (opsional)  
- Npgsql — library koneksi database  

### 🔹 Tools Pengembangan
- Visual Studio  
- Git & GitHub  

---

## ⚙️ Cara Instalasi

### 1️⃣ Clone Repository
```bash
git clone https://github.com/desidewantri/SeaGuard.git
````

### 2️⃣ Install Dependencies

Pastikan sudah terinstal:

* Visual Studio 2019 / 2022
* Workload: **.NET Desktop Development**
* PostgreSQL (bila menggunakan database asli)

---

## ▶️ Cara Menjalankan Aplikasi

1. Buka Visual Studio
2. Pilih **File → Open → Project/Solution**
3. Arahkan ke:

   ```
   SeaGuard-Database.sln
   ```
4. Klik kanan project → **Set as Startup Project**
5. Tekan **F5 / Start**

Aplikasi akan berjalan dalam mode Windows Forms.

---

## 🧪 Testing

Pengujian mencakup:

* Navigasi antar halaman
* Semua tombol dapat diklik dan berfungsi
* Input form laporan berjalan normal
* Data tersimpan ke database
* Menggunakan dummy data untuk simulasi

---

## 👥 Pembagian Peran Tim

### 👩‍🎨 Desi D Simamora — UI/UX & Visual Presentation

* Mendesain layout UI
* Menentukan gaya visual & aset
* Menyusun materi pendukung visual

### 👩‍💻 Fanisah — Application Logic & Navigation

* Mengembangkan alur navigasi aplikasi
* Mengimplementasikan event handler
* Menjamin flow aplikasi berjalan stabil

### 🛢️ Hayunitya Edadwi Pratita — Database Management

* Menyusun struktur database
* Membuat tabel dan relasi
* Menghubungkan form dengan database

---

## 📜 Lisensi

Repositori ini dibuat untuk keperluan tugas akademik.
Penggunaan di luar tujuan akademik tidak disarankan.

