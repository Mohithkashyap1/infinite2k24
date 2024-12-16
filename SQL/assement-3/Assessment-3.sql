create database Assessment_2_SQL

use Assignment


create table EMP1                    
(
Empno int primary key,
Ename varchar,
job varchar,
Mgr_id int ,
Hiredate date ,
Sal int ,
Comm int,
Deptno int references DEPT(Deptno)
)

Alter table EMP1                       
Alter  COLUMN Ename varchar(50)
Alter table EMP1
Alter  COLUMN job varchar(50)

insert into EMP1
values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80' , 800 ,null ,20),
	   (7499,'ALLEN','SALESMAN',7698, '20-FEB-81', 1600,300 ,30),
		(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500 , 30),
		(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975,null, 20),
		(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250,1400, 30),
		(7698, 'BLAKE','MANAGER',7839, '01-MAY-81', 2850 ,null,30),
		(7782, 'CLARK','MANAGER', 7839, '09-JUN-81', 2450 ,null, 10),
		(7788,'SCOTT','ANALYST', 7566 ,'19-APR-87',3000, null, 20),
		(7839, 'KING','PRESIDENT',null,'17-NOV-81',5000 ,null,10),
		(7844, 'TURNER','SALESMAN',7698, '08-SEP-81',1500, 0, 30),
		(7876, 'ADAMS', 'CLERK', 7788,'23-MAY-87', 1100,null, 20),
		(7900, 'JAMES', 'CLERK', 7698,'03-DEC-81',950,null, 30),
		(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81',3000,null, 20),
		(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82',1300,null, 10)


select *from EMP1                 
sp_help EMP1                      

create table DEPT1                 
(
Deptno int primary key,
Dept_name varchar not null,
loc varchar
)

Alter table DEPT1                   
Alter  COLUMN Dept_name varchar(50)
Alter table DEPT1
Alter  COLUMN loc varchar(50)

insert into DEPT1                   
values (10,'ACCOUNTING','NEW YORK' ),
	   (20, 'RESEARCH', 'DALLAS' ),
	   (30, 'SALES', 'CHICAGO' ),
	   (40, 'OPERATIONS','BOSTON' )



select * from DEPT1            
sp_help DEPT1                    


-- 6

CREATE PROCEDURE UpdateSalary
as
begin

	BEGIN transaction;

	update Emp1
	set Sal=Sal+500
	where Dept_name = 'Sales'
             and Sal<1500;

	if @@ERROR = 0
	Begin
		Commit transaction;
		print'Salaries updates successfully';
	end
	else 
	begin
		rollback transaction;
		print 'error occurred';
	end
end;

Exec UpdateSalary

--5
Create Function dbo.CalculateBonus(@Deptno int,@Salary DECIMAL(10,2))
Returns DECIMAL(10,2)
As
Begin
	Declare @Bonus DECIMAL(10,2);

	if @Deptno = 10
		set @Bonus = @Salary * 0.15;
	ELSE IF @Deptno = 20
		set @Bonus = @Salary * 0.20;
	ELSE 
		set @Bonus = @Salary * 0.05;
	Return @Bonus;
END;

--2

select Empno,Ename,sal,dbo.CalculateBonus(deptno,Sal) From EMP1
where Deptno = 10;

--3
select Empno,Ename,sal,dbo.CalculateBonus(deptno,Sal) as Bonus From EMP1



--4

BEGIN TRANSACTION;

INSERT INTO EMP1(empno, ename, sal,Hiredate)
VALUES (1, 'John', 1000, '2022-01-01'),
      (2, 'Harvey', 2000, '2021-06-15'),
      (3, 'Mike', 1500, '2020-11-20');
-- Update the salary of the second row 

UPDATE EMP1
SET sal = sal * 1.15
WHERE empno = 2;

DELETE FROM EMP1
WHERE empno = 1;

-- Recall the deleted row 

DECLARE @DeletedRow TABLE (
   empno INT,
   ename VARCHAR(50),
   sal DECIMAL(10, 2),
   doj DATE
);
-- Insert the deleted row into the temporary table
INSERT INTO @DeletedRow
SELECT 1, 'John', 1000, '2022-01-01';

-- Reinsert the deleted row into the Employee table

INSERT INTO EMP1(empno, ename, sal,Hiredate)
SELECT empno, ename, sal, doj FROM @DeletedRow;

COMMIT TRANSACTION;


SELECT * FROM EMP1;

--1

select DATENAME(weekday,'2002-05-02') as [day_of_week]
 
 
--2
 
select DATEDIFF(Day,'2002-05-02',GETDATE()) as [Age_in_days]
 
 --3

 select * from EMP where DATEDIFF(Year,hiredate,getdate())>5