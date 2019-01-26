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
CREATE PROCEDURE [dbo].[EditBill]
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
update tbl_Bills
set			invoice = @invoice, date = @date, customerName = @customerName, customerAddress = @customerAddress, brokerName = @brokerName, truckNumber = @truckNumber, 
			driverName = @driverName, licenseNumber = @licenseNumber, driverNumber = @driverNumber, transport = @transport, insurance = @insurance, 
			policyNumber = @policyNumber, insuranceValue = @insuranceValue, totalQtl = @totalQtl, totalPkg = @totalPkg, totalWeight = @totalWeight, 
			totalAmount = @totalAmount, RsWords = @RsWords, freightRate = @freightRate, freightAmount = @freightAmount
where invoice = @invoice;
END
GO
