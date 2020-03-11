-- select * from Usuarios;
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
DROP DATABASE IF EXISTS JardinInfantil;

create database JardinInfantil;
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
			VALUES   ('846468','CC','dawwdadw','wadwawa','dwadwwddaw','454334543','54534543','awdawdwadwad','+sjKDRWdiZGNbP6FCPluEbW3OKY=','1','2020-03-07 00:00:00.000','','','A','S','A');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('846468','CC','pruebadocente1','pruebadocente1','pruebadocente1','454334543','54534543','pruebadocente1','+sjKDRWdiZGNbP6FCPluEbW3OKY=','1','2020-03-07 00:00:00.000','','','A','S','D');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('846468','CC','pruebadocente2','pruebadocente2','pruebadocente2','454334543','54534543','pruebadocente2','+sjKDRWdiZGNbP6FCPluEbW3OKY=','1','2020-03-07 00:00:00.000','','','A','S','D');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('846468','CC','pruebadocente3','pruebadocente3','pruebadocente3','454334543','54534543','pruebadocente3','+sjKDRWdiZGNbP6FCPluEbW3OKY=','1','2020-03-07 00:00:00.000','','','A','S','D');

select * from usuarios;
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
-- DROP PROCEDURE ListarUsuarioDocumento
-- EXEC ListarUsuarioDocumento '432';
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

CREATE PROCEDURE ListarUsuariosIdNombre
AS
SELECT   Id_Usuario [ID],
		 Nombres [Nombres],
		 Apellidos [Apellidos]
		 
FROM Usuarios where Estado_Usuario = 'A' and Tipo_Usuario='D';
GO
EXEC ListarUsuariosIdNombre
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
-- drop table Grados;
create table Grados(
    Id_Grado int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Grado varchar(20) NOT NULL,
    Descripcion_Grado text,
    Usuario_Creacion varchar(30),
    Fecha_creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado varchar(2) NOT NULL CHECK (Estado IN('A', 'I'))
);

insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Parbulos','Competencia para ninos de 1 y 2 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('PreKinder','Competencia para ninos de 2 y 3 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Kinder','Competencia para ninos de 3 y 4 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Kinder','Competencia para ninos de 3 y 4 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Transacicion','Competencia para ninos de 4 y 5 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Primero','Competencia para ninos de 4 y 5 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
select * from Grados;


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE  ListarGrados
CREATE PROCEDURE ListarGrados
AS
SELECT  Id_Grado [idGrado],
		Nombre_Grado [NombreGrado]
		FROM Grados  where Estado = 'A';
GO

EXEC ListarGrados;

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- truncate table Grupos
-- select * from Grupos;
-- drop table Grupos;
create table Grupos(
    id_grupo int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre_grupo varchar(50) NOT NULL,
    descripcion_grupo text,
    usuario_creacion varchar(30),
    fecha_creacion datetime,
    usuario_modificacion varchar(30) NULL DEFAULT '',
    fecha_modificacion datetime NULL DEFAULT '2020-07-03 00:00:00.000',
    estado_grupo varchar(30) NOT NULL CHECK(estado_grupo IN ('A', 'I')),
    id_grado int,
	id_docente int
);

ALTER TABLE Grupos ADD FOREIGN KEY (id_grado) REFERENCES Grados(Id_Grado);
ALTER TABLE Grupos ADD FOREIGN KEY (id_docente) REFERENCES Usuarios(Id_Usuario);

insert into Grupos (nombre_grupo,descripcion_grupo,usuario_creacion,fecha_creacion,usuario_modificacion,fecha_modificacion,estado_grupo,id_grado,id_docente) values ('PK001','Primer curso de 20 estudiantes del  grado prekinder de la sede principal','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','3','2');
insert into Grupos (nombre_grupo,descripcion_grupo,usuario_creacion,fecha_creacion,usuario_modificacion,fecha_modificacion,estado_grupo,id_grado,id_docente) values ('PK002','Seg curso de 20 estudiantes del  grado prekinder de la sede principal','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','3','2');
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
select * from Grupos
-- DROP PROCEDURE  ListarGrupos
CREATE PROCEDURE ListarGrupos
AS
SELECT  g.id_grupo [IdGrupo],
		g.nombre_grupo [NombreGrupo],
		g.descripcion_grupo [DescripcionGrupo],
		g.usuario_creacion [UsuarioCreacion],
		g.fecha_creacion [FechaCreacion],
		g.usuario_modificacion [UsuarioModificacion],
		g.fecha_modificacion [FechaModificacion],
		g.estado_grupo [EstadoGrupo],
		gr.Id_Grado [IdGrado],
		gr.Nombre_Grado [NombreGrado],
		us.Id_Usuario[idUsuario],
		us.Nombres[Nombres],
		us.Apellidos[Apellidos]
		FROM Grupos g  INNER JOIN Grados gr ON g.id_grado = gr.Id_Grado INNER JOIN Usuarios us ON g.id_docente = us.Id_Usuario where g.estado_grupo = 'A';
GO

--EXEC ListarGrupos;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarGrupoPorNombre
CREATE PROCEDURE ListarGrupoPorNombre
@nombre_grupo varchar(50)
AS
SELECT  g.id_grupo [IdGrupo],
		g.nombre_grupo [NombreGrupo],
		g.descripcion_grupo [DescripcionGrupo],
		g.usuario_creacion [UsuarioCreacion],
		g.fecha_creacion [FechaCreacion],
		g.usuario_modificacion [UsuarioModificacion],
		g.fecha_modificacion [FechaModificacion],
		g.estado_grupo [EstadoGrupo],
		gr.Id_Grado [IdGrado],
		gr.Nombre_Grado [NombreGrado],
		us.Id_Usuario[idUsuario],
		us.Nombres[Nombres],
		us.Apellidos[Apellidos]
		FROM Grupos g  INNER JOIN Grados gr ON g.id_grado = gr.Id_Grado  INNER JOIN Usuarios us ON g.id_docente = us.Id_Usuario where g.nombre_grupo=@nombre_grupo and g.estado_grupo = 'A';
GO
EXEC ListarGrupoPorNombre 'PK001'
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- select * from Grupos
-- DROP PROCEDURE  ListarGruposNombreyID
CREATE PROCEDURE ListarGruposNombreyID
AS
SELECT  id_grupo [IdGrupo],
		nombre_grupo [NombreGrupo]
		
		FROM Grupos  where estado_grupo = 'A';
GO

EXEC ListarGruposNombreyID;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarGrupo
CREATE PROCEDURE registrarGrupo
   @NombreGrupo varchar(50),
   @DescripcionGrupo varchar(50),
   @UsuarioCreacion varchar(50),
   @FechaCreacion varchar(50),
   @EstadoGrupo varchar(30),
   @IdGrado varchar(100),
   @IdDocente int
   AS
   insert into Grupos (nombre_grupo,descripcion_grupo,usuario_creacion,fecha_creacion,estado_grupo,id_grado,id_docente)
   values (@NombreGrupo,@DescripcionGrupo,@UsuarioCreacion,@FechaCreacion,@EstadoGrupo,@IdGrado,@IdDocente);
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- use JardinInfantil;
-- DROP PROCEDURE modificarGrupo
CREATE PROCEDURE modificarGrupo
   @id_grupo int,
   @NombreGrupo varchar(50),
   @DescripcionGrupo varchar(50),
   @UsuarioModificacion varchar(50),
   @FechaModificacion varchar(30),
   @EstadoGrupo varchar(30),
   @IdGrado varchar(100),
   @IdDocente int
   AS
   update Grupos set nombre_grupo=@NombreGrupo, descripcion_grupo=@DescripcionGrupo, usuario_modificacion=@UsuarioModificacion, fecha_modificacion=@FechaModificacion, estado_grupo=@EstadoGrupo,id_grado=@IdGrado, id_docente=@IdDocente where id_grupo=@id_grupo;
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--DROP PROCEDURE eliminarGrupo
CREATE PROCEDURE eliminarGrupo
   @ID int
   AS
   UPDATE Grupos set estado_grupo='I' where id_grupo=@ID;
GO
-- use JardinInfantil
-- select * from grupos;

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop table Estudiantes
create table Estudiantes(
    ID_estudiante int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Documento_Estudiante varchar(40) NOT NULL,
    Tipo_Documento varchar(20) NOT NULL CHECK (Tipo_Documento IN('RC', 'TI', 'DNI')),
    Nombre_Estudiante varchar(30) NOT NULL,
    Apellido_Estudiante varchar(30) NOT NULL,
    Fecha_Nacimiento date NOT NULL,
    Ruta_foto varchar(100) NULL DEFAULT '',
    Acudiente_Nombre varchar(50) NOT NULL,
    Direccion varchar(50) NOT NULL,
    Genero_Estudiante varchar(20) NOT NULL CHECK(Genero_Estudiante IN ('M', 'F')),
    Telefono varchar(10),
    Celular varchar(20),
    Correo_Electronico varchar(100),
    Observaciones text NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime ,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
	Estado_Estudiante varchar (2) NOT NULL CHECK(Estado_Estudiante IN ('A', 'I')),
    ID_grupo int
);

ALTER TABLE Estudiantes ADD FOREIGN KEY (ID_grupo) REFERENCES Grupos(id_grupo);

INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante,ID_grupo) 
			VALUES   ('8548964684','RC','Manuel ','Castillo','2020-03-07 00:00:00.000','','Ivan Duque','KR 32 Norte','M','6941023','313371823','padre@misena.edu.co','estudiante 1 mi pez','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','1');  
			INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante,ID_grupo) 
			VALUES   ('54435435','RC','Manuela ','Castilla','2020-03-07 00:00:00.000','','Ivan Duque','KR 32 Norte','M','6941023','313371823','padre@misena.edu.co','estudiante 2 mi pez','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','2');  
