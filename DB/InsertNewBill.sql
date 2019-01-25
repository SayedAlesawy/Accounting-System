-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertNewBill]
	-- Add the parameters for the stored procedure here
	@invoice int,
	@date date,
	@customerName varchar(50),
	@customerAddress text,
	@brokerName varchar(50),
	@truckNumber int,
	@driverName varchar(50),
	@licenseNumber varchar(50),
	@driverNumber int, 
	@transport text,
	@insurance text,
	@policyNumber text,
	@insuranceValue decimal(18, 2),
	@totalQtl decimal(18, 2),
	@totalPkg decimal(18, 2),
	@totalWeight decimal(18, 2),
	@totalAmount decimal(18, 2),
	@RsWords text,
	@freightRate decimal(18, 2),
	@freightAmount decimal(18, 2)
AS
BEGIN
INSERT INTO tbl_Bills(invoice, date, customerName, customerAddress, brokerName, truckNumber, driverName, licenseNumber, driverNumber, transport, insurance, 
			policyNumber, insuranceValue, totalQtl, totalPkg, totalWeight, totalAmount, RsWords, freightRate, freightAmount)

Values (@invoice, @date, @customerName, @customerAddress, @brokerName, @truckNumber, @driverName, @licenseNumber, @driverNumber, @transport, @insurance, 
		@policyNumber, @insuranceValue, @totalQtl, @totalPkg, @totalWeight, @totalAmount, @RsWords, @freightRate, @freightAmount)
END
GO