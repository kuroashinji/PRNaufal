use DB_Mahasiswa_Soal
CREATE VIEW tampil AS(
SELECT Mahasiswa .Kode_Mahasiswa ,Mahasiswa .Nama_Mahasiswa ,Jurusan .Nama_Jurusan ,Agama .Deskripsi ,Dosen .Nama_Dosen ,Jurusan .Status_Jurusan 
FROM ((((Mahasiswa 
INNER JOIN Jurusan ON Mahasiswa.Kode_Jurusan =Jurusan .Kode_Jurusan) 
INNER JOIN Agama ON Mahasiswa .Kode_Agama =Agama .Kode_Agama ) 
INNER JOIN Dosen ON Jurusan .Kode_Jurusan =Dosen .Kode_Jurusan )
INNER JOIN Type_Dosen ON Dosen .Kode_Type_Dosen =Type_Dosen .Kode_Type_Dosen )
WHERE Nama_Mahasiswa LIKE '%Budi%');
SELECT * FROM tampil