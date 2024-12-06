use Assignment

-------------------------------------------------1---------------------------------------------
CREATE PROCEDURE GeneratePayslip
   @EmployeeID INT
AS
BEGIN
   
   Declare @Name NVARCHAR(100);
   Declare @Salary DECIMAL(18, 2);
   Declare @HRA DECIMAL(18, 2);
   Declare @DA DECIMAL(18, 2);
   Declare @PF DECIMAL(18, 2);
   Declare @IT DECIMAL(18, 2);
   Declare @Deductions DECIMAL(18, 2);
   Declare @GrossSalary DECIMAL(18, 2);
   Declare @NetSalary DECIMAL(18, 2);
   
   SELECT
       @Name = Ename,
       @Salary = Sal
   FROM EMP
   WHERE Empno = @EmployeeID;
   
   IF @Name IS NULL
   BEGIN
       PRINT 'Error: Employee not found.';
       RETURN;
   END
  
   Set @HRA = @Salary * 0.10; 
   Set @DA = @Salary * 0.20;  
   Set @PF = @Salary * 0.08;   
   Set @IT = @Salary * 0.05;  

   Set @Deductions = @PF + @IT; -- Sum of PF and IT
   Set @GrossSalary = @Salary + @HRA + @DA; -- Salary + HRA + DA
	
   Set @NetSalary = @GrossSalary - @Deductions; -- Gross Salary - Deductions
   -- Print the payslip
   
   Print '-------------------------------';
   Print '          Payslip              ';
   Print '-------------------------------';
   Print 'Employee ID  : ' + CAST(@EmployeeID AS NVARCHAR);
   Print 'Name         : ' + @Name;
   Print 'Base Salary  : ' + CAST(@Salary AS NVARCHAR);
   Print 'HRA (10%)    : ' + CAST(@HRA AS NVARCHAR);
   Print 'DA (20%)     : ' + CAST(@DA AS NVARCHAR);
   Print 'PF (8%)      : ' + CAST(@PF AS NVARCHAR);
   Print 'IT (5%)      : ' + CAST(@IT AS NVARCHAR);
   Print 'Deductions   : ' + CAST(@Deductions AS NVARCHAR);
   Print 'Gross Salary : ' + CAST(@GrossSalary AS NVARCHAR);
   Print 'Net Salary   : ' + CAST(@NetSalary AS NVARCHAR);
   Print '-------------------------------';
END;


exec GeneratePayslip @EmployeeID=7369;
------------------------------------------------------------2----------------------------------------------------

select * from EMP
 
create table Holidays (
    holiday_date date primary key,
    holiday_name varchar(20) NOT NULL
);
insert into Holidays (holiday_date, holiday_name) values
('2024-01-26', 'Republic Day'),
('2024-03-29', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-11-12', 'Diwali');
insert into holidays values('2024-12-06','Holiday');

create or alter trigger RestrictManipulationOnHolidays
ON EMP
for insert,update,delete
as
begin
    declare @holiday_name varchar(20);
	declare @current_date date = cast(getdate() as date)
    select @holiday_name =holiday_name
    from Holidays
    where holiday_date = @current_date;
    if @holiday_name IS NOT NULL
	begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		rollback transaction
    end
end
update EMP set Sal=1000 where EmpNo=7369


