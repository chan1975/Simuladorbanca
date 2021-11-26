USE [SimuladorBancaDb]
GO

declare 
@w_count1 int
select @w_count1 = 1

while(@w_count1 < 11)
begin
    
	insert into Clientes values(CONCAT('User',@w_count1),CONCAT('Direcction',@w_count1), CONCAT('telefono',@w_count1))

	insert into Cuentas values(18000+@w_count1, 0,@w_count1)
	insert into Cuentas values(18100+@w_count1, 0,@w_count1)

	select @w_count1 = @w_count1 +1

end