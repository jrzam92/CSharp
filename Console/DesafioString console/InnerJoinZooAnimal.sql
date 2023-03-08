select * from Animal
select * From Zoo

select * from Zoo z
inner join AnimalZoo az
on az.ZooID=3
inner Join Animal a
on az.AnimalId=a.Id


select * from Zoo z inner join AnimalZoo az on az.ZooID=z.Id inner Join Animal a on az.AnimalId=a.Id where z.Id=5

delete from AnimalZoo where AnimalID = (@AnimalId)

