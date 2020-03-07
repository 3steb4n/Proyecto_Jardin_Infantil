-- select * from Usuarios;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
DROP DATABASE IF EXISTS JardinInfantil;

create database JardinInfantil;

use JardinInfantil;

GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop table Usuarios;


create table Usuarios (
    Id_Usuario int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Documento varchar(50) NOT NULL,
    Tipo_Documento varchar(50) NOT NULL CHECK (Tipo_Documento IN('CC', 'TI', 'P', 'DNI', 'CE')),
    Nombres varchar(50) NOT NULL,
    Apellidos varchar(50) NOT NULL,
    Direccion varchar(50) NOT NULL,
    Celular varchar(30) NOT NULL,
    Telefono varchar(30) NOT NULL,
    Correo_Electronico varchar(100) NOT NULL,
    Usuario_Clave varchar(100) NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '1900-01-01 00:00:00.000',
    Estado_Usuario varchar(2) NOT NULL CHECK (Estado_Usuario IN('A', 'I')),
	Estado_Clave varchar (2) NOT NULL CHECK (Estado_Clave IN('C','S')),
    Tipo_Usuario varchar(2) NOT NULL CHECK(Tipo_Usuario IN('D', 'A', 'S'))
);

INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('1031181586','CC','Diego Alejandro','Astaiza Borja','CRA 25 A # 32 A 76 SUR','3133717966','6941093','diego.astaiza@itac.co','qwerty','','','','','A','S','A');
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- DROP PROCEDURE ListarUsuarios

CREATE PROCEDURE ListarUsuarios
AS
SELECT         Id_Usuario [ID],
	     Documento [Documento],
	     Tipo_Documento [Tipo_Documento],
		 Nombres [Nombres],
		 Apellidos [Apellidos],
		 Direccion [Direccion],
		 Celular [Celular],
		 Telefono [Telefono],
		 Correo_Electronico [Correo_Electronico],
		 Usuario_Clave [Usuario_Clave],
	     Usuario_Creacion [Usuario_Creacion],
		 Fecha_Creacion [Fecha_Creacion],
		 Usuario_Modificacion [Usuario_Modificacion],
		 Fecha_Modificacion [Fecha_Modificacion],
		 Estado_Usuario [Estado_Usuario],
		 Estado_Clave [Estado_Clave],
		 Tipo_Usuario [Tipo_Usuario]

FROM Usuarios where Estado_Usuario = 'A';
GO

-- EXEC ListarUsuarios;
-- select  * from usuarios;
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
DROP PROCEDURE ListarUsuarioDocumento
EXEC ListarUsuarioDocumento '432';
CREATE PROCEDURE ListarUsuarioDocumento
@Documento varchar(50)
AS
SELECT  Id_Usuario [ID],
	    Documento [Documento],
	    Tipo_Documento [Tipo_Documento],
		Nombres [Nombres],
		Apellidos  [Apellidos],
		Direccion [Direccion],
		Celular [Celular],
		Telefono [Telefono],
		Correo_Electronico [Correo_Electronico],
	    Usuario_Creacion [Usuario_Creacion],
		Fecha_Creacion [Fecha_Creacion],
		Usuario_Modificacion [Usuario_Modificacion],
		Fecha_Modificacion [Fecha_Modificacion],
		Estado_Usuario [Estado_Usuario],
		Estado_Clave [Estado_Clave],
		Tipo_Usuario [Tipo_Usuario]

FROM Usuarios where Documento = @Documento AND Estado_Usuario = 'A';;
GO

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarUsuario
CREATE PROCEDURE registrarUsuario
   @Documento varchar(50),
   @Tipo_Documento varchar(50),
   @Nombres varchar(50),
   @Apellidos varchar(50),
   @Direccion varchar(50),
   @Celular varchar(30),
   @Telefono varchar(30),
   @Correo_Electronico varchar(100),
   @UsuarioClave varchar(100),
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @Estado_Usuario varchar(2),
   @Estado_Clave varchar(2),
   @Tipo_Usuario varchar(2)
   AS
   INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico,Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   (@Documento,@Tipo_Documento,@Nombres,@Apellidos,@Direccion,@Celular,@Telefono,@Correo_Electronico,@UsuarioClave,@UsuarioCreacion,@FechaCreacion,@Estado_Usuario,@Estado_Clave,@Tipo_Usuario);  
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarUsuario

