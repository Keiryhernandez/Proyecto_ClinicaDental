
-- Creación de la base de datos

CREATE DATABASE ClinicaDental;
GO

USE ClinicaDental;
GO

-- TABLA: Paciente

CREATE TABLE Paciente (
    Id_Paciente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Edad INT,
    Genero NVARCHAR(10),
    Telefono NVARCHAR(20),
    Direccion NVARCHAR(100),
    Correo NVARCHAR(100)
);
GO


-- TABLA: Dentista

CREATE TABLE Dentista (
    Id_Dentista INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Especialidad NVARCHAR(50),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);
GO

-- TABLA: Recepcionista

CREATE TABLE Recepcionista (
    Id_Recepcionista INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Telefono NVARCHAR(20),
    Turno NVARCHAR(20)
);
GO


-- TABLA: Cita

CREATE TABLE Cita (
    Id_Cita INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Motivo NVARCHAR(100),
    Estado NVARCHAR(20),
    Id_Paciente INT NOT NULL,
    Id_Dentista INT NOT NULL,
    Id_Recepcionista INT NOT NULL,
    CONSTRAINT FK_Cita_Paciente FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente),
    CONSTRAINT FK_Cita_Dentista FOREIGN KEY (Id_Dentista) REFERENCES Dentista(Id_Dentista),
    CONSTRAINT FK_Cita_Recepcionista FOREIGN KEY (Id_Recepcionista) REFERENCES Recepcionista(Id_Recepcionista)
);
GO


-- TABLA: Tratamiento

CREATE TABLE Tratamiento (
    Id_Tratamiento INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(100),
    Costo DECIMAL(10,2),
    Duracion NVARCHAR(50),
    Id_Cita INT NOT NULL,
    CONSTRAINT FK_Tratamiento_Cita FOREIGN KEY (Id_Cita) REFERENCES Cita(Id_Cita)
);
GO


-- TABLA: Factura

CREATE TABLE Factura (
    Id_Factura INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
    Monto_Total DECIMAL(10,2),
    Metodo_Pago NVARCHAR(50),
    Id_Paciente INT NOT NULL,
    Id_Tratamiento INT NOT NULL,
    CONSTRAINT FK_Factura_Paciente FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente),
    CONSTRAINT FK_Factura_Tratamiento FOREIGN KEY (Id_Tratamiento) REFERENCES Tratamiento(Id_Tratamiento)
);
GO


-- TABLA: Historia Clínica

CREATE TABLE Historia_Clinica (
    Id_Historia INT IDENTITY(1,1) PRIMARY KEY,
    Diagnostico NVARCHAR(200),
    Observaciones NVARCHAR(200),
    Id_Paciente INT NOT NULL,
    Id_Dentista INT NOT NULL,
    CONSTRAINT FK_Historia_Paciente FOREIGN KEY (Id_Paciente) REFERENCES Paciente(Id_Paciente),
    CONSTRAINT FK_Historia_Dentista FOREIGN KEY (Id_Dentista) REFERENCES Dentista(Id_Dentista)
);
GO

USE ClinicaDental;
GO

-- Tabla de usuarios
CREATE TABLE Usuario (
    Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARBINARY(32) NOT NULL, -- SHA-256 = 32 bytes
    Rol NVARCHAR(50) NULL,
    Id_Recepcionista INT NULL,
    CONSTRAINT FK_Usuario_Recepcionista FOREIGN KEY (Id_Recepcionista) REFERENCES Recepcionista(Id_Recepcionista)
);
GO

-- Insertar un usuario de ejemplo (contraseña: "clave123")
INSERT INTO Usuario (Username, PasswordHash, Rol)
VALUES (
  'admin',
  HASHBYTES('SHA2_256', CONVERT(VARCHAR(100), 'clave123')),
  'Administrador'
);
GO