CREATE TABLE [dbo].Estudiante
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Genero] NVARCHAR(50) NOT NULL, 
    [UniversidadId] INT NOT NULL, 
    CONSTRAINT [UniversidadCE] FOREIGN KEY ([UniversidadId]) REFERENCES [dbo].[Universidad]([id]) ON DELETE CASCADE
)
