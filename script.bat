@echo off
set origen=%~p0
set total2=%origen%Database
set total=%origen%SistemaGestorDeInformes\SistemaGestorDeInformes\
echo tu variable es %total%
XCopy %total2% %total% /s
cd %total%
pause