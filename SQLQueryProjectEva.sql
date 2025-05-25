USE [master]
GO
/****** Object:  Database [WALLE_LABS]    Script Date: 21/05/2022 08:06:30 p. m. ******/
CREATE DATABASE [WALLE_LABS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WALLE_LABS', FILENAME = N'F:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WALLE_LABS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WALLE_LABS_log', FILENAME = N'F:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WALLE_LABS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WALLE_LABS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WALLE_LABS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WALLE_LABS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WALLE_LABS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WALLE_LABS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WALLE_LABS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WALLE_LABS] SET ARITHABORT OFF 
GO
ALTER DATABASE [WALLE_LABS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WALLE_LABS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WALLE_LABS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WALLE_LABS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WALLE_LABS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WALLE_LABS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WALLE_LABS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WALLE_LABS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WALLE_LABS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WALLE_LABS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WALLE_LABS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WALLE_LABS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WALLE_LABS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WALLE_LABS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WALLE_LABS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WALLE_LABS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WALLE_LABS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WALLE_LABS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WALLE_LABS] SET  MULTI_USER 
GO
ALTER DATABASE [WALLE_LABS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WALLE_LABS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WALLE_LABS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WALLE_LABS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WALLE_LABS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WALLE_LABS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WALLE_LABS] SET QUERY_STORE = OFF
GO
USE [WALLE_LABS]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[num_cliente] [int] NOT NULL,
	[nom_residencia] [varchar](30) NOT NULL,
	[nom_cliente] [varchar](30) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[correo] [varchar](20) NOT NULL,
	[servicios] [varchar](40) NOT NULL,
	[equipo_adicional] [varchar](90) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[num_material] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[cantidad] [int] NOT NULL,
	[area_pertenecen] [varchar](30) NOT NULL,
	[num_servicio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REGISTRO_PEDIDO]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REGISTRO_PEDIDO](
	[num_pedido] [int] NOT NULL,
	[servicio] [varchar](30) NOT NULL,
	[fecha] [date] NOT NULL,
	[num_cliente] [int] NOT NULL,
	[num_servicio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICIOS]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICIOS](
	[num_servicio] [int] NOT NULL,
	[nom_servicio] [varchar](30) NOT NULL,
	[descripcion] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRABAJADORES]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRABAJADORES](
	[num_trabajador] [int] NOT NULL,
	[nom_apellidos] [varchar](30) NOT NULL,
	[curp] [varchar](20) NOT NULL,
	[direccion] [varchar](40) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[area_trabajo] [varchar](30) NOT NULL,
	[salario_hora] [int] NOT NULL,
	[salario_hora_extra] [int] NOT NULL,
	[num_servicio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[num_trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO_CONTRASEÑA]    Script Date: 21/05/2022 08:06:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO_CONTRASEÑA](
	[usuario] [int] NOT NULL,
	[contraseña] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (1, N'LOS PARQUES #208', N'IVAN COLUNGA DAVALOS', N'81 3678 6765', N'IvanColung@gmail.com', N'', N'')
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (2, N'VERANDA #102', N'KARINA ROBLERO RAMOS', N'81 7853 5636', N'KarinaRRS@gmail.com', N'', N'')
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (3, N'LAS LOMAS #304', N'YOEL ZAPATA RANGEL', N'81 7654 8754', N'YZRangel@gmail.com', N'', N'')
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (4, N'CUMBRES PLATINUM #257', N'URIEL ALEJANDRO PEREZ REYNA', N'81 1232 6787', N'UrielPKing@gmail.com', N'', N'')
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (5, N'MITRAS BICENTENARIO #194', N'RUBEN GARZA MENDOZA', N'81 2133 4567', N'rubsGM@gmail.com', N'', N'')
GO
INSERT [dbo].[CLIENTE] ([num_cliente], [nom_residencia], [nom_cliente], [telefono], [correo], [servicios], [equipo_adicional]) VALUES (12, N'', N'GUILLERMO', N'12345657', N'GUILLE@GMAIL.COM', N'CABLEADO', N'')
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (1, N'PANTALLA SAMSUNG', 7, N'VIDEO', 3)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (2, N'CAMARA DE VIGILANCIA', 6, N'CIRCUITO CERRADO', 8)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (3, N'HOME THEATER', 2, N'AUDIO', 2)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (4, N'VIDEO PORTERO', 4, N'TELEFONIA Y CONTROL DE ACCESOS', 6)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (5, N'BOCINAS SONOS', 6, N'AUDIO', 2)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (6, N'SWITCH', 8, N'RED DE DATOS', 5)
GO
INSERT [dbo].[INVENTARIO] ([num_material], [nombre], [cantidad], [area_pertenecen], [num_servicio]) VALUES (7, N'SUNWOOFER', 4, N'AUDIO', 2)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (1, N'AUDIO', CAST(N'2021-09-17' AS Date), 1, 2)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (2, N'VIDEO', CAST(N'2021-10-20' AS Date), 2, 3)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (3, N'AUDIO', CAST(N'2021-10-20' AS Date), 2, 2)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (4, N'CONTROL DE ILUMINACION', CAST(N'2021-10-25' AS Date), 3, 4)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (5, N'TELEFONIA Y CONTROL DE ACCESOS', CAST(N'2021-11-02' AS Date), 4, 6)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (6, N'CONTROL', CAST(N'2021-11-02' AS Date), 4, 7)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (7, N'CONTROL', CAST(N'2021-11-07' AS Date), 1, 7)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (8, N'CIRCUITO CERRADO', CAST(N'2021-12-15' AS Date), 5, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (9, N'CIRCUITO CERRADO', CAST(N'2022-04-10' AS Date), 5, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (10, N'TELEFONIA Y CONTROL DE ACCESOS', CAST(N'2022-04-06' AS Date), 5, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (12, N'CABLEADO', CAST(N'2022-03-12' AS Date), 12, 1)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (78, N'AUDIO', CAST(N'2022-05-08' AS Date), 3, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (79, N'CONTROL', CAST(N'2022-05-08' AS Date), 24, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (100, N'Audio', CAST(N'2022-05-07' AS Date), 1, 6)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (123, N'CABLEADO', CAST(N'2022-04-29' AS Date), 1, 8)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (200, N'Audio', CAST(N'2022-05-07' AS Date), 34, 6)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (1234, N'RED DE DATOS', CAST(N'2022-04-16' AS Date), 1234, 5)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (12345, N'CABLEADO', CAST(N'2022-04-16' AS Date), 1234, 1)
GO
INSERT [dbo].[REGISTRO_PEDIDO] ([num_pedido], [servicio], [fecha], [num_cliente], [num_servicio]) VALUES (123456, N'INGENIERIA', CAST(N'2022-05-02' AS Date), 1, 9)
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (1, N'CABLEADO', N'Cableado estructurado para voz, datos, audio, CCTV, video')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (2, N'AUDIO', N'Suministro e instalación de equipo de audio ambiental: bocinas, amplificadores, fuentes de audio, etc.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (3, N'VIDEO', N'Suministro e instalación de equipo de distribución de video: matriciales de video, extenders de video, fuentes de video, e interconexión de equipo.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (4, N'CONTROL DE ILUMINACION', N'Suministro e instalación de equipos de control de iluminación: dimers, switches, módulos de potencia d fase adaptativa, procesadores y antenas expansoras.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (5, N'RED DE DATOS', N'Suministro e instalación de equipo para distribución de internet: switches, Access points, cables de parcheo, interconexión y configuración de equipos.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (6, N'TELEFONIA Y CONTROL DE ACCESOS', N'Suministro e instalación de equipos de telefonía: conmutadores analógicos e ip, porteros y video porteros; Suministros e instalación de equipos de instalación de accesos y asistencia: cerraduras de seguridad y botones de salida.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (7, N'CONTROL', N'Suministros e instalación de equipos de automatización: procesadores, emisores y receptores de infrarrojo, controladores via ip e interfaces a equipos de video, audio y control de iluminación.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (8, N'CIRCUITO CERRADO', N'Suministro e instalación de equipos de circuito cerrado: cámaras analógicas e ip, DVR,NVR, monitores.')
GO
INSERT [dbo].[SERVICIOS] ([num_servicio], [nom_servicio], [descripcion]) VALUES (9, N'INGENIERIA', N'Levantamiendo y cuantificación de materiales, diseños de planos con trayectorias e infrestructura para cableado estrcturado.')
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (1, N'JEHU CONTRERAS MARTINEZ', N'JHSD232323HGJGDSA3', N'PARQUES DIAMANTE #208', N'81 8723 5423', N'CABLEADO', 100, 110, 1)
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (2, N'RAUL TORRES GARCIA', N'GFXD343554HGVDFDW4', N'MINAS #107', N'81 5423 6534', N'CONTROL DE ILUMINACION', 100, 110, 4)
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (3, N'ADRIAN HERNANDEZ LIMA', N'XDFG876887SDFREWA5', N'LAS LOMAS #214', N'81 5764 3314', N'CONTROL', 60, 80, 7)
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (4, N'LUIS GUTIERREZ ZUÑIGA', N'HTGD675421IUYDASA2', N'LAS VILLAS #126', N'81 8675 4234', N'VIDEO', 60, 70, 3)
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (5, N'JUAN DOMINGUEZ MORENO', N'DSER543612HDRFTDE8', N'VALLE DE LINCOLN ELITE #506', N'81 6433 7645', N'AUDIO', 60, 70, 2)
GO
INSERT [dbo].[TRABAJADORES] ([num_trabajador], [nom_apellidos], [curp], [direccion], [telefono], [area_trabajo], [salario_hora], [salario_hora_extra], [num_servicio]) VALUES (24, N'GUILLERMO BAUTISTA HERNÁNDEZ', N'BAHG040524HNLTRLA9', N'CALLE #2', N'81 323 666 28', N'CABLEADO', 100, 150, 1)
GO
INSERT [dbo].[USUARIO_CONTRASEÑA] ([usuario], [contraseña]) VALUES (1, N'J')
GO
INSERT [dbo].[USUARIO_CONTRASEÑA] ([usuario], [contraseña]) VALUES (10011, N'CONTROL98')
GO
INSERT [dbo].[USUARIO_CONTRASEÑA] ([usuario], [contraseña]) VALUES (10012, N'CONTROL99')
GO
INSERT [dbo].[USUARIO_CONTRASEÑA] ([usuario], [contraseña]) VALUES (10013, N'CONTROL100')
GO
USE [master]
GO
ALTER DATABASE [WALLE_LABS] SET  READ_WRITE 
GO
