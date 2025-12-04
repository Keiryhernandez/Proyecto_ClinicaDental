-- ==============================
-- CREAR BASE DE DATOS
-- ==============================
CREATE DATABASE ClinicaDental;
GO

USE ClinicaDental;
GO

-- ==============================
-- TABLA: Usuario
-- ==============================
CREATE TABLE Usuario (
    Id INT IDENTITY PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARBINARY(32) NOT NULL, -- SHA-256
    Rol VARCHAR(30) NOT NULL
);
GO

-- Usuario admin con contrase�a "1234" en SHA-256
INSERT INTO Usuario (Username, PasswordHash, Rol)
VALUES ('admin', HASHBYTES('SHA2_256', '1234'), 'Administrador');
GO

-- ==============================
-- TABLA: Paciente
-- ==============================
CREATE TABLE Paciente (
    Id INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    DUI VARCHAR(20) UNIQUE NOT NULL,
    Telefono VARCHAR(20),
    Direccion VARCHAR(200),
    FechaNacimiento DATE
);
GO

-- ==============================
-- TABLA: Dentista
-- ==============================
CREATE TABLE Dentista (
    Id INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Especialidad VARCHAR(100),
    Telefono VARCHAR(20)
);
GO

-- ==============================
-- TABLA: Recepcionista
-- ==============================
CREATE TABLE Recepcionista (
    Id INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20)
);
GO

-- ==============================
-- TABLA: Tratamiento
-- ==============================
CREATE TABLE Tratamiento (
    Id INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(300),
    Precio DECIMAL(10,2) NOT NULL
);
GO

-- ==============================
-- TABLA: Cita
-- ==============================
CREATE TABLE Cita (
    Id INT IDENTITY PRIMARY KEY,
    IdPaciente INT NOT NULL,
    IdDentista INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Motivo VARCHAR(300),

    CONSTRAINT FK_Cita_Paciente FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id),
    CONSTRAINT FK_Cita_Dentista FOREIGN KEY (IdDentista) REFERENCES Dentista(Id)
);
GO

-- ==============================
-- TABLA: HistoriaClinica
-- ==============================
CREATE TABLE HistoriaClinica (
    Id INT IDENTITY PRIMARY KEY,
    IdPaciente INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Diagnostico VARCHAR(300),
    TratamientoAplicado VARCHAR(300),

    CONSTRAINT FK_Historia_Paciente FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id)
);
GO

-- ==============================
-- TABLA: Factura
-- ==============================
CREATE TABLE Factura (
    Id INT IDENTITY PRIMARY KEY,
    IdPaciente INT NOT NULL,
    IdTratamiento INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Total DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Factura_Paciente FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id),
    CONSTRAINT FK_Factura_Tratamiento FOREIGN KEY (IdTratamiento) REFERENCES Tratamiento(Id)
);
GO

-- �ndices recomendados
CREATE INDEX IDX_Cita_Fecha ON Cita(Fecha);
CREATE INDEX IDX_Paciente_DUI ON Paciente(DUI);
