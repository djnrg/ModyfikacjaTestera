IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[TestDescriptionSetup]')) 
   ALTER TABLE [dbo].[TestDescriptionSetup] 
   DISABLE  CHANGE_TRACKING
GO
