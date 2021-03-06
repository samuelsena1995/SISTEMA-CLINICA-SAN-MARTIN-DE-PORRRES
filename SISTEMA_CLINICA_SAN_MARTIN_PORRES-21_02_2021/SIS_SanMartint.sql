USE [BD_CLINICA_SAN_MARTIN_PORRES]
GO
/****** Object:  Table [dbo].[LISTA_DE_ANALISIS_LABORATORIO]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LISTA_DE_ANALISIS_LABORATORIO](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Corto] [char](50) NOT NULL,
	[Descripcion] [char](160) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[EditarProductos]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------EDITAR

create proc [dbo].[EditarProductos]
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id

GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------ELIMINAR
create proc [dbo].[EliminarProducto]
@idpro int
as
delete from Productos where Id=@idpro

GO
/****** Object:  StoredProcedure [dbo].[InsetarProductos]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------INSERTAR 
create proc [dbo].[InsetarProductos]
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)

GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Buscar_Campo]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Buscar_Campo]
 @buscar varchar(40),
 @cbtipos varchar(50),
 @cbestado varchar(50)
 as
 if(@cbtipos='Nombre Corto' and @cbestado='Todos')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Nombre Corto' and @cbestado='Habilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'
end
else if(@cbtipos='Nombre Corto' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'
end
---descripcion
else if(@cbtipos='Descripcion' and @cbestado='Todos')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Descripcion' and @cbestado='Habilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='Habilitado'
end
else if(@cbtipos='Descripcion' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'
end
--todos
else if(@cbtipos='Todos' and @cbestado='Todos')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
end
else if(@cbtipos='TODOS' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'  
end
else if(@cbtipos='Todos' and @cbestado='Habilitado')
 begin
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'  
end
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Cambio_Estado]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update LISTA_DE_ANALISIS_LABORATORIO set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Editar]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Editar]
@Codigo int,
@Nombrecorto char(50),
@Descripcion char(160)
as
update LISTA_DE_ANALISIS_LABORATORIO
set Nombre_Corto=@Nombrecorto,
Descripcion=@Descripcion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Eliminar]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Eliminar]
@Codigo int
as
delete from LISTA_DE_ANALISIS_LABORATORIO
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_ID]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_ID]
@id int
as
select * from LISTA_DE_ANALISIS_LABORATORIO
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Mostrar]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Mostrar]
as
select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Registrar]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Registrar]
--@Codigo int,
@Nombrecorto char(50),
@Descripcion char(160),
@Estado char(1)
as
insert into LISTA_DE_ANALISIS_LABORATORIO(Nombre_Corto,Descripcion,Estado)
values(@Nombrecorto,@Descripcion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte]
 @Estado varchar(15)

 as
if(@Estado='Todos')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado' 
when 'D' then 'Deshabilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Deshabilitado')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'D' then 'Deshabilitado' 
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Estado='D'
end
else if(@Estado='Habilitado')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Estado='H'
end

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_lista]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_lista]

as
select l.Codigo,l.Nombre_Corto,l.Descripcion,l.Estado from LISTA_DE_ANALISIS_LABORATORIO l
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_lista_parametro]    Script Date: 21/9/2020 07:52:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_lista_parametro]
@nombre char(50)
as
select l.Codigo,l.Nombre_Corto,l.Descripcion,l.Estado from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto=@nombre
GO