CREATE PROCEDURE modificarUsuario
   @ID int,
   @Documento varchar(50),
   @Tipo_Documento varchar(50),
   @Nombres varchar(50),
   @Apellidos varchar(50),
   @Direccion varchar(50),
   @Celular varchar(30),
   @Telefono varchar(30),
   @Correo_Electronico varchar(100),
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
   @Estado_Usuario varchar(2),
   @Estado_Clave varchar(2),
   @Tipo_Usuario varchar(2)
   AS
  UPDATE Usuarios SET Documento=@Documento, Tipo_Documento=@Tipo_Documento, Nombres=@Nombres, Apellidos=@Apellidos, Direccion=@Direccion, Celular=@Celular, Telefono=@Telefono, Correo_Electronico=@Correo_Electronico, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion, Estado_Usuario=@Estado_Usuario, Estado_Clave=@Estado_Clave, Tipo_Usuario=@Tipo_Usuario where Id_Usuario=@ID;
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE eliminarUsuario
CREATE PROCEDURE eliminarUsuario
   @ID int
   AS
   UPDATE Usuarios set Estado_Usuario='I' where Id_Usuario=@ID;
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE IniciarSesion

CREATE PROCEDURE IniciarSesion
@Correo_Electronico varchar(50),
@Usuario_Clave varchar (100)
AS
SELECT  Id_Usuario [ID],
		Nombres [Nombres],
		Apellidos  [Apellidos],
		Estado_Usuario [Estado_Usuario],
		Estado_Clave [Estado_Clave],
		Tipo_Usuario [Tipo_Usuario]

FROM Usuarios where Correo_Electronico=@Correo_Electronico AND Usuario_Clave=@Usuario_Clave COLLATE Latin1_General_CS_AS;
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

























































create table Grados(
    Id_Grado int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Grado varchar(20) NOT NULL,
    Descripcion_Grado text,
    Usuario_Creacion varchar(30),
    Fecha_creacion datetime,
    Usuario_Modificacion varchar(30),
    Fecha_Modificacion datetime,
    Estado 
);

create table GRUPOS_GRADOS_ESCOLARES(
    ID_GRUPO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NOMBRE_GRUPO varchar(50) NOT NULL,
    DESCRIPCION_GRUPO text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ESTADO_GRUPO int NOT NULL CHECK(ESTADO_GRUPO IN ('1', '0')),
    ID_GRADO int
);

ALTER TABLE GRUPOS_GRADOS_ESCOLARES ADD FOREIGN KEY (ID_GRADO) REFERENCES GRADOS_ESCOLARES(ID_GRADO);






create table PERIODOS_ACADEMICOS (
    ID_PERIODO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NOMBRE_PERIODO varchar(20) NOT NULL,
    DESCRIPCION_PERIODO text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime
);

create table ESTUDIANTES(
    ID_ESTUDIANTE int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DOCUMENTO_ESTUDIANTE bigint NOT NULL,
    TIPO_DOCUMENTO varchar(20) NOT NULL CHECK (TIPO_DOCUMENTO IN('Registro Civil', 'Tarjeta de Identidad', 'DNI')),
    NOMBRE_ESTUDIANTE varchar(30) NOT NULL,
    APELLIDO_ESTUDIANTE varchar(30) NOT NULL,
    FECHA_NACIMIENTO date NOT NULL,
    RUTA_FOTO varchar(100),
    ACUDIENTE_NOMBRE varchar(50) NOT NULL,
    DIRECCION varchar(50) NOT NULL,
    GENERO_ESTUDIANTE varchar(20) NOT NULL CHECK(GENERO_ESTUDIANTE IN ('Masculino', 'Femenino')),
    TELEFONO_ESTUDIANTE varchar(10),
    CELULAR_ACUDIENTE varchar(20),
    EMAIL_ACUDIENTE varchar(100),
    OBSERVACION_ESTUDIANTE text NOT NULL,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ID_GRUPO int
);

ALTER TABLE ESTUDIANTES ADD FOREIGN KEY (ID_GRUPO) REFERENCES GRUPOS_GRADOS_ESCOLARES(ID_GRUPO);

create table MATERIAS_ACADEMICAS(
    ID_MATERIA int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NOMBRE_MATERIA varchar(30) NOT NULL,
    DESCRIPCION_MATERIA text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ESTADO_MATERIA int NOT NULL CHECK(ESTADO_MATERIA IN('1', '0')),
    NUMERO_HORAS_MAXIMO int NOT NULL
);

