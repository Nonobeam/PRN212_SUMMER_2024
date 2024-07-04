USE [master]
GO
/****** Object:  Database [prn_project]    Script Date: 7/4/2024 10:34:33 AM ******/
CREATE DATABASE [prn_project]
 
CREATE TABLE [dbo].[Admin](
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[Time_slotId] [int] NULL,
	[CustomerId] [int] NULL,
	[DentistId] [int] NULL,
	[ServiceId] [int] NULL,
	[clinicid] [int] NULL,
	[available] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [varchar](15) NULL,
	[ManagerId] [int] NULL,
	[available] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dentist]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dentist](
	[UserId] [int] NOT NULL,
	[ClinicId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Time_slot]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time_slot](
	[Id] [int] NOT NULL,
	[Time] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/4/2024 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
	[Password] [nvarchar](255) NULL,
	[UserType] [nvarchar](50) NULL,
	[email] [varchar](225) NULL,
	[available] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clinic] ON 
GO
INSERT [dbo].[Clinic] ([Id], [Name], [Address], [Phone], [ManagerId], [available]) VALUES (1, N'Smile Dental Clinic', N'123 Main St, City', N'5551112222', 3, 1)
GO
INSERT [dbo].[Clinic] ([Id], [Name], [Address], [Phone], [ManagerId], [available]) VALUES (2, N'Bright Smiles Dental', N'456 Oak Rd, Town', N'9991112222', 5, 1)
GO
INSERT [dbo].[Clinic] ([Id], [Name], [Address], [Phone], [ManagerId], [available]) VALUES (6, N'Helpright', N'789 Odals,Green wood', N'9968685766', 18, 1)
GO
SET IDENTITY_INSERT [dbo].[Clinic] OFF
GO
INSERT [dbo].[Customer] ([UserId]) VALUES (1)
GO
INSERT [dbo].[Customer] ([UserId]) VALUES (2)
GO
INSERT [dbo].[Customer] ([UserId]) VALUES (6)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (4, 1)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (8, 1)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (10, 1)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (12, 2)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (13, 2)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (14, 1)
GO
INSERT [dbo].[Dentist] ([UserId], [ClinicId]) VALUES (17, 2)
GO
INSERT [dbo].[Manager] ([UserId]) VALUES (3)
GO
INSERT [dbo].[Manager] ([UserId]) VALUES (5)
GO
INSERT [dbo].[Manager] ([UserId]) VALUES (18)
GO
SET IDENTITY_INSERT [dbo].[Service] ON 
GO
INSERT [dbo].[Service] ([Id], [Name]) VALUES (1, N'Teeth Cleaning')
GO
INSERT [dbo].[Service] ([Id], [Name]) VALUES (2, N'Root Canal Treatment')
GO
INSERT [dbo].[Service] ([Id], [Name]) VALUES (3, N'Tooth Extraction')
GO
INSERT [dbo].[Service] ([Id], [Name]) VALUES (4, N'Dental Implant')
GO
INSERT [dbo].[Service] ([Id], [Name]) VALUES (5, N'Orthodontic Treatment')
GO
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (1, CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (2, CAST(N'09:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (3, CAST(N'10:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (4, CAST(N'11:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (5, CAST(N'12:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (6, CAST(N'13:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (7, CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (8, CAST(N'15:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (9, CAST(N'16:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (10, CAST(N'17:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (11, CAST(N'18:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (12, CAST(N'19:00:00' AS Time))
GO
INSERT [dbo].[Time_slot] ([Id], [Time]) VALUES (13, CAST(N'20:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (1, N'John Doe', N'1234567890', N'password123', N'Customer', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (2, N'Jane Smith', N'9876543210', N'securepass', N'Customer', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (3, N'Michael Johnson', N'5551234567', N'admin123', N'Manager', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (4, N'Emily Davis', N'7778889990', N'dentist456', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (5, N'David Wilson', N'1112223333', N'manager789', N'Manager', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (6, N'Sophia Thompson', N'4445556666', N'patient123', N'Customer', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (7, N'Daniel Anderson', N'7771112222', N'admin456', N'Admin', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (8, N'John Smith', N'1234567890', N'password123', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (9, N'Emily Davis', N'9876543210', N'dentist456', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (10, N'Michael Johnson', N'5551234567', N'mjohnson', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (11, N'Samantha Wilson', N'7778889990', N'swilson123', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (12, N'David Thompson', N'1112223333', N'dthompson', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (13, N'Jessica Anderson', N'4445556666', N'janderson', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (14, N'Robert Brown', N'7771112222', N'rbrown456', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (15, N'Olivia Taylor', N'8889990000', N'otaylor123', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (16, N'William Clark', N'2223334444', N'wclark789', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (17, N'Sophia Martinez', N'5556667777', N'smartinez', N'Dentist', NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [UserType], [email], [available]) VALUES (18, N'Emma alley', N'3462634654', N'88888888', N'Manager', NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Appointment] ADD  DEFAULT ((1)) FOR [available]
GO
ALTER TABLE [dbo].[Clinic] ADD  DEFAULT ((1)) FOR [available]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((1)) FOR [available]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([UserId])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([DentistId])
REFERENCES [dbo].[Dentist] ([UserId])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([Time_slotId])
REFERENCES [dbo].[Time_slot] ([Id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [fk_clinic] FOREIGN KEY([clinicid])
REFERENCES [dbo].[Clinic] ([Id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [fk_clinic]
GO
ALTER TABLE [dbo].[Clinic]  WITH CHECK ADD FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Manager] ([UserId])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Dentist]  WITH CHECK ADD FOREIGN KEY([ClinicId])
REFERENCES [dbo].[Clinic] ([Id])
GO
ALTER TABLE [dbo].[Dentist]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
USE [master]
GO
ALTER DATABASE [prn_project] SET  READ_WRITE 
GO
