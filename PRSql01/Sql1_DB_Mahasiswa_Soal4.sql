USE DB_Mahasiswa_Soal
SELECT Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Deskripsi FROM Mahasiswa 
INNER JOIN Jurusan ON Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
INNER JOIN Agama ON Mahasiswa.Kode_Agama = Agama.Kode_Agama
WHERE Jurusan.Status_Jurusan = 'Non Aktif';