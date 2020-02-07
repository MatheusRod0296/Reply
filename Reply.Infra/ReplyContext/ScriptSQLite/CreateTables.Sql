 create table Insurance
(
     [Id] Uniqueidentifier Primary key not null
    ,[FirstName] varchar(40) not null
    ,[LastName] varchar(40) not null
    ,[Document] char(11) not null
    ,[Age] int not null
    ,[VehicleBrand] varchar(50) not null
    ,[VehicleModel] varchar(50) not null
    ,[VehicleValue] decimal(18,2) not null
    ,[RiskRate] decimal not null
    ,[RiskPrize] decimal not null
    ,[PurePrize] decimal not null
    ,[CommercialPrize] decimal not null
)