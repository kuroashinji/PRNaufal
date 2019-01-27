use DB_Mahasiswa_Soal
CREATE TABLE Agama(
id INT NOT NULL IDENTITY (1,1), 
Kode_Agama CHAR (5) NOT NULL, 
Deskripsi VARCHAR (20) NOT NULL, 
PRIMARY KEY (Kode_Agama)
);
CREATE TABLE Jurusan(
id INT NOT NULL IDENTITY (1,1), 
Kode_Jurusan CHAR (5) NOT NULL, 
Nama_Jurusan VARCHAR (50) NOT NULL, 
Status_Jurusan VARCHAR (100) NOT NULL, 
PRIMARY KEY (Kode_Jurusan)
);
CREATE TABLE Mahasiswa(
id INT NOT NULL IDENTITY (1,1), 
Kode_Mahasiswa CHAR (5) NOT NULL, 
Nama_Mahasiswa VARCHAR (100) NOT NULL, 
Alamat VARCHAR (200) NOT NULL, 
Kode_Agama CHAR (5) FOREIGN KEY REFERENCES Agama(Kode_Agama) NOT NULL,
Kode_Jurusan CHAR (5) FOREIGN KEY REFERENCES Jurusan(Kode_Jurusan) NOT NULL, 
PRIMARY KEY (Kode_Mahasiswa)
);
CREATE TABLE Ujian(
id INT NOT NULL IDENTITY (1,1), 
Kode_Ujian CHAR (5) NOT NULL, 
Nama_Ujian VARCHAR (50) NOT NULL, 
Status_Ujian VARCHAR (100) NOT NULL, 
PRIMARY KEY (Kode_Ujian)
);
CREATE TABLE Type_Dosen(
id INT NOT NULL IDENTITY (1,1), 
Kode_Type_Dosen CHAR (5) NOT NULL, 
Deskripsi VARCHAR (20) NOT NULL, 
PRIMARY KEY (Kode_Type_Dosen)
);
CREATE TABLE Dosen(
id INT NOT NULL IDENTITY (1,1), 
Kode_Dosen CHAR (5) NOT NULL, 
Nama_Dosen VARCHAR (100) NOT NULL, 
Kode_Jurusan CHAR (5) FOREIGN KEY REFERENCES Jurusan(Kode_Jurusan) NOT NULL, 
Kode_Type_Dosen CHAR (5) FOREIGN KEY REFERENCES Type_Dosen(Kode_Type_Dosen) NOT NULL,
PRIMARY KEY (Kode_Dosen)
);
CREATE TABLE Nilai(
id INT NOT NULL IDENTITY (1,1), 
Kode_Mahasiswa CHAR (5) FOREIGN KEY REFERENCES Mahasiswa(Kode_Mahasiswa)NOT NULL, 
Kode_Ujian CHAR (5) FOREIGN KEY REFERENCES Ujian(Kode_Ujian)NOT NULL, 
Nilai DECIMAL (8,2) NOT NULL,
PRIMARY KEY (id)
);
insert into Dosen values ('D001','Prof. Dr. Retno Wahyuningsih','J001','T002'),
('D002','Prof. Roy M. Sutikno','J002','T001'),
('D003','Prof. Hendri A. Verburgh','J003','T002'),
('D004','Prof. Risma Suparwata','J004','T002'),
('D005','Prof. Amir Sjarifuddin Madjid, MM, MA','J005','T001')
SELECT * FROM Dosen

insert into Nilai values ('M004','U001','90'),
('M001','U001','80'),
('M002','U003','85'),
('M004','U002','95'),
('M005','U005','70')
SELECT * FROM Nilai

insert into Type_Dosen values ('T001','Tetap'),
('T002','Honorer'),
('T003','Expertise')
SELECT * FROM Type_Dosen

insert into Mahasiswa values ('M001','Budi Gunawan','Jl. Mawar No 3 RT 05 Cicalengka, Bandung','A001','J001'),
('M002','Rinto Raharjo','Jl. Kebagusan No. 33 RT04 RW06 Bandung','A002','J002'),
('M003','Asep Saepudin','Jl. Sumatera No. 12 RT02 RW01, Ciamis','A001','J003'),
('M004','M. Hafif Isbullah','Jl. Jawa No 01 RT01 RW01, Jakarta Pusat','A001','J001'),
('M005','Cahyono','Jl. Niagara No. 54 RT01 RW09, Surabaya','A003','J002')
SELECT * FROM Mahasiswa

insert into Agama values ('A001','Islam'),
('A002','Kristen'),
('A003','Katolik'),
('A004','Hindu'),
('A005','Budha')
SELECT * FROM Agama

insert into Jurusan values ('J001','Teknik Informatika','Aktif'),
('J002','Management Informatika','Aktif'),
('J003','Sistem Informasi','Non Aktif'),
('J004','Sistem Komputer','Non Aktif'),
('J005','Komputer Akuntansi','Aktif')
SELECT * FROM Jurusan

insert into Ujian values ('U001','Algoritma','Aktif'),
('U002','Aljabar','Aktif'),
('U003','Statistika','Non Aktif'),
('U004','Etika Profesi','Non Aktif'),
('U005','Bahasa Inggris','Aktif')
SELECT * FROM Ujian
