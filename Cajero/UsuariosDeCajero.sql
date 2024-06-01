CREATE DATABASE Usuarios;

use Usuarios;

CREATE TABLE Users(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(30) NOT NULL,
	Apellido NVARCHAR(30) NOT NULL ,
	Nacimiento DATE NOT NULL, 
	DPI VARCHAR(50) NOT NULL, 
	Correo VARCHAR(50), 
	Telefono VARCHAR(50) NOT NULL,
	Usuario VARCHAR(30) NOT NULL,
	Contraseña VARCHAR(50) NOT NULL,
	Saldo DECIMAL(10, 2) NOT NULL,
	Banco VARCHAR(15) NOT NULL
	);

SELECT*FROM Users;

INSERT INTO Users(Nombre, Apellido, Nacimiento, DPI, Correo, Telefono, Usuario, Contraseña, Saldo, Banco)
VALUES(
	'Dylan', 'Rosales', '2001-07-18', 6273817290101, 'dylan.rosales9@gmail.com','(+502) 5569-6143', 'Dylan18', 'miContrasena7_$', 1500.00, 'BAC'
);

SELECT*FROM Users;
use Usuarios;

INSERT INTO Users(Nombre, Apellido, Nacimiento, DPI, Correo, Telefono, Usuario, Contraseña, Saldo, Banco)
VALUES(
	'Wilvin', 'Barahona', '2000-09-18', 3425162730101, 'wilvinisai@gmail.com','(+502) 3445-6778', 'Wilvin', 'miPassword92_$', 2000.00, 'Industrial'
);

DELETE FROM Users WHERE ID = 1002;

INSERT INTO Users(Nombre, Apellido, Nacimiento, DPI, Correo, Telefono, Usuario, Contraseña, Saldo, Banco)
VALUES(
	'Amanda', 'Rousselin', '2004-10-08', 2574839190101, 'rousselin@gmail.com','(+502) 5567-5647', 'Amanda', 'tobyContrasena92_$', 3000.00, 'BAM'
);

DELETE FROM Users WHERE ID = 2002;
SELECT*FROM Users;


DROP TABLE Users;


USE Users;
ADD Bloqueado BIT DEFAULT 0;
ADD UltimoRetiroFecha DATETIME NULL,
ADD TotalRetiroDiario DECIMAL(18, 2) NOT NULL DEFAULT 0;