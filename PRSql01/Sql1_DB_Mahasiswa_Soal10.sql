use DB_Mahasiswa_Soal
SELECT Mahasiswa.Kode_Mahasiswa, Mahasiswa.Nama_Mahasiswa, Nilai.Nilai 
FROM Nilai 
RIGHT JOIN Mahasiswa ON Nilai.Kode_Mahasiswa = Mahasiswa.Kode_Mahasiswa

ORDER BY Mahasiswa.Kode_Mahasiswa;