USE [master]
GO
/****** Object:  Database [BD_CLINICA_SAN_MARTIN_PORRES]    Script Date: 30/10/2020 22:08:20 ******/
CREATE DATABASE [BD_CLINICA_SAN_MARTIN_PORRES]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_CLINICA_SAN_MARTIN_PORRES', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BD_CLINICA_SAN_MARTIN_PORRES.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_CLINICA_SAN_MARTIN_PORRES_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BD_CLINICA_SAN_MARTIN_PORRES_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_CLINICA_SAN_MARTIN_PORRES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET  MULTI_USER 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BD_CLINICA_SAN_MARTIN_PORRES]
GO
/****** Object:  Table [dbo].[AsigancionPermiso]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsigancionPermiso](
	[IdUsuario] [int] NULL,
	[IdPermiso] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AsignacionPermiso]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AsignacionPermiso](
	[IdUsuario] [char](50) NOT NULL,
	[IdPermiso] [char](50) NOT NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [llave_compuesta_asignacion] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FICHA_PACIENTE]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FICHA_PACIENTE](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](100) NULL,
	[Fecha_Nac] [date] NULL,
	[Sexo] [char](1) NULL,
	[Datos_Referencia] [char](250) NULL,
	[Observaciones] [char](150) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FUNCIONARIO]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FUNCIONARIO](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](100) NULL,
	[Ocupacion] [char](10) NULL,
	[N_Celular] [char](8) NULL,
	[Observacion] [char](150) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hora]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hora](
	[IdPermiso] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LISTA_DE_ANALISIS_LABORATORIO]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  Table [dbo].[LISTA_ESTUDIO_IMAGEN]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LISTA_ESTUDIO_IMAGEN](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](50) NULL,
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
/****** Object:  Table [dbo].[Medico]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medico](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](100) NULL,
	[Ocupacion] [char](10) NULL,
	[N_Celular] [char](8) NULL,
	[Observacion] [char](150) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERMISO](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [char](100) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERMISOS]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERMISOS](
	[Codigo] [char](50) NOT NULL,
	[Modulo] [char](50) NOT NULL,
	[Descripcion] [char](150) NOT NULL,
	[Funcion] [char](50) NULL,
	[Estado] [char](1) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALA]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALA](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](50) NULL,
	[Descripcion] [char](150) NULL,
	[Estado] [char](1) NULL,
	[CodigoTipoSala] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipos_Sala]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipos_Sala](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](50) NULL,
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
/****** Object:  Table [dbo].[USUARIO]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Completo] [char](100) NULL,
	[Observacion] [char](150) NULL,
	[Estado] [char](1) NULL,
	[Usuario] [char](50) NULL,
	[Contraseña] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[Codigo] [char](50) NOT NULL DEFAULT (''),
	[Nombre_Completo] [char](100) NOT NULL,
	[Observacion] [char](150) NOT NULL,
	[Estado] [char](1) NULL,
	[Contraseña] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[SALA]  WITH CHECK ADD  CONSTRAINT [FK_SALA_Tipos_Sala] FOREIGN KEY([CodigoTipoSala])
REFERENCES [dbo].[Tipos_Sala] ([Codigo])
GO
ALTER TABLE [dbo].[SALA] CHECK CONSTRAINT [FK_SALA_Tipos_Sala]
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_ASIGNACION]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ELIMINAR_ASIGNACION]
@Codigo int
AS
delete AsigancionPermiso where IdUsuario=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FICHA_PACIENTE_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where  l.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA],l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], l.Nombre as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], l.Observaciones as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FICHA_PACIENTE_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update FICHA_PACIENTE set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FICHA_PACIENTE_Editar]
@Codigo int,
@Nombre char(50),
@Fecha date,
@Sexo char(1),
@Datos_Referencia char(250),
@Observacion char(160)
as
update FICHA_PACIENTE
set Nombre=@Nombre,
Fecha_Nac=@Fecha,
Sexo=@Sexo,
Datos_Referencia=@Datos_Referencia,
Observaciones=@Observacion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FICHA_PACIENTE_Eliminar]
@Codigo int
as
delete from FICHA_PACIENTE
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FICHA_PACIENTE_ID]
@id int
as
select * from FICHA_PACIENTE
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FICHA_PACIENTE_Mostrar]
as

select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],format(L.Fecha_Nac,'dd/MM/yyyy') AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
rtrim(ltrim(L.Datos_Referencia)) AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l

GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FICHA_PACIENTE_Registrar]
--@Codigo int,
@Nombre char(50),
@Fecha date,
@Sexo char(1),
@Datos_Referencia char(250),
@Observacion char(160),
@Estado char(1)
as
insert into FICHA_PACIENTE(Nombre,Fecha_Nac,Sexo,Datos_Referencia,Observaciones,Estado)
values(LTRIM(RTRIM(@Nombre)),@Fecha,@Sexo,@Datos_Referencia,@Observacion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[FICHA_PACIENTE_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FICHA_PACIENTE_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where  l.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE],L.Fecha_Nac AS[FECHA NACIMIENTO],
case L.Sexo
when 'F' then 'Femenino'
when 'M' then 'Masculino'
end
 AS [SEXO],
L.Datos_Referencia AS[DATOS REFERENCIA], RTRIM(LTRIM(l.Observaciones)) as[OBSERVACIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FICHA_PACIENTE l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FUNCIONARIO_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
	where f.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where  f.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado 
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from FUNCIONARIO f
where f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FUNCIONARIO_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update FUNCIONARIO set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FUNCIONARIO_Editar]
@Codigo int,
@Nombre char(50),
@Ocupacion char(10),
@N_celular char(8),
@Observacion char(160)
as
update FUNCIONARIO
set Nombre=@Nombre,
Ocupacion=@Ocupacion,
N_Celular=@N_celular,
Observacion=@Observacion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FUNCIONARIO_Eliminar]
@Codigo int
as
delete from FUNCIONARIO
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FUNCIONARIO_ID]
@id int
as
select * from FUNCIONARIO
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FUNCIONARIO_Mostrar]
as
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FUNCIONARIO_Registrar]
--@Codigo int,
@Nombre char(50),
@Ocupacion char(10),
@N_celular char(8),
@Observacion char(150),
@Estado char(1)
as
insert into FUNCIONARIO(Nombre,Ocupacion,N_Celular,Observacion,Estado)
values(@Nombre,@Ocupacion,@N_celular,@Observacion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[FUNCIONARIO_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FUNCIONARIO_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
	where f.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where  f.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado 
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from FUNCIONARIO f
where f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from FUNCIONARIO f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Buscar_Campo]
 @buscar varchar(40),
 @cbtipos varchar(50),
 @cbestado varchar(50)
 as
 if(@cbtipos='Nombre' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Nombre' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'
end
else if(@cbtipos='Nombre' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'
end
---descripcion
else if(@cbtipos='Descripcion' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Descripcion like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Descripcion' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Descripcion like +'%'+@buscar+'%' and l.Estado='H'
end
else if(@cbtipos='Descripcion' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Descripcion like +'%'+@buscar+'%' and l.Estado='D'
end
--todos
else if(@cbtipos='Todos' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
end
else if(@cbtipos='Todos' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto  like +'%'+@buscar+'%' and l.Estado='D'  
end
else if(@cbtipos='Todos' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'  
end
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Editar]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_ID]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Mostrar]
as
--select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
-- CASE l.Estado
-- when 'H' THEN 'Habilitado'
-- when 'D' then 'Deshabilitado'
-- end as [ESTADO]
--from LISTA_DE_ANALISIS_LABORATORIO l

select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Corto)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_DE_ANALISIS_LABORATORIO l
GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar]
 @Estado varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado' 
when 'D' then 'Deshabilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Deshabilitado')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'D' then 'Deshabilitado' 
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'
end
else if(@Estado='Habilitado')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'
end

GO
/****** Object:  StoredProcedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar2]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar2]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado' 
when 'D' then 'Deshabilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
	Case l.Estado
	when 'H' then 'Habilitado' 
	when 'D' then 'Deshabilitado'
	end as[ESTADO]
	 from LISTA_DE_ANALISIS_LABORATORIO l
	where  l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
	Case l.Estado
	when 'H' then 'Habilitado' 
	when 'D' then 'Deshabilitado'
	end as[ESTADO]
	 from LISTA_DE_ANALISIS_LABORATORIO l
where  l.Nombre_Corto like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'D' then 'Deshabilitado' 
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'D' then 'Deshabilitado' 
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'D' then 'Deshabilitado' 
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select L.Codigo AS[CODIGO], l.Nombre_Corto as[NOMBRE CORTO], l.Descripcion as[DESCRIPCION],
Case l.Estado
when 'H' then 'Habilitado'
end as[ESTADO]
 from LISTA_DE_ANALISIS_LABORATORIO l
where l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LISTA_ESTUDIO_IMAGEN_Buscar_Campo]
 @buscar varchar(40),
 @cbtipos varchar(50),
 @cbestado varchar(50)
 as
 if(@cbtipos='Nombre' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Nombre like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Nombre' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'
end
else if(@cbtipos='Nombre' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='D'
end
---descripcion
else if(@cbtipos='Descripcion' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Descripcion like +'%'+@buscar+'%'
--where u.Usuario like +'%'+@texto+'%'
end
else if(@cbtipos='Descripcion' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Descripcion like +'%'+@buscar+'%' and l.Estado='H'
end
else if(@cbtipos='Descripcion' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Descripcion like +'%'+@buscar+'%' and l.Estado='D'
end
--todos
else if(@cbtipos='Todos' and @cbestado='Todos')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
end
else if(@cbtipos='Todos' and @cbestado='Deshabilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 --when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Nombre  like +'%'+@buscar+'%' and l.Estado='D'  
end
else if(@cbtipos='Todos' and @cbestado='Habilitado')
 begin
select l.Codigo as[#], l.Nombre as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 --when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'  
end
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Cambiar_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_ESTUDIO_IMAGEN_Cambiar_Estado]
@Codigo int,
@Estado char(1)
as
update LISTA_ESTUDIO_IMAGEN set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_ESTUDIO_IMAGEN_Editar]
@Codigo int,
@Nombre char(50),
@Descripcion char(160)
as
update LISTA_ESTUDIO_IMAGEN
set Nombre=@Nombre,
Descripcion=@Descripcion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_ESTUDIO_IMAGEN_Eliminar]
@Codigo int
as
delete from LISTA_ESTUDIO_IMAGEN
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_ESTUDIO_IMAGEN_ID]
@id int
as
select * from LISTA_ESTUDIO_IMAGEN
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LISTA_ESTUDIO_IMAGEN_Mostrar]
as
--select l.Codigo as[CODIGO], l.Nombre_Corto as[NOMBRE], l.Descripcion as[ DESCRIPCIÓN],
-- CASE l.Estado
-- when 'H' THEN 'Habilitado'
-- when 'D' then 'Deshabilitado'
-- end as [ESTADO]
--from LISTA_DE_ANALISIS_LABORATORIO l

select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from LISTA_ESTUDIO_IMAGEN l
GO
/****** Object:  StoredProcedure [dbo].[LISTA_ESTUDIO_IMAGEN_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LISTA_ESTUDIO_IMAGEN_Registrar]
--@Codigo int,
@Nombre char(50),
@Descripcion char(160),
@Estado char(1)
as
insert into LISTA_ESTUDIO_IMAGEN(Nombre,Descripcion,Estado)
values(@Nombre,@Descripcion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[Medico_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Medico_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
	where f.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where  f.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado 
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from Medico f
where f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Medico f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[Medico_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Medico_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update Medico set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Medico_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Medico_Editar]
@Codigo int,
@Nombre char(50),
@Ocupacion char(10),
@N_celular char(8),
@Observacion char(160)
as
update Medico
set Nombre=@Nombre,
Ocupacion=@Ocupacion,
N_Celular=@N_celular,
Observacion=@Observacion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Medico_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Medico_Eliminar]
@Codigo int
as
delete from Medico
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Medico_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Medico_ID]
@id int
as
select * from Medico
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[Medico_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Medico_Mostrar]
as
select f.Codigo as [#],
Rtrim(Ltrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
GO
/****** Object:  StoredProcedure [dbo].[Medico_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Medico_Registrar]
--@Codigo int,
@Nombre char(50),
@Ocupacion char(10),
@N_celular char(8),
@Observacion char(150),
@Estado char(1)
as
insert into Medico(Nombre,Ocupacion,N_Celular,Observacion,Estado)
values(@Nombre,@Ocupacion,@N_celular,@Observacion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[Medico_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Medico_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
	where f.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where  f.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado 
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from Medico f
where f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Medico f
where f.Codigo like +'%'+@buscar /*+'%'*/ and f.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select f.Codigo as [#],
Ltrim(Rtrim(f.Nombre)) as[NOMBRE],
f.Ocupacion as[OCUPACIÓN],
f.N_Celular as[Nº CELULAR],
f.Observacion as [OBSERVACIÓN],
CASE f.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Medico f
where f.Nombre like +'%'+@buscar+'%' and f.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[SALA_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SALA_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
	where s.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where  s.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
 where s.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Codigo like +'%'+@buscar /*+'%'*/ and s.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Nombre like +'%'+@buscar+'%' and s.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Codigo like +'%'+@buscar /*+'%'*/ and s.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Nombre like +'%'+@buscar+'%' and s.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[SALA_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SALA_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update SALA set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[SALA_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SALA_Editar]
@Codigo int,
@Nombre char(50),
@Descripcion char(160),
@CodigoTipo int

as
update SALA
set Nombre=@Nombre,
Descripcion=@Descripcion,
CodigoTipoSala=@CodigoTipo
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[SALA_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SALA_Eliminar]
@Codigo int
as
delete from SALA
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[SALA_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATe proc [dbo].[SALA_ID]
@id int
as
select * from SALA
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[SALA_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SALA_Mostrar]
as
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
GO
/****** Object:  StoredProcedure [dbo].[SALA_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SALA_Registrar]
@CodigoTipo int,
@Nombre char(50),
@Descripcion char(150),
@Estado char(1)
as
insert into SALA(Nombre,Descripcion,Estado,CodigoTipoSala)
values(@Nombre,@Descripcion,@Estado,@CodigoTipo)

GO
/****** Object:  StoredProcedure [dbo].[SALA_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SALA_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
select s.Codigo as[#],rtrim(ltrim(s.Nombre)) as [NOMBRE],ltrim(rtrim(s.Descripcion)) AS [DESCRIPCIÓN]
,rtrim(ltrim(t.Nombre)) AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
	where s.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
	select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where  s.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
 where s.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Codigo like +'%'+@buscar /*+'%'*/ and s.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'D' THEN 'Deshabiitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Nombre like +'%'+@buscar+'%' and s.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Codigo like +'%'+@buscar /*+'%'*/ and s.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select s.Codigo as[#],s.Nombre as [NOMBRE],s.Descripcion AS [DESCRIPCIÓN]
,t.Nombre AS[TIPO SALA], t.Codigo as [CODIGO],
CASE s.Estado
 WHEN 'H' THEN 'Habilitado'
 end
  AS [ESTADO]

 from SALA s inner join Tipos_Sala t on t.Codigo=s.CodigoTipoSala
where s.Nombre like +'%'+@buscar+'%' and s.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[sp_Identity_Codigo_LISTA_ESTUDIO_IMAGEN]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Identity_Codigo_LISTA_ESTUDIO_IMAGEN]
as
declare @Cod_nuevo int
if((select MAX(Codigo) from LISTA_ESTUDIO_IMAGEN)is null)
begin
set @Cod_nuevo=1
end
else 
begin 
set @Cod_nuevo=(select max(Codigo)+1 from LISTA_ESTUDIO_IMAGEN)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INICIO_SESION]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INICIO_SESION]
@Codigo char(50),
@Contraseña char(50)
AS
select o.Codigo,o.Contraseña,o.Nombre_Completo,n.IdPermiso,o.Estado from USUARIOS o 
inner join AsignacionPermiso n on o.Codigo=n.IdUsuario 
inner join  PERMISOS m on m.Codigo=n.IdPermiso
where o.Codigo=@Codigo and o.Contraseña=@Contraseña
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Login]
@usuario varchar(100),
@contra varchar(100)
as
select u.Codigo,u.Nombre_Completo,u.Usuario,u.Contraseña,a.IdPermiso,u.Estado 
from USUARIO u inner join AsigancionPermiso a on a.IdUsuario=u.Codigo
where u.Usuario=@usuario and u.Contraseña=@contra
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRAR_PERMISOS]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_MOSTRAR_PERMISOS]
as
select rtrim(ltrim(p.Codigo)) as [CODIGO],rtrim(ltrim(p.Modulo)) as[MODULO], rtrim(ltrim(p.Descripcion))as[DESCRIPCION],rtrim(ltrim(p.Estado))as[ESTADO]
from PERMISOS p

