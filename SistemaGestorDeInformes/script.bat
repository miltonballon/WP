@echo off
set origen=%~p0
set total2=%origen%database.accdb
set total=%origen%SistemaGestorDeInformes\Bin\Debug\Database
echo tu variable es %total%
XCopy %total2% %total%
cd %total%
pause