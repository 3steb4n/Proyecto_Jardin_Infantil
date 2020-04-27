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
    Documento varchar(20) NOT NULL,
    Tipo_Documento varchar(2) NOT NULL CHECK (Tipo_Documento IN('CC', 'TI', 'P', 'DNI', 'CE')),
    Nombres varchar(30) NOT NULL,
    Apellidos varchar(30) NOT NULL,
    Direccion varchar(30) NOT NULL,
    Celular varchar(15) NOT NULL,
    Telefono varchar(10) NOT NULL,
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
			VALUES   ('6576524','CC','Diego Alejandro','Astaiza','KR NORTE 32','3133717955','6941089','dastaizabo@uninpahu.edu.co','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','A');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('99074524','CC','Manuel Perez','Gonzales','CALLE 432 # SUR','3054785944','3647877','pedro@hotmail.com','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','D');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('85472412','CC','Daniel','Alzate','CR 32 # 32 SUR','3114785566','6984521','daniel.alzate@hotmail.com','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','D');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('100032','CC','Sofia ','Gomez','KR 213 # SUR 54','3148596544','9647820','sofia@hotmail.com','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','S');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('867987','CC','Paola','Gomez','AV 38 NORTE # 32','3021485966','74859666','paola@hotmail.com','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','D');
			INSERT INTO Usuarios (Documento,Tipo_Documento, Nombres, Apellidos, Direccion, Celular, Telefono, Correo_Electronico, Usuario_Clave, Usuario_Creacion,  Fecha_Creacion,Usuario_Modificacion, Fecha_Modificacion,Estado_Usuario,Estado_Clave,Tipo_Usuario) 
			VALUES   ('3453433','CC','Radamel','Falcao','AV 48 SUR','31337485966','6347485','rada@hotmail.com','DVOZUIQnznlVbNpxkYAgwejRW1M=','1','2020-03-07 00:00:00.000','','','A','S','S');

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
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- DROP PROCEDURE ListarDocentes

CREATE PROCEDURE ListarDocentes
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

FROM Usuarios where Estado_Usuario = 'A' and Tipo_Usuario='D';
GO

-- EXEC ListarUsuarios;
-- select  * from usuarios;
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- DROP PROCEDURE ListarUsuarioDocumento
-- EXEC ListarUsuarioDocumento '432';
CREATE PROCEDURE ListarUsuarioDocumento
@Documento varchar(20)
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
-- DROP PROCEDURE ListarUsuarioDocumentoProfesor
-- EXEC ListarUsuarioDocumento '432';
CREATE PROCEDURE ListarUsuarioDocumentoProfesor
@Documento varchar(20)
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

FROM Usuarios where Documento = @Documento AND Estado_Usuario = 'A' and Tipo_Usuario='D';
GO
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarDocentesIdNombre
CREATE PROCEDURE ListarDocentesIdNombre
AS
SELECT   Id_Usuario [ID],
		 Nombres [Nombres],
		 Apellidos [Apellidos]
		 
FROM Usuarios where Estado_Usuario = 'A' and Tipo_Usuario='D';
GO
EXEC ListarDocentesIdNombre

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarUsuario
CREATE PROCEDURE registrarUsuario
   @Documento varchar(20),
   @Tipo_Documento varchar(2),
   @Nombres varchar(30),
   @Apellidos varchar(30),
   @Direccion varchar(30),
   @Celular varchar(15),
   @Telefono varchar(15),
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
   @Documento varchar(20),
   @Tipo_Documento varchar(2),
   @Nombres varchar(30),
   @Apellidos varchar(30),
   @Direccion varchar(30),
   @Celular varchar(15),
   @Telefono varchar(15),
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
--DROP PROCEDURE modificarUsuarioPropio

