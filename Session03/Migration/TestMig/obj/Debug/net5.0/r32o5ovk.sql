BEGIN TRANSACTION;
GO

ALTER TABLE [People] ADD [Age] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210204130823_age', N'5.0.2');
GO

COMMIT;
GO