create table AREAS(
    ID_AREA int IDENTITY(1,1) NOT Null PRIMARY KEY,
    NOMBRE_AREA varchar(50) NOT NULL,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ESTADO_AREA int NOT NULL CHECK(ESTADO_AREA IN('1', '0'))
);

create table AREAS_MATERIAS_ACADEMICAS(
    ID_AREA int,
    ID_MATERIA int
);

ALTER TABLE AREAS_MATERIAS_ACADEMICAS ADD FOREIGN KEY (ID_AREA) REFERENCES AREAS(ID_AREA);
ALTER TABLE AREAS_MATERIAS_ACADEMICAS ADD FOREIGN KEY (ID_MATERIA) REFERENCES MATERIAS_ACADEMICAS(ID_MATERIA);

create table LOGROS_MATERIA(
    ID_LOGRO int IDENTITY(1,1) NOT NULL,
    NOMBRE_LOGRO varchar(50) NOT NULL,
    DESCRIPCION_LOGRO text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION  datetime NOT NULL, 
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ESTADO_LOGRO int NOT NULL CHECK(ESTADO_LOGRO IN('1', '0')),
    ID_MATERIA int
);

ALTER TABLE LOGROS_MATERIA ADD FOREIGN KEY (ID_MATERIA) REFERENCES MATERIAS_ACADEMICAS(ID_MATERIA);

create table MATERIAS_DOCENTES( 
    ID_MATERIA int,
    ID_USUARIO int
);

ALTER TABLE MATERIAS_DOCENTES ADD FOREIGN KEY (ID_MATERIA) REFERENCES MATERIAS_ACADEMICAS(ID_MATERIA);
ALTER TABLE MATERIAS_DOCENTES ADD FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO);

create table SALONES_ACADEMICOS(
    ID_SALON int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    COD_SALON int NOT NULL,
    DESCRIPCION_SALON text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ESTADO_SALON int NOT NULL CHECK(ESTADO_SALON IN('1', '0')),
);

create table CARGAS_ACADEMICAS(
    ID_CARGA int IDENTITY(1,1) NOT NULL,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    DIA_SEMANA date NOT NULL,
    BLOQUE varchar(10) NOT NULL CHECK(BLOQUE IN('7:00 AM - 8:00 AM', '8:00 AM - 9:00 AM', '9:00 AM - 10:00 AM', 
    '11:00 AM - 12:00 PM', '12:00 PM - 1:00 PM', '1:00 PM - 2:00 PM', '2:00 PM - 3:00 PM')),
    ID_GRUPO int,
    ID_MATERIA int,
    ID_SALON int,
    ID_USUARIO int
);

ALTER TABLE CARGAS_ACADEMICAS ADD FOREIGN KEY (ID_GRUPO) REFERENCES GRUPOS_GRADOS_ESCOLARES(ID_GRUPO);
ALTER TABLE CARGAS_ACADEMICAS ADD FOREIGN KEY (ID_MATERIA) REFERENCES MATERIAS_ACADEMICAS(ID_MATERIA);
ALTER TABLE CARGAS_ACADEMICAS ADD FOREIGN KEY (ID_SALON) REFERENCES SALONES_ACADEMICOS(ID_SALON);
ALTER TABLE CARGAS_ACADEMICAS ADD FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO);

create table NOTAS_ESTUDIANTES(
    ID_NOTA int IDENTITY (1,1) NOT NULL PRIMARY KEY,
    NOTA decimal (2,1) NOT NULL,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime,
    ID_USUARIO int,
    ID_ESTUDIANTE int,
    ID_MATERIA int,
    ID_PERIODO int
);

ALTER TABLE NOTAS_ESTUDIANTES ADD FOREIGN KEY (ID_USUARIO) REFERENCES USUARIOS(ID_USUARIO);
ALTER TABLE NOTAS_ESTUDIANTES ADD FOREIGN KEY (ID_ESTUDIANTE) REFERENCES ESTUDIANTES(ID_ESTUDIANTE);
ALTER TABLE NOTAS_ESTUDIANTES ADD FOREIGN KEY (ID_MATERIA) REFERENCES MATERIAS_ACADEMICAS(ID_MATERIA);
ALTER TABLE NOTAS_ESTUDIANTES ADD FOREIGN KEY (ID_PERIODO) REFERENCES PERIODOS_ACADEMICOS(ID_PERIODO);

create table PROMEDIOS_GENERALES(
    ID_PROMEDIO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PROMEDIO_GENERAL decimal (2,1) NOT NULL,
    ID_ESTUDIANTE int
);

