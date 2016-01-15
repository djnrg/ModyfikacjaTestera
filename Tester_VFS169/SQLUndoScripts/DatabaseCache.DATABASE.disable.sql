-- Ten kod może być użyty, by wyłączyć śledzenie zmian wewnątrz twojej bazy danych
-- Upewnij się, że wszystkie tabele przestały wykorzystywać śledzenie zmian przed wykonaniem tego kodu
    
IF EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'D:\PROJECTY PROGRAMOW\VISUAL STUDIO\MODYFIKACJATESTERA\TESTER_VFS169\DATABASE.MDF')) 
  ALTER DATABASE [D:\PROJECTY PROGRAMOW\VISUAL STUDIO\MODYFIKACJATESTERA\TESTER_VFS169\DATABASE.MDF] 
  SET  CHANGE_TRACKING = OFF
GO