GO
/****** Object:  StoredProcedure [dbo].[SP_PREUBA]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_PREUBA]
@CODIGO INT
AS
select distinct(p.Descripcion),p.Estado 
from USUARIO u 
inner join AsigancionPermiso a on a.IdUsuario=u.Codigo
inner join PERMISO p on p.Codigo=a.IdUsuario where u.Codigo=@CODIGO
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_lista]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte_lista]

as
select l.Codigo,l.Nombre_Corto,l.Descripcion,l.Estado from LISTA_DE_ANALISIS_LABORATORIO l
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_lista_parametro]    Script Date: 30/10/2020 22:08:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Usuario_Permiso]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Usuario_Permiso]
@texto varchar(40)
as
select a.IdUsuario from USUARIO u inner join AsigancionPermiso a on u.Codigo=a.IdUsuario
where IdUsuario=@texto
GO
/****** Object:  StoredProcedure [dbo].[Tipo_Sala_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Tipo_Sala_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where  l.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[Tipo_Sala_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Tipo_Sala_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
	select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where  l.Nombre like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from Tipos_Sala l
where l.Nombre like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tipos_Sala_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update Tipos_Sala set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Tipos_Sala_Editar]
@Codigo int,
@Nombre char(50),
@Descripcion char(160)
as
update Tipos_Sala
set Nombre=@Nombre,
Descripcion=@Descripcion
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tipos_Sala_Eliminar]
@Codigo int
as
delete from Tipos_Sala
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tipos_Sala_ID]
@id int
as
select * from Tipos_Sala
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tipos_Sala_Mostrar]
as

select l.Codigo as[#], RTRIM(LTRIM(l.Nombre)) as[NOMBRE], RTRIM(LTRIM(l.Descripcion)) as[ DESCRIPCIÓN],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from Tipos_Sala l
GO
/****** Object:  StoredProcedure [dbo].[Tipos_Sala_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tipos_Sala_Registrar]
--@Codigo int,
@Nombre char(50),
@Descripcion char(160),
@Estado char(1)
as
insert into Tipos_Sala(Nombre,Descripcion,Estado)
values(LTRIM(RTRIM(@Nombre)),LTRIM(RTRIM(@Descripcion)),@Estado)
GO
/****** Object:  StoredProcedure [dbo].[Usuario_AsignacionPermiso]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Usuario_AsignacionPermiso]
@texto char(50)
as
select a.IdPermiso from USUARIO u inner join AsigancionPermiso a on a.IdUsuario=u.Codigo where u.Codigo=@texto
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_Cambio_Estado]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USUARIO_Cambio_Estado]
@Codigo int,
@Estado char(1)
as
update USUARIO set Estado=@Estado where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_Eliminar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIO_Eliminar]
@Codigo int
as
delete from USUARIO
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_ID]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIO_ID]
@id char(50)
as
select * from USUARIOS
where
Codigo = @id
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIO_Mostrar]
as
select u.Codigo as [CODIGO],u.Nombre_Completo as[NOMBRE],u.Observacion as[OBSERVACION],
 U.Usuario AS [USUARIO], case u.Contraseña
 when u.Contraseña then '*' end
  as[CONTRASEÑA],
 CASE U.Estado
 WHEN 'H' THEN 'Habilitado'
 WHEN 'D' THEN 'Deshabiitado'
 end
 AS[ESTADO] from USUARIO u
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIO_Registrar]
--@Codigo int,
@Nombre char(50),
@Observacion char(150),
@Usuario char(50),
@Contraseña char(50),
@Estado char(1)
as
insert into USUARIO(Nombre_Completo,Observacion,Estado,Usuario,Contraseña)
values(LTRIM(RTRIM(@Nombre)),LTRIM(RTRIM(@Observacion)),@Estado,rtrim(ltrim(@Usuario)),rtrim(ltrim(@Contraseña)))
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_Buscar_Campo]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USUARIOS_Buscar_Campo]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where  l.Nombre_Completo like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Nombre_Completo like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from USUARIO l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from USUARIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from USUARIO l
where l.Nombre_Completo like +'%'+@buscar+'%' and l.Estado='H'
end


GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_Editar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIOS_Editar]
@Codigo int,
@Nombre char(50),
@Observacion char(150),
@Usuario char(50),
@Contraseña char(50)
as
update USUARIO
set Nombre_Completo=@Nombre,
Observacion=@Observacion,
Usuario=@Usuario,
Contraseña=@Contraseña
where Codigo=@Codigo
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_Mostrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USUARIOS_Mostrar]
as

select rtrim(ltrim(l.Codigo)) as[#],
 RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE],
  RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN],
  LTRIM(RTRIM(l.Contraseña)) as
  [CONTRASEÑA],  
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIOS l
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_Registrar]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USUARIOS_Registrar]
@Codigo char(50),
@Nombre char(50),
@Observacion char(150),
@Contraseña char(50),
@Estado char(1)
as
insert into USUARIOS(Codigo,Nombre_Completo,Observacion,Estado,Contraseña)
values(rtrim(ltrim(@Codigo)),LTRIM(RTRIM(@Nombre)),LTRIM(RTRIM(@Observacion)),@Estado,rtrim(ltrim(@Contraseña)))
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_Reporte]    Script Date: 30/10/2020 22:08:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USUARIOS_Reporte]
 @Estado varchar(15),
 @cbtipo varchar(15),
 @buscar varchar(30)
 as
if(@Estado='Todos' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
--where  l.Nombre_Corto like +'%'+@buscar+'%' and l.Estado='H' OR l.Estado='D'
end
else if(@Estado='Todos' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
	where l.Codigo like +'%'+@buscar /*+'%'*/ /*and l.Estado='H' and l.Estado='D'*/
