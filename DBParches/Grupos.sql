---- Listar todos los grupos como activos e inactivos
ALTER PROCEDURE [dbo].[ListarGrupos] as 
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
		FROM Grupos g  INNER JOIN Grados gr ON g.id_grado = gr.Id_Grado INNER JOIN Usuarios us ON g.id_docente = us.Id_Usuario;
		
---- Listar todos los grupos por el nombre del grupos
ALTER PROCEDURE [dbo].[ListarGrupoPorNombre]
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
		FROM Grupos g  INNER JOIN Grados gr ON g.id_grado = gr.Id_Grado  INNER JOIN Usuarios us ON g.id_docente = us.Id_Usuario where g.nombre_grupo like  CONCAT('%',@nombre_grupo, '%');