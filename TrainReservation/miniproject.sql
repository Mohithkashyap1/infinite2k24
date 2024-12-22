CREATE DATABASE TrainReservation;
USE TrainReservation;

-- Table for Train Details
CREATE TABLE Trains (
    TrainNo INT PRIMARY KEY,
    TrainName NVARCHAR(50),
    Class NVARCHAR(50),
    TotalBerths INT,
    AvailableBerths INT,
    Source NVARCHAR(50),
    Destination NVARCHAR(50),
	PricePerSeat DECIMAL(10, 2),
    IsActive BIT DEFAULT 1
);

-- Table for User Details
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50),
    Password NVARCHAR(50),
    IsAdmin BIT
);

-- Table for Bookings
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY,
    UserID INT,
    TrainNo INT,
    Class NVARCHAR(50),
    BerthsBooked INT,
    BookingDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TrainNo) REFERENCES Trains(TrainNo)
);

-- Table for Cancellations
CREATE TABLE Cancellations (
    CancellationID INT PRIMARY KEY IDENTITY,
    BookingID INT,
    CancellationDate DATETIME DEFAULT GETDATE(),
    RefundAmount DECIMAL(10, 2),
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
);

-- Admin: Add Train
CREATE or ALTER PROCEDURE AddTrain
    @TrainNo INT,
    @TrainName NVARCHAR(50),
    @Class NVARCHAR(50),
    @TotalBerths INT,
    @Source NVARCHAR(50),
    @Destination NVARCHAR(50),
	@PricePerSeat DECIMAL(10, 2) 
AS
BEGIN
    INSERT INTO Trains (TrainNo, TrainName, Class, TotalBerths, AvailableBerths, Source, Destination,PricePerSeat)
    VALUES (@TrainNo, @TrainName, @Class, @TotalBerths, @TotalBerths, @Source, @Destination, @PricePerSeat);
    PRINT 'Train added successfully.';
END;

-- Admin: Modify Train
CREATE or ALTER PROCEDURE ModifyTrain
    @TrainNo INT,
    @TrainName NVARCHAR(50),
    @Class NVARCHAR(50),
    @TotalBerths INT,
    @Source NVARCHAR(50),
    @Destination NVARCHAR(50),
	@PricePerSeat DECIMAL(10, 2), 
    @IsActive BIT
AS
BEGIN
    UPDATE Trains
    SET TrainName = @TrainName,
        Class = @Class,
        TotalBerths = @TotalBerths,
        AvailableBerths = @TotalBerths,
        Source = @Source,
        Destination = @Destination,
        IsActive = @IsActive,
		PricePerSeat= @PricePerSeat
    WHERE TrainNo = @TrainNo;
    PRINT 'Train modified successfully.';
END;

-- Admin: Soft Delete Train
CREATE or Alter PROCEDURE DeleteTrain
    @TrainNo INT
AS
BEGIN
    UPDATE Trains
    SET IsActive = 0
    WHERE TrainNo = @TrainNo;
    PRINT 'Train deactivated successfully.';
END;

-- User: Book Tickets
CREATE or alter PROCEDURE BookTickets
    @UserID INT,
    @TrainNo INT,
    @Class NVARCHAR(50),
    @Berths INT
AS
BEGIN
    DECLARE @AvailableBerths INT,@PricePerSeat DECIMAL(10, 2), @TotalCost DECIMAL(10, 2);

    SELECT @AvailableBerths = AvailableBerths,@PricePerSeat = PricePerSeat
    FROM Trains
    WHERE TrainNo = @TrainNo AND Class = @Class AND IsActive = 1;

    IF @AvailableBerths < @Berths
    BEGIN
        PRINT 'Insufficient berths available.';
        RETURN;
    END

	 -- Calculate total cost
    SET @TotalCost = @Berths * @PricePerSeat;

    UPDATE Trains
    SET AvailableBerths = AvailableBerths - @Berths
    WHERE TrainNo = @TrainNo AND Class = @Class;

    INSERT INTO Bookings (UserID, TrainNo, Class, BerthsBooked)
    VALUES (@UserID, @TrainNo, @Class, @Berths);

    PRINT 'Booking successful. Total cost: ' + CAST(@TotalCost AS NVARCHAR(50));

