/*
insert into Pizzas (Id, Nombre) values (1, 'Margarita');
insert into Pizzas (Id, Nombre) values (2, 'Carbonara');
insert into Pizzas (Id, Nombre) values (3, 'Barbacoa');
insert into Pizzas (Id, Nombre) values (4, 'Mediterranea');

insert into Ingredientes (Id, Nombre, Precio) values (1, 'Queso', 2.5);
insert into Ingredientes (Id, Nombre, Precio) values (2, 'Tomate', 1.5);
insert into Ingredientes (Id, Nombre, Precio) values (3, 'Bacon', 3.5);

insert into PizzaIngrediente (IdPizza, IdIngrediente) values (1, 1);
insert into PizzaIngrediente (IdPizza, IdIngrediente) values (1, 2);
insert into PizzaIngrediente (IdPizza, IdIngrediente) values (2, 1);
insert into PizzaIngrediente (IdPizza, IdIngrediente) values (3, 3);
*/

select * from Ingredientes;
select * from Pizzas;
select * from PizzaIngrediente;

select P.Id, P.Nombre, sum(I.Precio) as Precio
from Pizzas P
join PizzaIngrediente PI on PI.IdPizza=P.Id
join Ingredientes I on I.Id = PI.IdIngrediente
group by P.Id, P.Nombre

select P.Id, P.Nombre
from Pizzas P
left join PizzaIngrediente PI on PI.IdPizza=P.Id
 where PI.IdIngrediente is null
group by P.Id, P.Nombre