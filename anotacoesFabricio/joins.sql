create table java
(
	professor varchar(20) null
)

create table net
(
	professor varchar(20) null
)

insert into java 
values ('Fabrício'),('Lucas'),('Deivison')

insert into net 
values ('Fabrício'),('Ricardo'),('Alexandre')

--inner join 
select * from java
inner join net
on java.professor = net.professor

--left join
select * from java
left join net
on java.professor = net.professor

--left join exclusivo
select * from java
left join net
on java.professor = net.professor
where net.professor is null

--right join
select * from java
right join net
on java.professor = net.professor

--right join exclusivo
select * from java
right join net
on java.professor = net.professor
where java.professor is null

-- outer join
select * from java
full outer join net
on java.professor = net.professor

-- outer join excluivo
select * from java
full outer join net
on java.professor = net.professor
where java.professor is null
	or net.professor is null
