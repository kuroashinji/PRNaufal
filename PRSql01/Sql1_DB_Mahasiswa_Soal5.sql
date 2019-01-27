USE DB_Mahasiswa_Soal
SELECT Nama_Mahasiswa, Status_Ujian, Nilai FROM Nilai 
INNER JOIN Mahasiswa ON Nilai.Kode_Mahasiswa = Mahasiswa.Kode_Mahasiswa
INNER JOIN Ujian ON Nilai.Kode_Ujian = Ujian.Kode_Ujian
WHERE (Status_Ujian = 'Aktif')
AND Nilai>80;