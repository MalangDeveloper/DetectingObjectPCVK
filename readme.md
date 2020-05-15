# Detecting Object PCVK
Detektsi Objek (Bangun Datar) dengan jarak dan derajat pada kamera

Metode perhitungan Blob digunakan untuk mendeteksi object dan warna seperti: 
	lingkaran berwarna merah
	persegi panjang
	segitiga lingkaran biru.

Proses metode ini sebagai berikut: 
1.	penyaringan warna dengan penyaringan Euclidean (R, G , B). 
2.	pemfilteran skala abu-abu berdasarkan gambar yang difilter warna.
3.	pemfilteran biner berdasarkan gambar tepi filter. 
4.	Sehingga dapat mendeteksi objek, jarak dari kamera.

@2020
