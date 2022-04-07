create table tbl_restoran_musteriler
(
RestoranMusteriIdPk int primary key identity(2,2),
RestoranMusteriAd varchar(100),
RestoranMusteriSoyad varchar(100),
RestoranMusteriTel varchar(11),
RestoranMusteriAdres varchar(100)
)

create table tbl_restoran_personeller
(
RestoranPersonelIdPk int primary key identity(3,3),
RestoranPersonelAd varchar(100),
RestoranPersonelSoyad varchar(100),
RestoranPersonelTel varchar(11),
RestoranPersonelBolum varchar(100)
)

create table tbl_restoran_menu_icerigi
(
RestoranMenuIcerigiIdPk int primary key identity(5,5),
RestoranMenuIcerigiAd varchar(100),
RestoranYemekFiyat varchar(100)
)

create table tbl_restoran_tedarikciler
(
RestoranTedarikciIdPk int primary key identity(7,7),
RestoranTedarikciAd varchar(100),
RestoranTedarikciSoyad varchar(100),
RestoranTedarikciTel varchar(11),
RestoranTedarikciAdres varchar(100)
)

create table tbl_restoran_rezervasyon_masalar
(
RestoranRezervasyonMasaIdPk int primary key identity(15,15),
RestoranRezervasyonMasaNo varchar(10),
RestoranRezervasyonYaptýranMusteriIdPk int foreign key references tbl_restoran_musteriler(RestoranMusteriIdPk),
RestoranRezervasyonYapanPersonelIdPk int foreign key references tbl_restoran_personeller(RestoranPersonelIdPk)
)

create table tbl_restoran_rezarvasyonlar
(
RestoranRezarvasyonIdPk int primary key identity(10,10),
RestoranRezarvasyonNumara varchar(100),
RestoranRezervasyonMasaIdFk int foreign key references tbl_restoran_rezervasyon_masalar(RestoranRezervasyonIdPk),
RestoranRezervasyonMenuIdFk int foreign key references tbl_restoran_menu_icerigi(RestoranMenuIcerigiIdPk),
RestoranRezervasyonSaat varchar(100)
)

create table tbl_restoran_stoklar
(
restoran_stok_id_PK int primary key identity(20,20),
restoran_stok_miktari decimal(10,10),
stokla_ilgilenen_tedarikci_id_FK int foreign key references tbl_restoran_tedarikciler(RestoranTedarikciIdPk)
)

create table tbl_restoran_menuler
(
RestoranMenuIdPk int primary key identity(25,25),
RestoranMenuIcerigiIdFk int foreign key references tbl_restoran_menu_icerigi(RestoranMenuIcerigiIdPk)
)