CREATE PROCEDURE modificarUsuarioPropio
   @ID int,
   @Nombres varchar(30),
   @Apellidos varchar(30),
   @Direccion varchar(30),
   @Celular varchar(15),
   @Telefono varchar(15),
   @Correo_Electronico varchar(100),
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime
   AS
  UPDATE Usuarios SET  Nombres=@Nombres, Apellidos=@Apellidos, Direccion=@Direccion, Celular=@Celular, Telefono=@Telefono, Correo_Electronico=@Correo_Electronico, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion  where Id_Usuario=@ID;
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarUsuarioPropioPasswd
CREATE PROCEDURE modificarUsuarioPropioPasswd
   @ID int,
   @Nombres varchar(30),
   @Apellidos varchar(30),
   @Direccion varchar(30),
   @Celular varchar(15),
   @Telefono varchar(15),
   @Correo_Electronico varchar(100),
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
   @Passwd varchar(100),
   @EstadoClave varchar(2)
   AS
  UPDATE Usuarios SET  Nombres=@Nombres, Apellidos=@Apellidos, Direccion=@Direccion, Celular=@Celular, Telefono=@Telefono, Correo_Electronico=@Correo_Electronico, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion, Usuario_Clave = @Passwd, Estado_Clave = @EstadoClave  where Id_Usuario=@ID;
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
@Correo_Electronico varchar(100),
@Usuario_Clave varchar (100)
AS
SELECT  Id_Usuario [ID],
	    Documento [Documento],
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
    Nombre_Grado varchar(30) NOT NULL,
    Descripcion_Grado varchar(300),
    Usuario_Creacion varchar(30),
    Fecha_creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado varchar(2) NOT NULL CHECK (Estado IN('A', 'I'))
);

insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('Parbulos','Competencia para ninos de 1 y 2 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
insert into Grados (Nombre_Grado,Descripcion_Grado,Usuario_Creacion,Fecha_creacion,Usuario_Modificacion,Fecha_Modificacion,Estado) values ('PreKinder','Competencia para ninos de 2 y 3 anos','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');
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
    nombre_grupo varchar(30) NOT NULL,
    descripcion_grupo varchar(100),
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

insert into Grupos (nombre_grupo,descripcion_grupo,usuario_creacion,fecha_creacion,usuario_modificacion,fecha_modificacion,estado_grupo,id_grado,id_docente) values ('PK001','Primer curso de estudiantes del  grado prekinder de la sede principal','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','3','2');
insert into Grupos (nombre_grupo,descripcion_grupo,usuario_creacion,fecha_creacion,usuario_modificacion,fecha_modificacion,estado_grupo,id_grado,id_docente) values ('PK002','Segundo curso de estudiantes del  grado prekinder de la sede principal','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A','3','2');
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
@nombre_grupo varchar(30)
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
select * from Grupos;
select * from Usuarios;
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
   @NombreGrupo varchar(30),
   @DescripcionGrupo varchar(100),
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoGrupo varchar(2),
   @IdGrado int,
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
   @NombreGrupo varchar(30),
   @DescripcionGrupo varchar(30),
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime,
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

create table Matriculas(
		Id_matricula int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Numero_matricula int not null,
		Ano_reguistro date not null,
 		Fecha_creacion datetime,
		Estado_matricula varchar (2) NOT NULL CHECK(Estado_matricula IN ('A', 'I')),
		ID_estudiante int,
		ID_grupo int
);
ALTER TABLE Matriculas ADD FOREIGN KEY (ID_grupo) REFERENCES Grupos(id_grupo);
ALTER TABLE Matriculas ADD FOREIGN KEY (ID_estudiante) REFERENCES Estudiantes(ID_estudiante);

INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
VALUES   ('20210931','2003-03-26 13:00:00.000','2003-03-26 13:00:00.000','A','1','1');  

INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
VALUES   ('20210932','2003-03-26 13:00:00.000','2003-03-26 13:00:00.000','A','2','2'); 

INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
VALUES   ('20210933','2003-03-26 13:00:00.000','2003-03-26 13:00:00.000','A','3','1');

INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
VALUES   ('20210934','2003-03-26 13:00:00.000','2003-03-26 13:00:00.000','A','4','2');

INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
VALUES   ('20210935','2003-03-26 13:00:00.000','2003-03-26 13:00:00.000','A','5','1'); 

CREATE PROCEDURE registrarMatricula
   @Numeromatricula varchar(20),
   @Anoreguistro date,
   @Fechacreacion datetime,
   @Estadomatricula varchar(2),
   @IDestudiante int,
   @IDgrupo int
   AS
   INSERT INTO Matriculas(Numero_matricula,Ano_reguistro,Fecha_creacion,Estado_matricula,ID_estudiante,ID_grupo) 
			VALUES   (@Numeromatricula,@Anoreguistro,@Fechacreacion,@Estadomatricula,@IDestudiante,@IDgrupo);  
GO

use JardinInfantil;
CREATE PROCEDURE ListarMatricula
AS
SELECT   m.Id_matricula [Idmatricula],
	     m.Numero_matricula [NumeroMatricula],
		 m.Ano_reguistro [AnoReguistro],
		 m.Estado_matricula[EstadoMatriculado],
		 m.ID_estudiante[Idestudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 m.ID_grupo [Idgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Matriculas m INNER JOIN Grupos gr ON gr.id_grupo = m.ID_grupo INNER JOIN Estudiantes e on e.ID_estudiante = m.ID_estudiante;
GO


CREATE PROCEDURE ListarMatriculasPorDocumento
@Documento varchar(20)
AS
SELECT   m.Id_matricula [Idmatricula],
	     m.Numero_matricula [NumeroMatricula],
		 m.Ano_reguistro [AnoReguistro],
		 m.Estado_matricula[EstadoMatriculado],
		 m.ID_estudiante[Idestudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 m.ID_grupo [Idgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Matriculas m INNER JOIN Grupos gr ON gr.id_grupo = m.ID_grupo INNER JOIN Estudiantes e on e.ID_estudiante = m.ID_estudiante where  e.Documento_Estudiante LIKE '%'+@Documento+'%';
GO



use JardinInfantil;

CREATE PROCEDURE ListarMatriculasPorGrupo
@idGrupo int
AS
SELECT   m.Id_matricula [Idmatricula],
	     m.Numero_matricula [NumeroMatricula],
		 m.Ano_reguistro [AnoReguistro],
		 m.Estado_matricula[EstadoMatriculado],
		 m.ID_estudiante[Idestudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 m.ID_grupo [Idgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Matriculas m INNER JOIN Grupos gr ON gr.id_grupo = m.ID_grupo INNER JOIN Estudiantes e on e.ID_estudiante = m.ID_estudiante where  gr.id_grupo = @idGrupo;
GO

exec ListarMatriculasPorDocumento '123';

CREATE PROCEDURE ListarMatriculasPorDocumentoyGrupo
@Documento varchar(20),
@idGrupo int
AS
SELECT   
		 m.Id_matricula [Idmatricula],
	     m.Numero_matricula [NumeroMatricula],
		 m.Ano_reguistro [AnoReguistro],
		 m.Estado_matricula[EstadoMatriculado],
		 m.ID_estudiante[Idestudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 m.ID_grupo [Idgrupo],
		 gr.Nombre_Grupo [NombreGrupo]

FROM Matriculas m INNER JOIN Grupos gr ON gr.id_grupo = m.ID_grupo INNER JOIN Estudiantes e on e.ID_estudiante = m.ID_estudiante where  e.Documento_Estudiante LIKE '%'+@Documento+'%' and gr.id_grupo = @idGrupo;
GO


-- use JardinInfantil
-- select * from grupos;

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop table Estudiantes
create table Estudiantes(
    ID_estudiante int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Documento_Estudiante varchar(20) NOT NULL,
    Tipo_Documento varchar(2) NOT NULL CHECK (Tipo_Documento IN('RC', 'TI', 'DNI')),
    Nombre_Estudiante varchar(30) NOT NULL,
    Apellido_Estudiante varchar(30) NOT NULL,
    Fecha_Nacimiento date NOT NULL,
    Ruta_foto varchar(100) NULL DEFAULT '',
    Acudiente_Nombre varchar(30) NOT NULL,
    Direccion varchar(30) NOT NULL,
    Genero_Estudiante varchar(2) NOT NULL CHECK(Genero_Estudiante IN ('M', 'F')),
    Telefono varchar(15),
    Celular varchar(15),
    Correo_Electronico varchar(100),
    Observaciones text NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime ,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
	Estado_Estudiante varchar (2) NOT NULL CHECK(Estado_Estudiante IN ('A', 'I')),
);


INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante) 
VALUES   ('6578465','RC','Valery Sofia ','Perez Casitllo','2003-03-26 13:00:00.000','','Piedad Borja Rivas','KR 24 A # 32 A SUR 32','F','6941023','3057485965','piedad_borja@hotmail.com','Observaciones sobre el primer estudiante','1','2020-03-07 12:00:00.000','1','2020-03-07 12:00:00.000','A');  

INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante) 
VALUES   ('106468','TI','Manuel Esteban ','Carvajal Carvajal','2008-12-30 14:00:00.000','','Ever Gomez Perez','CALLE 32 Norte','M','9685741','3214578965','ever_gomez@hotmail.com','Observaciones sobre el segundo estudiante','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');   

INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante) 
VALUES   ('10008548','RC','Daniel Gustavo ','Gomez','2013-04-06 12:32:00.000','','Carlos Armani Rodriguez','KR 56 SUR','M','6945896','3157489654','carlos_armani@hotmail.com','Observaciones sobre el cuarto estudiante','1','2020-03-07 01:40:00.000','1','2020-03-07 01:40:00.000','A');  

INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante) 
VALUES   ('85744566','RC','Esteban  ','Gomez','2010-02-11 04:32:00.000','','Manuel Perez Ordoñez','KR 43 NORTE ','M','3747852','3114785964','manuel_perez@hotmail.com','Observaciones sobre el quinto estudiante','1','2020-03-07 12:45:00.000','1','2020-03-07 00:00:00.000','A');  

INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Usuario_Modificacion,Fecha_Modificacion,Estado_Estudiante) 
VALUES   ('6699547','RC','Pedro Franco ','Armani','2004-02-01 15:30:00.000','','Gustavo Alzate','AV 32 # 312 SUR','M','9475965','313371823','gustavo_alzate@hotmail.com','Observaciones sobre el sexto estudiante','1','2020-03-07 00:00:00.000','1','2020-03-07 00:00:00.000','A');  

select * from Estudiantes;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantes
CREATE PROCEDURE ListarEstudiantes
AS
SELECT   ID_estudiante [IdEstudiante],
	     Documento_Estudiante [DocumentoEstudiante],
	     Tipo_Documento [TipoDocumento],
		 Nombre_Estudiante [NombreEstudiante],
		 Apellido_Estudiante [ApellidoEstudiante],
		 Fecha_Nacimiento [FechaNacimiento],
		 Ruta_foto [RutaFoto],
		 Acudiente_Nombre [AcudienteNombre],
		 Direccion [Direccion],
		 Genero_Estudiante [GeneroEstudiante],
	     Telefono [Telefono],
		 Celular [Celular],
		 Correo_Electronico [CorreoElectronico],
		 Observaciones [Observaciones],
		 Estado_Estudiante [EstadoEstudiante]

FROM Estudiantes;
GO
EXEC ListarEstudiantes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantePorDocumento
CREATE PROCEDURE ListarEstudiantePorDocumento
@Documento varchar(20)
AS
SELECT   ID_estudiante [IdEstudiante],
	     Documento_Estudiante [DocumentoEstudiante],
	     Tipo_Documento [TipoDocumento],
		 Nombre_Estudiante [NombreEstudiante],
		 Apellido_Estudiante [ApellidoEstudiante],
		 Fecha_Nacimiento [FechaNacimiento],
		 Ruta_foto [RutaFoto],
		 Acudiente_Nombre [AcudienteNombre],
		 Direccion [Direccion],
		 Genero_Estudiante [GeneroEstudiante],
	     Telefono [Telefono],
		 Celular [Celular],
		 Correo_Electronico [CorreoElectronico],
		 Observaciones [Observaciones],
		 Estado_Estudiante [EstadoEstudiante]

FROM Estudiantes;
GO

EXEC ListarEstudiantePorDocumento '106468'
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantePorDocumentoyGrupo

EXEC ListarEstudiantePorDocumentoyGrupo '',1;
-- select * from Estudiantes;

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarEstudiantesIdNombre
CREATE PROCEDURE ListarEstudiantesIdNombre
AS
SELECT   ID_estudiante [ID],
		 Nombre_Estudiante [Nombres],
		 Apellido_Estudiante [Apellidos]
		 
FROM Estudiantes where Estado_Estudiante = 'A';
GO
EXEC ListarEstudiantesIdNombre
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE registrarEstudiante
CREATE PROCEDURE registrarEstudiante
   @DocumentoEstudiante varchar(20),
   @TipoDocumento varchar(2),
   @NombreEstudiante varchar(30),
   @ApellidoEstudiante varchar(30),
   @FechaNacimiento date,
   @RutaFoto varchar(100),
   @AcudienteNombre varchar(30),
   @Direccion varchar(30),
   @GeneroEstudiante varchar(30),
   @Telefono varchar(15),
   @Celular varchar(15),
   @CorreoElectronico varchar(100),
   @Observaciones varchar(30),
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @EstadoEstudiante varchar(2)
   AS
   INSERT INTO Estudiantes (Documento_Estudiante,Tipo_Documento,Nombre_Estudiante,Apellido_Estudiante,Fecha_Nacimiento,Ruta_foto,Acudiente_Nombre,Direccion,Genero_Estudiante,Telefono,Celular,Correo_Electronico,Observaciones,Usuario_Creacion,Fecha_Creacion,Estado_Estudiante) 
			VALUES   (@DocumentoEstudiante,@TipoDocumento,@NombreEstudiante,@ApellidoEstudiante,@FechaNacimiento,@RutaFoto,@AcudienteNombre,@Direccion,@GeneroEstudiante,@Telefono,@Celular,@CorreoElectronico,@Observaciones,@UsuarioCreacion,@FechaCreacion,@EstadoEstudiante);  
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DROP PROCEDURE modificarEstudiante
CREATE PROCEDURE modificarEstudiante
   @IDEstudiante int,
   @DocumentoEstudiante varchar(20),
   @TipoDocumento varchar(2),
   @NombreEstudiante varchar(30),
   @ApellidoEstudiante varchar(30),
   @FechaNacimiento date,
   @RutaFoto varchar(100),
   @AcudienteNombre varchar(30),
   @Direccion varchar(30),
   @GeneroEstudiante varchar(2),
   @Telefono varchar(15),
   @Celular varchar(15),
   @CorreoElectronico varchar(100),
   @Observaciones varchar(30),
   @UsuarioModificacion varchar(30),
   @FechaModificacion datetime
   AS
   UPDATE Estudiantes SET Documento_Estudiante=@DocumentoEstudiante, Tipo_Documento=@TipoDocumento, Nombre_Estudiante=@NombreEstudiante, Apellido_Estudiante=@ApellidoEstudiante, Fecha_Nacimiento=@FechaNacimiento, Ruta_foto=@RutaFoto, Acudiente_Nombre=@AcudienteNombre, Direccion=@Direccion, Genero_Estudiante=@GeneroEstudiante, Telefono=@Telefono,  Celular=@Celular, Correo_Electronico=@CorreoElectronico, Observaciones=@Observaciones, Usuario_Modificacion=@UsuarioModificacion, Fecha_Modificacion=@FechaModificacion where ID_estudiante=@IDEstudiante;
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
    Nombre_Periodo varchar(30) NOT NULL,
    Descripcion_Periodo varchar(300),
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
    Nombre varchar(30) NOT NULL,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000',
    Estado varchar(2) NOT NULL CHECK(Estado IN('A', 'I'))
);

insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Area tecnologica','1','2020-03-07 00:00:00.000','A');
insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Area de la ciencia','1','2020-03-07 00:00:00.000','A');
insert into Areas (Nombre,Usuario_Creacion,Fecha_Creacion,Estado) VALUES ('Area de sociologia','1','2020-03-07 00:00:00.000','A');
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
   @DescripcionMateria varchar(300),
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
    Nombre_Logro varchar(30) NOT NULL,
    Descripcion_Logro varchar(300),
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
@NombreLogro varchar (30)
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
   @DescripcionLogro varchar(300),
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
   @DescripcionLogro varchar(300),
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
-- drop table Concepto_Pago
create table Concepto_Pago (
    Id_Concepto int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Concepto varchar(30) NOT NULL,
    Descripcion_Concepto varchar(300),
    Valor_Concepto int,
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Usuario_Modificacion varchar(30) NULL DEFAULT '',
    Fecha_Modificacion datetime NULL DEFAULT '2020-03-07 00:00:00.000'
);
 
 insert into Concepto_Pago (Nombre_Concepto, Descripcion_Concepto, Valor_Concepto, Usuario_Creacion, Fecha_Creacion) VALUES ('Matricula','Descripción de la matreicula de pago',150000,'1','2020-03-07 00:00:00.000');
 insert into Concepto_Pago (Nombre_Concepto, Descripcion_Concepto, Valor_Concepto, Usuario_Creacion, Fecha_Creacion) VALUES ('Pension','Descripción de la pension de pago',110000,'1','2020-03-07 00:00:00.000');
 insert into Concepto_Pago (Nombre_Concepto, Descripcion_Concepto, Valor_Concepto, Usuario_Creacion, Fecha_Creacion) VALUES ('Registro','Descripción de la pension de pago',140000,'1','2020-03-07 00:00:00.000');
 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- select * from Concepto_Pago
-- DROP PROCEDURE  Listar_Concepto_Pago
CREATE PROCEDURE Listar_Concepto_Pago
AS
SELECT  Id_Concepto [IdConcepto],
		Nombre_Concepto [NombreConcepto],
		Valor_Concepto [ValorConcepto]
		
		FROM Concepto_Pago;
GO

EXEC Listar_Concepto_Pago;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop table Pagos
create table Pagos(
    Id_Pago int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Valor_Monto int,
    Descripcion_Pago varchar(300),
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime,
    Id_Concepto_Pago int,
    Id_Estudiante int
);

ALTER TABLE Pagos ADD FOREIGN KEY (Id_Concepto_Pago) REFERENCES Concepto_Pago(Id_Concepto);
ALTER TABLE Pagos ADD FOREIGN KEY (Id_Estudiante) REFERENCES Estudiantes(ID_estudiante);

select * from Pagos;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure registrarPago
CREATE PROCEDURE registrarPago
   @ValorMonto int,
   @DescripcionPago varchar(300),
   @UsuarioCreacion varchar(30),
   @FechaCreacion datetime,
   @IdConceptoPago varchar(2),
   @IdEstudiante int
   AS
   INSERT INTO Pagos (Valor_Monto, Descripcion_Pago, Usuario_Creacion, Fecha_Creacion, Id_Concepto_Pago, Id_Estudiante) 
			VALUES   (@ValorMonto, @DescripcionPago, @UsuarioCreacion, @FechaCreacion, @IdConceptoPago, @IdEstudiante);  
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarPago
CREATE PROCEDURE ListarPago
AS
SELECT   p.Id_Pago [idPago],
		 p.Valor_Monto [ValorMonto],
	     p.Descripcion_Pago [DescripcionPago],
	     u.Id_Usuario [UsuarioCreacion],
		 u.Nombres[Nombres],
		 u.Apellidos[Apellidos],
		 p.Fecha_Creacion [FechaCreacion],
		 c.Id_Concepto [IdConcepto],
		 c.Nombre_Concepto [NombreConcepto],
		 e.ID_estudiante [IDEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Apellido_Estudiante [ApellidoEstudiante],
		 e.Acudiente_Nombre [AcudienteNombre],
		 e.Correo_Electronico [CorreoElectronico],
		 e.Telefono [telefono],
		 e.Celular [celular],
		 e.Direccion [direccion]

FROM Pagos p INNER JOIN Concepto_Pago c ON  c.Id_Concepto = p.Id_Concepto_Pago INNER JOIN Estudiantes e ON e.ID_estudiante = p.Id_Estudiante INNER JOIN Usuarios u ON u.Id_Usuario = p.Usuario_Creacion;
GO

EXEC ListarPago
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarPagoFiltro
CREATE PROCEDURE ListarPagoFiltro
@documentoEstudiante varchar(20),
@nombreConcepto varchar(30)
AS
SELECT   p.Id_Pago [idPago],
		 p.Valor_Monto [ValorMonto],
	     p.Descripcion_Pago [DescripcionPago],
	     u.Id_Usuario [UsuarioCreacion],
		 u.Nombres[Nombres],
		 u.Apellidos[Apellidos],
		 p.Fecha_Creacion [FechaCreacion],
		 c.Id_Concepto [IdConcepto],
		 c.Nombre_Concepto [NombreConcepto],
		 e.ID_estudiante [IDEstudiante],
		 e.Documento_Estudiante [DocumentoEstudiante],
		 e.Nombre_Estudiante [NombreEstudiante],
		 e.Apellido_Estudiante [ApellidoEstudiante],
		 e.Acudiente_Nombre [AcudienteNombre],
		 e.Correo_Electronico [CorreoElectronico],
		 e.Telefono [telefono],
		 e.Celular [celular],
		 e.Direccion [direccion]

FROM Pagos p INNER JOIN Concepto_Pago c ON  c.Id_Concepto = p.Id_Concepto_Pago INNER JOIN Estudiantes e ON e.ID_estudiante = p.Id_Estudiante INNER JOIN Usuarios u ON u.Id_Usuario = p.Usuario_Creacion where e.Documento_Estudiante LIKE '%'+@documentoEstudiante+'%' and c.Nombre_Concepto LIKE '%'+@nombreConcepto+'%' ;
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- LIKE '%'+@Documento+'%'   and c.Nombre_Concepto = @nombreConcepto
-- drop table Abono_Pago 
create table Abono_Pago(
    Id_Abono_Pago int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Tipo_Abono varchar(2) NOT NULL CHECK(Tipo_Abono IN('P', 'C')),
    Valor_Abonado int NOT NULL,
    Descripcion_Abono varchar(100),
    Usuario_Creacion varchar(30),
    Fecha_Creacion datetime NOT NULL,
    Id_Pago_Registrado int,
);

ALTER TABLE Abono_Pago ADD FOREIGN KEY (Id_Pago_Registrado) REFERENCES Pagos(Id_Pago); 
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarAbonoPago
CREATE PROCEDURE ListarAbonoPago
@Id_Pago int
AS
SELECT   a.Id_Abono_Pago [IdAbonoPago],
		 a.Tipo_Abono [TipoAbono],
	     a.Valor_Abonado [ValorAbonado],
	     a.Descripcion_Abono [DescripcionAbono],
		 a.Fecha_Creacion [fechaCreacion],
		 p.Id_Pago [idPago],
		 p.Descripcion_Pago [descripcionPago],
		 u.Id_Usuario [idUsuario],
		 u.Nombres [Nombres],
		 u.Apellidos [Apellidos]

FROM Abono_Pago a INNER JOIN Pagos p ON  p.Id_Pago = a.Id_Pago_Registrado INNER JOIN Usuarios u ON u.Id_Usuario = a.Usuario_Creacion where a.Id_Pago_Registrado = @Id_Pago; 
GO
select * from Abono_Pago;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure ListarDineroAbonado
CREATE PROCEDURE ListarDineroAbonado
@Id_Pago int
AS
SELECT   SUM(Valor_Abonado) [ValorAbonado]

FROM Abono_Pago  where Id_Pago_Registrado = @Id_Pago; 
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop procedure registrarAbonoPago
CREATE PROCEDURE registrarAbonoPago
   @Tipo_Abono varchar(2),
   @Valor_Abonado int,
   @Descripcion_Abono varchar(100),
   @Usuario_Creacion varchar(30),
   @Fecha_Creacion datetime,
   @Id_Pago_Registrado int
   AS
   INSERT INTO Abono_Pago (Tipo_Abono, Valor_Abonado, Descripcion_Abono, Usuario_Creacion, Fecha_Creacion, Id_Pago_Registrado) 
			VALUES   (@Tipo_Abono, @Valor_Abonado, @Descripcion_Abono, @Usuario_Creacion, @Fecha_Creacion, @Id_Pago_Registrado);  
GO

select * from Abono_Pago;
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