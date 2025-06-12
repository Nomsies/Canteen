-- DROP TABLE Account, MenuCategory, Menu;

CREATE TABLE Account(
	uid VARCHAR PRIMARY KEY,
	password VARCHAR NOT NULL
);

CREATE TABLE MenuCategory(
	id SERIAL PRIMARY KEY,
	category VARCHAR NOT NULL UNIQUE
);

CREATE TABLE Menu(
	"Id" SERIAL PRIMARY KEY,
	"Name" VARCHAR NOT NULL,
	"Price" INT NOT NULL,
	"ImageLocation" VARCHAR NOT NULL,
	categoryId INT NOT NULL REFERENCES MenuCategory(id)
);

INSERT INTO Account(uid, password) VALUES ('admin', 'admin123');
INSERT INTO MenuCategory(category) VALUES('food'), ('drink');
INSERT INTO menu("Name", "Price", "ImageLocation", categoryId)
VALUES 
('Nasi Pecel', 	7000, 'Default.jpg', 1),
('Ayam Geprek',	10000,'Default.jpg', 1),
('Mie Ayam',	8000, 'Default.jpg', 1),
('Soto Ayam',	7000, 'Default.jpg', 1),
('Nasi Rawon',	7000, 'Default.jpg', 1),
('Es Teh',		3000, 'Default.jpg', 2),
('Teh Hangat',	3000, 'Default.jpg', 2),
('AQUA 600mL',	3000, 'Default.jpg', 2),
('Es Lumut',	3000, 'Default.jpg', 2),
('Lemon 450mL', 4000, 'Default.jpg', 2);

CREATE TABLE transaction(
	"Id" SERIAL PRIMARY KEY,
	"Date" DATETIME
);

-- SELECT * FROM menu