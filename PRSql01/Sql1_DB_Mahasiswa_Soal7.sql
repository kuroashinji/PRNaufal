USE DB_Mahasiswa_Soal
SELECT Nama_Mahasiswa, COUNT(*) FROM Nilai 
INNER JOIN Mahasiswa ON Nilai.Kode_Mahasiswa = Mahasiswa.Kode_Mahasiswa
GROUP BY Nama_Mahasiswa
HAVING COUNT(*) >=2;