end
else if(@Estado='Todos' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where  l.Nombre_Completo like +'%'+@buscar+'%'/* and l.Estado='H' OR l.Estado='D'*/
end
------
else if(@Estado='Deshabilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='D'
end
else if(@Estado='Deshabilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'D' then 'Deshabilitado'
 end as [ESTADO]
from USUARIO l
where l.Nombre_Completo like +'%'+@buscar+'%' and l.Estado='D'
end
-------
else if(@Estado='Habilitado' and @cbtipo='Todos')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from USUARIO l
where l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Codigo')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'
 end as [ESTADO]
from USUARIO l
where l.Codigo like +'%'+@buscar /*+'%'*/ and l.Estado='H'
end
else if(@Estado='Habilitado' and @cbtipo='Nombre')
begin
select l.Codigo as[#], RTRIM(LTRIM(l.Nombre_Completo)) as[NOMBRE], RTRIM(LTRIM(l.Observacion)) as[OBSERVACIÓN], LTRIM(Rtrim(l.Usuario)) as [USUARIO],LTRIM(RTRIM(l.Contraseña)) as [CONTRASEÑA],
 CASE l.Estado
 when 'H' THEN 'Habilitado'

 end as [ESTADO]
from USUARIO l
where l.Nombre_Completo like +'%'+@buscar+'%' and l.Estado='H'
end


GO
USE [master]
GO
ALTER DATABASE [BD_CLINICA_SAN_MARTIN_PORRES] SET  READ_WRITE 
GO