select * from Estudiantes;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantes
CREATE PROCEDURE ListarEstudiantes
AS
SELECT   e.ID_estudiante [IdEstudiante],
	     e.Documento_Estudiante [DocumentoEstudiante],
	     e.Tipo_Documento [TipoDocumento],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Apellido_Estudiante [ApellidoEstudiante],
		 e.Fecha_Nacimiento [FechaNacimiento],
		 e.Ruta_foto [RutaFoto],
		 e.Acudiente_Nombre [AcudienteNombre],
		 e.Direccion [Direccion],
		 e.Genero_Estudiante [GeneroEstudiante],
	     e.Telefono [Telefono],
		 e.Celular [Celular],
		 e.Correo_Electronico [CorreoElectronico],
		 e.Observaciones [Observaciones],
		 e.Estado_Estudiante [EstadoEstudiante],
		 e.ID_grupo [IDgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Estudiantes e INNER JOIN Grupos gr ON gr.id_grupo = e.ID_grupo where gr.estado_grupo = 'A' AND e.Estado_Estudiante = 'A';
GO
EXEC ListarEstudiantes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantePorDocumento
CREATE PROCEDURE ListarEstudiantePorDocumento
@Documento varchar(40)
AS
SELECT   e.ID_estudiante [IdEstudiante],
	     e.Documento_Estudiante [DocumentoEstudiante],
	     e.Tipo_Documento [TipoDocumento],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Apellido_Estudiante [ApellidoEstudiante],
		 e.Fecha_Nacimiento [FechaNacimiento],
		 e.Ruta_foto [RutaFoto],
		 e.Acudiente_Nombre [AcudienteNombre],
		 e.Direccion [Direccion],
		 e.Genero_Estudiante [GeneroEstudiante],
	     e.Telefono [Telefono],
		 e.Celular [Celular],
		 e.Correo_Electronico [CorreoElectronico],
		 e.Observaciones [Observaciones],
		 e.Estado_Estudiante [EstadoEstudiante],
		 e.ID_grupo [IDgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Estudiantes e INNER JOIN Grupos gr ON gr.id_grupo = e.ID_grupo where gr.estado_grupo = 'A' AND e.Estado_Estudiante = 'A' AND Documento_Estudiante=@Documento;
GO
EXEC ListarEstudiantePorDocumento '8548964684'
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantePorDocumentoyGrupo
CREATE PROCEDURE ListarEstudiantePorDocumentoyGrupo
@Documento varchar(40),
@idGrupo int
AS
SELECT   e.ID_estudiante [IdEstudiante],
	     e.Documento_Estudiante [DocumentoEstudiante],
	     e.Tipo_Documento [TipoDocumento],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Apellido_Estudiante [ApellidoEstudiante],
		 e.Fecha_Nacimiento [FechaNacimiento],
		 e.Ruta_foto [RutaFoto],
		 e.Acudiente_Nombre [AcudienteNombre],
		 e.Direccion [Direccion],
		 e.Genero_Estudiante [GeneroEstudiante],
	     e.Telefono [Telefono],
		 e.Celular [Celular],
		 e.Correo_Electronico [CorreoElectronico],
		 e.Observaciones [Observaciones],
		 e.Estado_Estudiante [EstadoEstudiante],
		 e.ID_grupo [IDgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Estudiantes e INNER JOIN Grupos gr ON gr.id_grupo = e.ID_grupo where gr.estado_grupo = 'A' AND e.Estado_Estudiante = 'A'  and e.ID_grupo = @idGrupo and e.Documento_Estudiante LIKE '%'+@Documento+'%';
GO

EXEC ListarEstudiantePorDocumentoyGrupo '',1;
-- select * from Estudiantes;


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarEstudiante
CREATE PROCEDURE registrarEstudiante
   @DocumentoEstudiante varchar(40),
   @TipoDocumento varchar(20),
   @NombreEstudiante varchar(30),
   @ApellidoEstudiante varchar(30),
   @FechaNacimiento date,
   @RutaFoto varchar(100),
   @AcudienteNombre varchar(50),
   @Direccion varchar(50),
   @GeneroEstudiante varchar(20),
   @Telefono varchar(10),
   @Celular varchar(20),
   @CorreoElectronico varchar(100),
   @Observaciones text,
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoEstudiante varchar(2),
   @IDgrupo int
   AS
   INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Estado_Estudiante,ID_grupo) 
			VALUES   (@DocumentoEstudiante,@TipoDocumento,@NombreEstudiante,@ApellidoEstudiante,@FechaNacimiento,@RutaFoto,@AcudienteNombre,@Direccion,@GeneroEstudiante,@Telefono,@Celular,@CorreoElectronico,@Observaciones,@UsuarioCreacion,@FechaCreacion,@EstadoEstudiante,@IDgrupo);  
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarEstudiante
CREATE PROCEDURE modificarEstudiante
   @IDEstudiante int,
   @DocumentoEstudiante varchar(40),
   @TipoDocumento varchar(20),
   @NombreEstudiante varchar(30),
   @ApellidoEstudiante varchar(30),
   @FechaNacimiento date,
   @RutaFoto varchar(100),
   @AcudienteNombre varchar(50),
   @Direccion varchar(50),
   @GeneroEstudiante varchar(20),
   @Telefono varchar(10),
   @Celular varchar(20),
   @CorreoElectronico varchar(100),
   @Observaciones text,
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
   @IdGrupo int
   AS
   UPDATE Estudiantes SET Documento_Estudiante=@DocumentoEstudiante, Tipo_Documento=@TipoDocumento, Nombre_Estudiante=@NombreEstudiante, Apellido_Estudiante=@ApellidoEstudiante, Fecha_Nacimiento=@FechaNacimiento, Ruta_foto=@RutaFoto, Acudiente_Nombre=@AcudienteNombre, Direccion=@Direccion, Genero_Estudiante=@GeneroEstudiante, Telefono=@Telefono,  Celular=@Celular, Correo_Electronico=@CorreoElectronico, Observaciones=@Observaciones, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion, ID_grupo=@IdGrupo where ID_estudiante=@IDEstudiante;
GO
use JardinInfantil
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--DROP PROCEDURE eliminarEstudiante
CREATE PROCEDURE eliminarEstudiante
   @ID int
   AS
   UPDATE Estudiantes set Estado_Estudiante='I' where ID_estudiante=@ID;
GO
-- use JardinInfantil
-- select * from grados;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Periodos (
    Id_periodo int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Periodo varchar(20) NOT NULL,
    Descripcion_Periodo text,
    Usuario_Cracion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000'
);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- DROP PROCEDURE  ListarPeriodos
CREATE PROCEDURE ListarPeriodos
AS
SELECT  Id_periodo [IdPeriodo],
		Nombre_Periodo [NombreArea]
		FROM Periodos;
GO

EXEC ListarPeriodos;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Areas(
    Id_Area int IDENTITY(1,1) NOT Null PRIMARY KEY,
    Nombre varchar(50) NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado varchar(2) NOT NULL CHECK(Estado IN('A', 'I'))
);

insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Tecnologica','1','2020-03-07 00:00:00.000','A');
insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Ciencias','1','2020-03-07 00:00:00.000','A');
insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Sociales','1','2020-03-07 00:00:00.000','A');
-- select * from Areas;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE  ListarAreas
CREATE PROCEDURE ListarAreas
AS
SELECT  Id_Area [IdArea],
		Nombre [NombreArea]
		FROM Areas  where Estado = 'A';
GO

EXEC ListarAreas;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--drop table Materias;
create table Materias(
    Id_Materia int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nomre_Materia varchar(30) NOT NULL,
    Descripcion_Materia text,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado_Materia  varchar(2) NOT NULL CHECK(Estado_Materia IN('A', 'I')),
    Numero_Horas int NOT NULL,
	Id_Area int,
	Id_Grado int
);

ALTER TABLE Materias ADD FOREIGN KEY (Id_Area) REFERENCES Areas(Id_Area);
ALTER TABLE Materias ADD FOREIGN KEY (Id_Grado) REFERENCES Grados(Id_Grado);

insert into Materias (Nomre_Materia,Descripcion_Materia,Usuario_Creacion,Fecha_Creacion,Estado_Materia,Numero_Horas,Id_Area,Id_Grado) VALUES ('Matematicas','Matematicas para ninos','1','2020-03-07 00:00:00.000','A','10','1','2');
insert into Materias (Nomre_Materia,Descripcion_Materia,Usuario_Creacion,Fecha_Creacion,Estado_Materia,Numero_Horas,Id_Area,Id_Grado) VALUES ('Sociales','Sociales para ninos','1','2020-03-07 00:00:00.000','A','10','1','2');
-- select * from Grados;
-- select * from materias;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarMaterias
CREATE PROCEDURE ListarMaterias
AS
SELECT   m.Id_Materia [IdMateria],
	     m.Nomre_Materia [NomreMateria],
	     m.Descripcion_Materia [DescripcionMateria],
		 m.Estado_Materia [EstadoMateria],
		 m.Numero_Horas [NumeroHoras],
		 a.Id_Area [IdArea],
		 a.Nombre [NombreArea],
		 g.Id_Grado [IdGrado],
		 g.Nombre_Grado [NombreGrado]

FROM Materias m INNER JOIN Areas a ON m.Id_Area = a.Id_Area   INNER JOIN Grados g ON m.Id_Grado = g.Id_Grado     where m.Estado_Materia='A';
GO
EXEC ListarMaterias
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarMateriaIdNombre
CREATE PROCEDURE ListarMateriaIdNombre
AS
SELECT   Id_Materia [IdMateria],
	     Nomre_Materia [NomreMateria]

FROM Materias where Estado_Materia='A';
GO
EXEC ListarMateriaIdNombre


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarMateriasPorNombre
CREATE PROCEDURE ListarMateriasPorNombre
@nombreMateria varchar(30)
AS
SELECT   m.Id_Materia [IdMateria],
	     m.Nomre_Materia [NombreMateria],
	     m.Descripcion_Materia [DescripcionMateria],
		 m.Estado_Materia [EstadoMateria],
		 m.Numero_Horas [NumeroHoras],
		 a.Id_Area [IdArea],
		 a.Nombre [NombreArea],
		 g.Id_Grado [IdGrado],
		 g.Nombre_Grado [NombreGrado]

FROM Materias m INNER JOIN Areas a ON m.Id_Area = a.Id_Area   INNER JOIN Grados g ON m.Id_Grado = g.Id_Grado     where m.Estado_Materia='A' AND m.Nomre_Materia=@nombreMateria;
GO
EXEC ListarMaterias
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarMateria
CREATE PROCEDURE registrarMateria
   @NombreMateria varchar(30),
   @DescripcionMateria text,
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoMateria varchar(2),
   @NumeroHoras int,
   @IdArea int,
   @IdGrado int
   AS
   INSERT INTO Materias (Nomre_Materia, Descripcion_Materia, Usuario_Creacion, Fecha_Creacion, Estado_Materia, Numero_Horas, Id_Area, Id_Grado) 
			VALUES   (@NombreMateria, @DescripcionMateria, @UsuarioCreacion, @FechaCreacion, @EstadoMateria, @NumeroHoras, @IdArea, @IdGrado);  
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarMateria
CREATE PROCEDURE modificarMateria
   @IdMateria int,
   @NombreMateria varchar(30),
   @DescripcionMateria text,
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
   @NumeroHoras int,
   @IdArea int,
   @IdGrado int
   AS

   UPDATE Materias SET Nomre_Materia=@NombreMateria, Descripcion_Materia=@DescripcionMateria, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion, Numero_Horas=@NumeroHoras, Id_Area=@IdArea, Id_Grado=@IdGrado where Id_Materia=@IdMateria;
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE eliminarMateria
CREATE PROCEDURE eliminarMateria
   @IdMateria int
   AS
   UPDATE Materias SET Estado_Materia='I'  where Id_Materia=@IdMateria;
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Materias_Area(
    Id_Materia int,
    Id_Area int
);

ALTER TABLE Materias_Area ADD FOREIGN KEY (Id_Materia) REFERENCES Materias(Id_Materia);
ALTER TABLE Materias_Area ADD FOREIGN KEY (Id_Area) REFERENCES Areas(Id_Area);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop table Logros
create table Logros(
    Id_Logro int IDENTITY(1,1) NOT NULL,
    Nombre_Logro varchar(50) NOT NULL,
    Descripcion_Logro text,
    Usuario_Creacion varchar(30),
    Fecha_Creacion  datetime NOT NULL, 
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado_Logro varchar(2) NOT NULL CHECK(Estado_Logro IN('A', 'I')),
    Id_materia int
);

ALTER TABLE Logros ADD FOREIGN KEY (Id_materia) REFERENCES Materias(Id_Materia);

insert into Logros (Nombre_Logro,Descripcion_Logro,Usuario_Creacion,Fecha_Creacion,Estado_Logro,Id_materia) VALUES ('logro prueba 1','descripcion prueba logro 1','1','2020-03-07 00:00:00.000','A','2');
insert into Logros (Nombre_Logro,Descripcion_Logro,Usuario_Creacion,Fecha_Creacion,Estado_Logro,Id_materia) VALUES ('logro prueba 2','descripcion prueba logro 2','1','2020-03-07 00:00:00.000','A','1');
insert into Logros (Nombre_Logro,Descripcion_Logro,Usuario_Creacion,Fecha_Creacion,Estado_Logro,Id_materia) VALUES ('logro prueba 3','descripcion prueba logro 3','1','2020-03-07 00:00:00.000','A','1');
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarLogros
CREATE PROCEDURE ListarLogros
AS
SELECT   l.Id_Logro [IdLogro],
	     l.Nombre_Logro [NombreLogro],
	     l.Descripcion_Logro [DescripcionLogro],
		 l.Estado_Logro [EstadoLogro],
		 l.Id_materia [idMateria],
		 m.Nomre_Materia [nombreMateria]

FROM Logros l INNER JOIN Materias m ON  m.Id_Materia = l.Id_materia where l.Estado_Logro='A';
GO
EXEC ListarLogros
-- select * from Logros;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarLogrosNombre
CREATE PROCEDURE ListarLogrosNombre
@NombreLogro varchar (50)
AS
SELECT   l.Id_Logro [IdLogro],
	     l.Nombre_Logro [NombreLogro],
	     l.Descripcion_Logro [DescripcionLogro],
		 l.Estado_Logro [EstadoLogro],
		 l.Id_materia [idMateria],
		 m.Nomre_Materia [nombreMateria]

FROM Logros l INNER JOIN Materias m ON  m.Id_Materia = l.Id_materia where l.Estado_Logro='A' and l.Nombre_Logro=@NombreLogro;
GO

EXEC ListarLogrosNombre 'logro prueba 1'
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarLogro
CREATE PROCEDURE registrarLogro
   @NombreLogro varchar(30),
   @DescripcionLogro text,
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoLogro varchar(2),
   @Id_Materia int
   AS
   INSERT INTO Logros (Nombre_Logro, Descripcion_Logro, Usuario_Creacion, Fecha_Creacion, Estado_Logro, Id_materia) 
			VALUES   (@NombreLogro, @DescripcionLogro, @UsuarioCreacion, @FechaCreacion, @EstadoLogro, @Id_Materia);  
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarLogro
CREATE PROCEDURE modificarLogro
   @IdLogro int,
   @NombreLogro varchar(30),
   @DescripcionLogro text,
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
   @EstadoLogro varchar(2),
   @Id_Materia int
   AS
  UPDATE Logros set Nombre_Logro=@NombreLogro, Descripcion_Logro=@DescripcionLogro, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion, Estado_Logro=@EstadoLogro, Id_materia=@Id_Materia where Id_Logro=@IdLogro
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE eliminarLogro
CREATE PROCEDURE eliminarLogro
   @IdLogro int
   AS
   UPDATE Logros set Estado_Logro = 'I' where Id_Logro = @IdLogro;
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Salones(
    Id_Salon int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Salon varchar (30) NOT NULL,
    Descripcion_Salon varchar (100) NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado varchar (2) NOT NULL CHECK(Estado IN('A', 'I'))
);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Concepto_Pago(
    Id_Concepto int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Concepto varchar(50) NOT NULL,
    Descripcion_Concepto text,
    Valor_Concepto decimal (18,2),
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30),
    Fecha_Modificacion datetime
);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Pagos(
    Id_Pago int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Valor_Monto decimal(18,2),
    Descripcion_Pago text,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Id_Concepto_Pago int,
    Id_Estudiante int
);

ALTER TABLE Pagos ADD FOREIGN KEY (Id_Concepto_Pago) REFERENCES Concepto_Pago(Id_Concepto);
ALTER TABLE Pagos ADD FOREIGN KEY (Id_Estudiante) REFERENCES Estudiantes(ID_estudiante);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Abono_Pago(
    Id_Abono_Pago int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Tipo_Abono varchar(20) NOT NULL CHECK(Tipo_Abono IN('P', 'C')),
    Valor_Abonado decimal(18,2) NOT NULL,
    Descripcion_Abono varchar(100),
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime NOT NULL,
    Id_Pago_Registrado int,
);

ALTER TABLE Abono_Pago ADD FOREIGN KEY (Id_Pago_Registrado) REFERENCES Pagos(Id_Pago); 
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Notas(
    Id_Nota int IDENTITY (1,1) NOT NULL PRIMARY KEY,
    Nota decimal (2,1) NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30),
    Fecha_Modificacion datetime,
    Id_usuario int,
    Id_estudiante int,
    Id_materia int,
    Id_periodo int
);

ALTER TABLE Notas ADD FOREIGN KEY (Id_usuario) REFERENCES Usuarios(Id_Usuario);
ALTER TABLE Notas ADD FOREIGN KEY (Id_estudiante) REFERENCES Estudiantes(ID_estudiante);
ALTER TABLE Notas ADD FOREIGN KEY (Id_materia) REFERENCES Materias(Id_Materia);
ALTER TABLE Notas ADD FOREIGN KEY (Id_periodo) REFERENCES Periodos(Id_periodo);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Promedios_Generales(
    Id_Promedio int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Promedio_General decimal (2,1) NOT NULL,
    Id_Estudiante int
);

ALTER TABLE Promedios_Generales ADD FOREIGN KEY (Id_Estudiante) REFERENCES Estudiantes(ID_estudiante);
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




































































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

------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ListarUsuarios
AS
SELECT   Id_Usuario [ID],
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

