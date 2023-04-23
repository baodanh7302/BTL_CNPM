Create database BookTicket

create table tripbus(
	tripidbus nvarchar(20) primary key,
	addressfr nvarchar(100),
	addressto nvarchar(100),
	price int
)


create table triptour(
	tripidtour nvarchar(20) primary key,
	addressfr nvarchar(100),
	addressto nvarchar(100),
	price int
)

insert into tripbus
	(tripidbus, addressfr, addressto, price)
values 
	('TB001', 'Hồ Chí Minh', 'Long An', 50000),
	('TB002', 'Hồ Chí Minh', 'Đồng Tháp', 130000),
	('TB003', 'Hồ Chí Minh', 'An Giang', 100000),
	('TB004', 'Hồ Chí Minh', 'Tiền Giang', 80000),
	('TB005', 'Hồ Chí Minh', 'Bình Định', 680000),
	('TB006', 'Hồ Chí Minh', 'Đà Lạt', 640000),
	('TB007', 'Hồ Chí Minh', 'Hà Nội', 1000000),
	('TB008', 'Hồ Chí Minh', 'Hà Giang', 1300000),
	('TB009', 'Hồ Chí Minh', 'Quảng Ngãi', 690000),
	('TB0010', 'Hồ Chí Minh', 'Cà Mau', 350000),
	('TB0011', 'Hồ Chí Minh', 'Đồng Nai', 30000),
	('TB0012', 'Hồ Chí Minh', 'Bình Thuận', 250000),
	('TB0013', 'Hồ Chí Minh', 'Bến Tre', 70000),
	('TB0014', 'Hồ Chí Minh', 'Vũng Tàu', 180000),
	('TB0015', 'Hồ Chí Minh', 'Ninh Thuận', 200000)
;

insert into triptour
	(tripidtour, addressfr, addressto, price)
values 
	('TT001', 'Hồ Chí Minh', 'Long An', 30000),
	('TT002', 'Hồ Chí Minh', 'Đồng Tháp', 100000),
	('TT003', 'Hồ Chí Minh', 'An Giang', 70000),
	('TT004', 'Hồ Chí Minh', 'Tiền Giang', 60000),
	('TT005', 'Hồ Chí Minh', 'Bình Định', 500000),
	('TT006', 'Hồ Chí Minh', 'Đà Lạt', 600000),
	('TT007', 'Hồ Chí Minh', 'Hà Nội', 800000),
	('TT008', 'Hồ Chí Minh', 'Hà Giang', 1000000),
	('TT009', 'Hồ Chí Minh', 'Quảng Ngãi', 650000),
	('TT0010', 'Hồ Chí Minh', 'Cà Mau', 330000),
	('TT0011', 'Hồ Chí Minh', 'Đồng Nai', 10000),
	('TT0012', 'Hồ Chí Minh', 'Bình Thuận', 200000),
	('TT0013', 'Hồ Chí Minh', 'Bến Tre', 40000),
	('TT0014', 'Hồ Chí Minh', 'Vũng Tàu', 160000),
	('TT0015', 'Hồ Chí Minh', 'Ninh Thuận', 150000)
;

drop table tripbus;
drop table triptour;