END

-- User: Cancel Tickets
CREATE or alter PROCEDURE CancelTickets
    @BookingID INT
AS
BEGIN
    DECLARE @TrainNo INT, @Class NVARCHAR(50), @Berths INT, @PricePerSeat DECIMAL(10, 2), @RefundAmount DECIMAL(10, 2);

    SELECT @TrainNo = TrainNo, @Class = Class, @Berths = BerthsBooked
    FROM Bookings
    WHERE BookingID = @BookingID;

    IF @TrainNo IS NULL
    BEGIN
        PRINT 'Invalid booking ID.';
        RETURN;
    END

    UPDATE Trains
    SET AvailableBerths = AvailableBerths + @Berths
    WHERE TrainNo = @TrainNo AND Class = @Class;

    --SET @RefundAmount = @Berths * 100; -- Assume a fixed refund amount per berth
	SELECT @PricePerSeat = PricePerSeat
    FROM Trains
    WHERE TrainNo = @TrainNo;
	SET @RefundAmount = @Berths * @PricePerSeat;
    INSERT INTO Cancellations (BookingID, RefundAmount)
    VALUES (@BookingID, @RefundAmount);

    DELETE FROM Bookings
    WHERE BookingID = @BookingID;

    PRINT 'Cancellation successful. Refund amount: ' + CAST(@RefundAmount AS NVARCHAR(50));
END;

-- User: Show All Trains
CREATE or ALTER PROCEDURE CheckTrainAvailability
AS
BEGIN
    SELECT TrainNo, TrainName, Class, Source, Destination, AvailableBerths,PricePerSeat
    FROM Trains
    WHERE IsActive = 1;
END;

-- User: Show Booking/Cancellation
CREATE or alter PROCEDURE ShowBookingCancellation
    @UserID INT
AS
BEGIN
    SELECT B.BookingID, B.TrainNo, B.Class, B.BerthsBooked, B.BookingDate, 
           C.CancellationDate, C.RefundAmount
    FROM Bookings B
    LEFT JOIN Cancellations C ON B.BookingID = C.BookingID
    WHERE B.UserID = @UserID;
END;

-- Insert Sample Data
INSERT INTO Users (Username, Password, IsAdmin) VALUES ('admin1', 'Ind@2024', 1);
INSERT INTO Users (Username, Password, IsAdmin) VALUES ('user1', 'Virat@Kohli', 0);

INSERT INTO Trains (TrainNo, TrainName, Class, TotalBerths, AvailableBerths, Source, Destination, IsActive,PricePerSeat)
VALUES 
(4025, 'Rajdhani Express', 'Sleeper', 100, 100, 'Bengaluru', 'Delhi', 1,2500.00),
(4080, 'Vande Bharath', 'AC 1st Class', 100, 100, 'Mumbai', 'Gujrat', 1,2100.00);


-- Testing Admin and User Functionality
 EXEC AddTrain @TrainNo = 5018, @TrainName = 'Shatabdi Express', @Class = 'Second', @TotalBerths = 150, @Source = 'Bengaluru', @Destination = 'Vizag', @PricePerSeat=700.00;
 EXEC ModifyTrain @TrainNo = 4080, @TrainName = 'Vande Bharath', @Class = 'AC 1st Class', @TotalBerths = 120, @Source = 'Mumbai', @Destination = 'Chennai', @IsActive = 1,@PricePerSeat=1500.00;
 EXEC DeleteTrain @TrainNo = 12756;
 EXEC BookTickets @UserID = 2, @TrainNo = 4080, @Class = '1st Class', @Berths = 2;
 EXEC CancelTickets @BookingID = 1;
 EXEC CheckTrainAvailability;
 EXEC ShowBookingCancellation @UserID = 2;

select * from Bookings

select * from Cancellations
