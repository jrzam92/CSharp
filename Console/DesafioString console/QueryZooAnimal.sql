select a.Nombre from Animal a
inner join AnimalZoo az
on az.Id=a.Id
where az.ZooId=1