ALTER TABLE PROMEDIOS_GENERALES ADD FOREIGN KEY (ID_ESTUDIANTE) REFERENCES ESTUDIANTES(ID_ESTUDIANTE);

create table CONCEPTOS_PAGOS(
    ID_CONCEPTO_PAGOS int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NOMBRE_CONCEPTO_PAGO varchar(50) NOT NULL,
    DESCRIPCION_CONCEPTO text,
    VALOR_CONCEPTO_PAGO decimal (18,2),
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    USUARIO_MODIFICACION varchar(30),
    FECHA_MODIFICACION datetime
);

create table PAGOS_REGISTRADOS(
    ID_PAGO_REGISTRADO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    VALOR_MONTO decimal(18,2),
    DESCRIPCION_PAGO text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime,
    ID_CONCEPTO_PAGOS int,
    ID_ESTUDIANTE int
);

ALTER TABLE PAGOS_REGISTRADOS ADD FOREIGN KEY (ID_CONCEPTO_PAGOS) REFERENCES CONCEPTOS_PAGOS(ID_CONCEPTO_PAGOS);
ALTER TABLE PAGOS_REGISTRADOS ADD FOREIGN KEY (ID_ESTUDIANTE) REFERENCES ESTUDIANTES(ID_ESTUDIANTE);

create table ABONOS_PAGOS(
    ID_ABONO_REGISTRADO int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TIPO_ABONO varchar(20) NOT NULL CHECK(TIPO_ABONO IN('Parcial', 'Completo')),
    VALOR_ABONADO decimal(18,2) NOT NULL,
    DESCRIPCION_ABONO text,
    USUARIO_CREACION varchar(30),
    FECHA_CREACION datetime NOT NULL,
    ID_PAGO_REGISTRADO int,
);

ALTER TABLE ABONOS_PAGOS ADD FOREIGN KEY (ID_PAGO_REGISTRADO) REFERENCES PAGOS_REGISTRADOS(ID_PAGO_REGISTRADO); 
 
 
 
 
 
use JardinInfantil

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
DROP PROCEDURE IF EXISTS verificarUsuario;
GO
CREATE PROCEDURE ValidarUsuario
   @Usuario varchar(30),
   @Clave varchar(100)
   AS
   SELECT
		 ISNULL (Tipo_Usuario,'') [Tipo_Usuario],
		 ISNULL (Nombre_Usuario,'') [Nombre_Usuario]
   FROM Usuarios WHERE Usuario_Login=@Usuario  AND Clave=@Clave;
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------------------------------------
 DROP PROCEDURE IF EXISTS inhabilitarUsuario;
 GO

CREATE PROCEDURE inhabilitarUsuario
   @documentoUsuario varchar(30)
   AS
   UPDATE USUARIOS
   SET ESTADO_USUARIO='INHABILITADO' 
   WHERE DOCUMENTO_USUARIO=@documentoUsuario
GO


use JardinInfantil registrarUsuario
DROP PROCEDURE IF EXISTS registrarUsuario;
GO

CREATE PROCEDURE registrarUsuario
   @DocumentoUsuario varchar(20),
   @TipoDocumento varchar(30),
   @NombreUsuario varchar(30),
   @ApellidoUsuario varchar(30),
   @DireccionUsuario varchar(50),
   @NumeroCelular varchar(20),
   @Telefono varchar(10),
   @Email varchar(100),
   @UsuarioLogin varchar(20),
   @UsuarioClave varchar(100),
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoUsuario varchar(20),
   @TipoUsuario varchar(20)
   AS
   INSERT INTO USUARIOS ("DOCUMENTO_USUARIO","TIPO_DOCUMENTO","NOMBRE_USUARIO","APELLIDO_USUARIO","DIRECCION"
   ,"NUMERO_CELULAR","TELEFONO","CORREO_ELECTRONICO","USUARIO_LOGIN","USUARIO_CLAVE","USUARIO_CREACION","FECHA_CREACION",
   "ESTADO_USUARIO", "TIPO_USUARIO") VALUES
   (@DocumentoUsuario, @TipoDocumento, @NombreUsuario, @ApellidoUsuario, @DireccionUsuario, @NumeroCelular, 
   @Telefono, @Email, @UsuarioLogin, @UsuarioClave, @UsuarioCreacion, @FechaCreacion, @EstadoUsuario, @TipoUsuario);
GO
