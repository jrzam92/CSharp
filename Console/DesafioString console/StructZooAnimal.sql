﻿drop table dbo.AnimalZoo
drop table dbo.Zoo
drop table dbo.Animal
 
CREATE TABLE [dbo].[Zoo] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Ubicación] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
 
CREATE TABLE [dbo].[Animal] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
 
CREATE TABLE [dbo].[AnimalZoo] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [ZooID]    INT NOT NULL,
    [AnimalId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AnimalCE] FOREIGN KEY ([AnimalId]) REFERENCES [dbo].[Animal] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [ZooCE] FOREIGN KEY ([ZooID]) REFERENCES [dbo].[Zoo] ([Id]) ON DELETE CASCADE
);
 
insert into dbo.Zoo values ('New York')
insert into dbo.Zoo values ('Tokyo')
insert into dbo.Zoo values ('Berlin')
insert into dbo.Zoo values ('Kairo')
insert into dbo.Zoo values ('Milan')
 
insert into dbo.Animal values ('Tiburón')
insert into dbo.Animal values ('Pulpo')
insert into dbo.Animal values ('Mono')
insert into dbo.Animal values ('Pantera')
insert into dbo.Animal values ('León')
insert into dbo.Animal values ('Cocodrilo')
insert into dbo.Animal values ('Cóndor')
insert into dbo.Animal values ('Loro')
 
insert into dbo.AnimalZoo values (1,1)
insert into dbo.AnimalZoo values (1,2)
insert into dbo.AnimalZoo values (2,3)
insert into dbo.AnimalZoo values (2,4)
insert into dbo.AnimalZoo values (3,5)
insert into dbo.AnimalZoo values (3,6)
insert into dbo.AnimalZoo values (4,7)
insert into dbo.AnimalZoo values (4,8)
insert into dbo.AnimalZoo values (5, 1)
insert into dbo.AnimalZoo values (5, 2)
insert into dbo.AnimalZoo values (5, 3)
insert into dbo.AnimalZoo values (5, 4)
insert into dbo.AnimalZoo values (5, 5)
insert into dbo.AnimalZoo values (5, 6)
insert into dbo.AnimalZoo values (5, 7)
insert into dbo.AnimalZoo values (5, 8)


