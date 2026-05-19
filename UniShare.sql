CREATE DATABASE UniShare_DB;
GO
USE UniShare_DB;

CREATE TABLE Users(
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    UniversityId NVARCHAR(50) NOT NULL UNIQUE,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(30),
    PasswordHash NVARCHAR(256) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'User',
    TrustScore DECIMAL(5,2) DEFAULT 100,
    ReliabilityScore DECIMAL(5,2) DEFAULT 100,
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE RideRequests (
    RideRequestId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    PickupLocation NVARCHAR(150) NOT NULL,
    Destination NVARCHAR(150) NOT NULL,
    RideDateTime DATETIME NOT NULL,
    VehicleType NVARCHAR(20) NOT NULL,
    DistanceKm DECIMAL(6,2) NOT NULL,
    OriginalFare DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(30) DEFAULT 'Pending',
    CreatedAt DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_RideRequests_Users 
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE RideGroups (
    GroupId INT IDENTITY(1,1) PRIMARY KEY,
    CreatedByUserId INT NOT NULL,
    PickupArea NVARCHAR(150) NOT NULL,
    Destination NVARCHAR(150) NOT NULL,
    VehicleType NVARCHAR(20) NOT NULL,
    RideDateTime DATETIME NOT NULL,
    TotalFare DECIMAL(10,2) NOT NULL,
    MaxSeats INT NOT NULL,
    CurrentSeats INT DEFAULT 0,
    Status NVARCHAR(30) DEFAULT 'Open',
    CreatedAt DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_RideGroups_Users 
    FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId)
);

CREATE TABLE GroupMembers (
    GroupMemberId INT IDENTITY(1,1) PRIMARY KEY,
    GroupId INT NOT NULL,
    UserId INT NOT NULL,
    RideRequestId INT NULL,
    SharedFare DECIMAL(10,2) NOT NULL,
    JoinedAt DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_GroupMembers_Groups 
    FOREIGN KEY (GroupId) REFERENCES RideGroups(GroupId),

    CONSTRAINT FK_GroupMembers_Users 
    FOREIGN KEY (UserId) REFERENCES Users(UserId),

    CONSTRAINT FK_GroupMembers_RideRequests 
    FOREIGN KEY (RideRequestId) REFERENCES RideRequests(RideRequestId),

    CONSTRAINT UQ_Group_User UNIQUE(GroupId, UserId)
);

CREATE TABLE Ratings (
    RatingId INT IDENTITY(1,1) PRIMARY KEY,
    RatedByUserId INT NOT NULL,
    RatedUserId INT NOT NULL,
    GroupId INT NOT NULL,
    Stars INT NOT NULL CHECK (Stars BETWEEN 1 AND 5),
    Comment NVARCHAR(300),
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (RatedByUserId) REFERENCES Users(UserId),
    FOREIGN KEY (RatedUserId) REFERENCES Users(UserId),
    FOREIGN KEY (GroupId) REFERENCES RideGroups(GroupId)
);

CREATE TABLE Notifications (
    NotificationId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    Message NVARCHAR(300) NOT NULL,
    Type NVARCHAR(50),
    IsRead BIT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE Payments (
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    GroupId INT NOT NULL,
    UserId INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(30) DEFAULT 'Pending',
    PaidAt DATETIME NULL,

    FOREIGN KEY (GroupId) REFERENCES RideGroups(GroupId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE ScheduledRides (
    ScheduleId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    PickupLocation NVARCHAR(150) NOT NULL,
    Destination NVARCHAR(150) NOT NULL,
    VehicleType NVARCHAR(20) NOT NULL,
    RideTime TIME NOT NULL,
    DaysOfWeek NVARCHAR(100) NOT NULL,
    DistanceKm DECIMAL(6,2) NOT NULL,
    OriginalFare DECIMAL(10,2) NOT NULL,
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

USE ShareRideAI_DB;
GO

DECLARE @pass NVARCHAR(256);
SET @pass = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '123456'), 2));

INSERT INTO Users 
(FullName, UniversityId, Email, Phone, PasswordHash, Role)
VALUES
('Admin User', 'ADMIN-001', 'admin@shareride.com', '01700000000', @pass, 'Admin'),
('Rahim Ahmed', 'UNI-101', 'rahim@gmail.com', '01711111111', @pass, 'User'),
('Karim Hasan', 'UNI-102', 'karim@gmail.com', '01722222222', @pass, 'User'),
('Nusrat Jahan', 'UNI-103', 'nusrat@gmail.com', '01733333333', @pass, 'User'),
('Mehedi Islam', 'UNI-104', 'mehedi@gmail.com', '01744444444', @pass, 'User');

INSERT INTO RideRequests
(UserId, PickupLocation, Destination, RideDateTime, VehicleType, DistanceKm, OriginalFare)
VALUES
(2, 'Old Dhaka', 'University Campus', DATEADD(MINUTE, 10, GETDATE()), 'Bike', 8, 160),
(3, 'Old Dhaka', 'University Campus', DATEADD(MINUTE, 15, GETDATE()), 'Bike', 8, 160),
(4, 'Azimpur', 'University Campus', DATEADD(MINUTE, 12, GETDATE()), 'CNG', 7, 220),
(5, 'Mirpur', 'University Campus', DATEADD(MINUTE, 25, GETDATE()), 'Car', 12, 450);

INSERT INTO Notifications
(UserId, Title, Message, Type)
VALUES
(2, 'Welcome to ShareRide AI', 'Start booking your first shared ride today.', 'System'),
(3, 'Ride Match Available', 'A rider is going to the same destination.', 'Match');

SELECT * FROM Users;
 ALTER TABLE RideRequests ADD Seats INT NOT NULL DEFAULT 1;
  ALTER TABLE GroupMembers ADD MemberId INT IDENTITY(1,1) PRIMARY KEY;
  SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ScheduledRides';

IF COL_LENGTH('dbo.ScheduledRides', 'RideDateTime') IS NULL
BEGIN
    ALTER TABLE dbo.ScheduledRides
    ADD RideDateTime DATETIME NOT NULL DEFAULT GETDATE();
END;

IF COL_LENGTH('dbo.ScheduledRides', 'Days') IS NULL
BEGIN
    ALTER TABLE dbo.ScheduledRides
    ADD [Days] NVARCHAR(100) NOT NULL DEFAULT '';
END;
CREATE VIEW Rides AS
SELECT * FROM RideRequests
UNION ALL
SELECT * FROM RideGroups;
sp_help 'Rides';
Drop Rides
CREATE VIEW Rides AS
SELECT * FROM RideRequests
UNION ALL
SELECT * FROM RideGroups;
INSERT INTO RideRequests
(UserId, PickupLocation, Destination, RideDateTime, VehicleType, DistanceKm, OriginalFare, Status)
VALUES (@UserId, @Pickup, @Destination, @RideDateTime, @VehicleType, @DistanceKm, @OriginalFare, @Status);