IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[TestParameters]')) 
   ALTER TABLE [dbo].[TestParameters] 
   DISABLE  CHANGE_TRACKING
GO
