-- Tao ham
Create function sinhkhoa () returns char(6) As
Begin 
	declare @max int 
	select 
	@max = max(cast(substring(MAHS,4,5) as int)) + 1
	from DSHS
	declare @s char(8)
	set @s = '0000' + (cast(@max as char(5)))
	set @s = 'UTC' + right(rtrim(@s), 5)
return @s
end

-- -------------------------------------
Create function laydshs (@malop char(5))
returns table
as return
(
	select mahs, ten from dshs where malop = @malop
)

select * from laydshs('10A2')