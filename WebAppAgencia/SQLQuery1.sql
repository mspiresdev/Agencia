select * from TipoPessoa
select * from Pessoa
select * from Reserva
delete Reserva
delete pessoa where id in(3,4,5) 
delete TipoPessoa where id in(4,5,6) 
select * from itinerario
delete itinerario where id in(3,4) 

insert into TipoPessoa values ('Cliente',getdate(),1,getdate())
insert into TipoPessoa values ('Fornecedor',getdate(),1,getdate())
insert into TipoPessoa values ('Agência',getdate(),1,getdate())